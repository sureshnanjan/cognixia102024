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

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents the Status Codes page on the HerokuApp website.
    /// Provides functionality to interact with and verify the page.
    /// </summary>
    public class StatusCodes : HerokuAppCommon, IStatusCodes
    {
        // Locator for the page header
        private readonly By pageHeader = By.TagName("h3");

        // Locator for the text describing the HTTP status code
        private readonly By statusCodeText = By.TagName("p");

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCodesPage"/> class.
        /// </summary>
        /// <param name="driver">The Selenium WebDriver used to interact with the page.</param>
        public StatusCodes(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Navigates to the page for a specific HTTP status code.
        /// </summary>
        /// <param name="code">The HTTP status code to navigate to (e.g., "200", "404").</param>
        public void NavigateToStatusCode(string code)
        {
            driver.Navigate().GoToUrl($"https://the-internet.herokuapp.com/status_codes/{code}");
        }

        /// <summary>
        /// Retrieves the header text of the Status Codes page.
        /// </summary>
        /// <returns>A string representing the header text of the page.</returns>
        public string GetPageHeader()
        {
            return driver.FindElement(pageHeader).Text;
        }

        /// <summary>
        /// Retrieves the descriptive text of the HTTP status code from the page.
        /// </summary>
        /// <returns>A string representing the description of the HTTP status code.</returns>
        public string GetStatusCodeText()
        {
            return driver.FindElement(statusCodeText).Text;
        }
    }
}
