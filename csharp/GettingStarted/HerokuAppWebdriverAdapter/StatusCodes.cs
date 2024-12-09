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
        // private IWebDriver driver;

        // Locator for the page header (<h3> tag)
        private readonly By pageHeader = By.TagName("h3");

        // Locator for the status code text (<p> tag)
        private readonly By statusCodeText = By.TagName("p");

        // Constructor initializes the driver
        public StatusCodes(IWebDriver driver)
        {
            this.driver = driver;
        }
        //public StatusCodes(IWebDriver driver) : base(driver) { }

        // Navigates to the page for a specific HTTP status code
        public void NavigateToStatusCode(string code)
        {
            driver.Navigate().GoToUrl($"https://the-internet.herokuapp.com/status_codes/{code}");
        }

        // Retrieves the page title (<title> tag)
        public string GetPageTitle()
        {
            return driver.Title;  // This gets the <title> tag content of the HTML page
        }

        // Retrieves the header text (from <h3> tag)
        public string GetPageHeader()
        {
            return driver.FindElement(pageHeader).Text;
        }

        // Retrieves the descriptive text (from <p> tag)
        public string GetStatusCodeText()
        {
            return driver.FindElement(statusCodeText).Text;
        }

        // Close the browser (cleanup after tests)
        public void CloseBrowser()
        {
            driver.Quit(); // This properly closes the browser after the tests are completed
        }
    }
}
