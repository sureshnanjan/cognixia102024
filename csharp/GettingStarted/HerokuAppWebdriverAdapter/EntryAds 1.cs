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
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using HerokuAppOperations;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// EntryAd class encapsulates actions and verifications on the Entry Ad modal on the Heroku app page.
    /// It interacts with modal elements like the modal body, close button, and "Click Here" link.
    /// </summary>
    public class EntryAd : HerokuAppCommon, IEntryAd
    {
        // Locators for the modal and related elements
        private readonly By modalWindowLocator = By.Id("modal");
        private readonly By modalTitleLocator = By.CssSelector(".modal-title h3");
        private readonly By modalBodyLocator = By.CssSelector(".modal-body p");
        private readonly By closeModalButtonLocator = By.CssSelector(".modal-footer p");
        private readonly By clickHereLinkLocator = By.LinkText("Click Here");

        // WebDriverWait for explicit waits
        private WebDriverWait wait;

        /// <summary>
        /// Constructor to initialize the page and navigate to the Entry Ad page.
        /// Also initializes the WebDriverWait for waiting on elements.
        /// </summary>
        /// <param name="driver">The IWebDriver instance to interact with the browser</param>
        public EntryAd(IWebDriver driver) : base(driver)
        {
            // Navigate to the Entry Ad page of Heroku app
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/entry_ad");
            // Initialize WebDriverWait with a timeout of 10 seconds
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// Checks if the modal is currently displayed on the page.
        /// </summary>
        /// <returns>True if modal is displayed, otherwise false</returns>
        public bool IsModalDisplayed()
        {
            try
            {
                // Wait until the modal window is displayed
                wait.Until(driver => driver.FindElement(modalWindowLocator).Displayed);
                return driver.FindElement(modalWindowLocator).Displayed;
            }
            catch (WebDriverTimeoutException)
            {
                // If modal is not found within the timeout, log and return false
                Console.WriteLine("Modal was not displayed within the timeout period.");
                return false;
            }
        }

        /// <summary>
        /// Closes the modal window by clicking the close button.
        /// </summary>
        public void CloseModal()
        {
            try
            {
                // Wait for the close button to be clickable
                IWebElement closeButton = wait.Until(driver =>
                    driver.FindElement(closeModalButtonLocator).Displayed ? driver.FindElement(closeModalButtonLocator) : null);

                // If the close button is displayed and enabled, click it to close the modal
                if (closeButton != null && closeButton.Displayed && closeButton.Enabled)
                {
                    closeButton.Click();
                }
                else
                {
                    // Log if the close button is not clickable
                    Console.WriteLine("Close button is not clickable.");
                }
            }
            catch (WebDriverTimeoutException)
            {
                // Log timeout error if close button is not found or clickable
                Console.WriteLine("Close button was not found or clickable within the timeout period.");
            }
        }

        /// <summary>
        /// Retrieves the content of the modal body.
        /// </summary>
        /// <returns>The text content of the modal body</returns>
        public string GetModalBodyContent()
        {
            try
            {
                // Wait for the modal body to be visible
                IWebElement bodyElement = wait.Until(driver =>
                    driver.FindElement(modalBodyLocator).Displayed ? driver.FindElement(modalBodyLocator) : null);

                // Log the retrieved modal body content for debugging
                Console.WriteLine($"Debug: Retrieved Modal Body Content: '{bodyElement.Text}'");
                return bodyElement.Text;
            }
            catch (WebDriverTimeoutException)
            {
                // If modal body is not found or not visible, log the error and return empty string
                Console.WriteLine("Modal body content not found or not visible within the timeout period.");
                return string.Empty;
            }
        }

        /// <summary>
        /// Clicks the "Click Here" link to reopen the modal.
        /// </summary>
        public void ReopenModal()
        {
            try
            {
                // Wait for the "Click Here" link to be visible and clickable
                IWebElement clickHereLink = wait.Until(driver =>
                    driver.FindElement(clickHereLinkLocator).Displayed ? driver.FindElement(clickHereLinkLocator) : null);

                // If the link is displayed and clickable, click it to reopen the modal
                if (clickHereLink != null && clickHereLink.Displayed && clickHereLink.Enabled)
                {
                    clickHereLink.Click();
                }
                else
                {
                    // Log if the link is not clickable
                    Console.WriteLine("'Click Here' link is not clickable.");
                }
            }
            catch (WebDriverTimeoutException)
            {
                // Log timeout error if the link was not clickable within the timeout period
                Console.WriteLine("'Click Here' link was not clickable within the timeout period.");
            }
        }
    }
}
