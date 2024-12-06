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
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Class for handling A/B testing functionality. Inherits common functionality from HerokuAppCommon.
    /// Implements the IABTest interface.
    /// </summary>

    public class ABTest : HerokuAppCommon, IABTest
    {
        //public void OptInABTest()
        //{
        //    driver.Manage().Cookies.DeleteCookie(new Cookie("optimizelyOptOut", "true"));
        //}

        //public void OptOutABTest()
        //{
        //    driver.Manage().Cookies.AddCookie(new Cookie("optimizelyOptOut", "true"));
        //}
        // Locator for the A/B Test message element on the page.
        //private readonly By abTestMessageLocator = By.XPath("//h3[normalize-space()='A/B Test Variation 1']");

        /// <summary>
        /// Initializes a new instance of the ABTest class and navigates to the A/B Test page.
        /// </summary>

        public ABTest(IWebDriver driver) : base(driver)
        {
            // Navigate to the A/B Test page on Heroku app.
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/abtest");
        }
        public ABTest()
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/abtest");
        }
        /// <summary>
        /// Gets the text of the A/B Test message displayed on the page.
        /// </summary>

        public string GetABTestMessage()
        {
            try
            {
                // Attempt to find and return the A/B Test message text.
                var messageElement = driver.FindElement(By.XPath("//h3[normalize-space()='A/B Test Variation 1']"));
                return messageElement.Text;
            }
            catch (NoSuchElementException)
            {
                // Return a default message if the element is not found.
                return "No message displayed.";
            }
        }

        /// <summary>
        /// Gets the current URL of the page being displayed in the browser.
        /// </summary>

        public string GetCurrentUrl()
        {
            return driver.Url;
        }
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}