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
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents the Slow Resources page on the HerokuApp website.
    /// Provides functionality to interact with and verify the page, including waiting for slow-loading content.
    /// </summary>
    public class SlowResources : HerokuAppCommon, ISlowResources
    {
        // Locator for the page header element
        private readonly By header = By.TagName("h3");

        // Locator for the content paragraph element
        private readonly By content = By.TagName("p");

        /// <summary>
        /// Initializes a new instance of the <see cref="SlowResources"/> class.
        /// </summary>
        /// <param name="driver">The Selenium WebDriver used to interact with the page.</param>
        public SlowResources(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Retrieves the header text from the Slow Resources page.
        /// </summary>
        /// <returns>A string representing the header text of the page.</returns>
        public string GetHeaderText()
        {
            return driver.FindElement(header).Text;
        }

        /// <summary>
        /// Waits for the content to load and retrieves the content text.
        /// The method waits until the content element is displayed within the specified timeout period.
        /// </summary>
        /// <param name="timeoutInSeconds">The time to wait for the content to load (in seconds).</param>
        /// <returns>A string representing the content text of the page after it has loaded.</returns>
        public string GetContentAfterLoading(int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(d => d.FindElement(content).Displayed);
            return driver.FindElement(content).Text;
        }
    }
}
