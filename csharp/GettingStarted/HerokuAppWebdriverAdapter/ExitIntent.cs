/*
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
 
  http://www.apache.org/licenses/LICENSE-2.0
 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Handles interactions with the ExitIntent modal window in a Heroku app.
    /// </summary>
    public class ExitIntent : HerokuAppCommon, IExitIntent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExitIntent"/> class with the specified WebDriver.
        /// </summary>
        /// <param name="driver">The WebDriver instance used to interact with the browser.</param>
        public ExitIntent(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Retrieves the title of the current webpage.
        /// </summary>
        /// <returns>The title of the webpage.</returns>
        public string GetTitle()
        {
            return driver.Title;
        }

        /// <summary>
        /// Retrieves the description text related to the ExitIntent modal.
        /// </summary>
        /// <returns>A string containing the description text.</returns>
        public string GetDescription()
        {
            // Locate the paragraph element containing the description text
            IWebElement paragraph = driver.FindElement(By.XPath("//p[contains(text(),'Mouse out of the viewport pane and see a modal win')]"));
            return paragraph.Text;
        }

        /// <summary>
        /// Opens the ExitIntent modal by simulating a mouse movement out of the viewport.
        /// </summary>
        public void OpenModalWindow()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Trigger a 'mouseleave' event to open the modal
            jsExecutor.ExecuteScript("var event = new MouseEvent('mouseleave', { view: window, bubbles: true, cancelable: true }); document.body.dispatchEvent(event);");

            // Wait for the modal to appear
            Thread.Sleep(3000); // Adjust delay as necessary
        }

        /// <summary>
        /// Closes the ExitIntent modal by clicking the "Close" button.
        /// </summary>
        public void CloseModalWindow()
        {
            // Locate the "Close" button and click it
            var closeButton = driver.FindElement(By.XPath("//p[normalize-space()='Close']"));
            Thread.Sleep(3000); // Provide a delay if needed
            closeButton.Click();
        }
    }
}