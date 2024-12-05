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

using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Class that provides functionality for interacting with the context menu on the Heroku app's context menu page.
    /// It initializes the WebDriver and interacts with the context menu using the Selenium WebDriver and Actions class.
    /// </summary>
    public class ContextMenu : HerokuAppCommon, IContextMenu
    {
        private IWebElement _contextMenuBox;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextMenu"/> class.
        /// Locates the context menu box on the page.
        /// Initializes WebDriver and navigates to the context menu page.
        /// </summary>
        public ContextMenu() : base()  // Calls the base constructor to initialize WebDriver and navigate to the app URL.
        {
            // Navigate to the context menu page specifically
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/context_menu");

            // Locate the context menu box element
            _contextMenuBox = driver.FindElement(By.Id("hot-spot"));
        }

        /// <summary>
        /// Performs the right-click (context click) operation on the context menu box to trigger the context menu.
        /// </summary>
        public void RightClickOnBox()
        {
            // Perform a right-click (context click) on the context menu box
            var actions = new Actions(driver);
            actions.ContextClick(_contextMenuBox).Build().Perform();
        }

        /// <summary>
        /// Gets the text of the alert that appears after right-clicking on the context menu box.
        /// </summary>
        /// <returns>The text inside the alert box.</returns>
        public string GetAlertText()
        {
            // Switch to the alert and retrieve the text
            IAlert alert = driver.SwitchTo().Alert();
            return alert.Text;
        }

        /// <summary>
        /// Accepts the alert that appears after right-clicking on the context menu box.
        /// </summary>
        public void AcceptAlert()
        {
            // Switch to the alert and accept it
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        /// <summary>
        /// Dismisses the alert that appears after right-clicking on the context menu box.
        /// </summary>
        public void DismissAlert()
        {
            // Switch to the alert and dismiss it
            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }

        /// <summary>
        /// Cleans up by quitting the WebDriver instance.
        /// </summary>
        public void CleanUp()
        {
            driver.Quit(); // Quit the WebDriver after operation
        }
    }
}
