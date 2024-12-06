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
using OpenQA.Selenium;
using HerokuAppOperations;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents the 'Forgot Password' page on the HerokuApp website.
    /// Provides functionality to interact with and verify the 'Forgot Password' functionality.
    /// </summary>
    public class ForgotPasswordPage : HerokuAppCommon, IForgotPassword
    {
        // Locator for the email input field
        private readonly By emailFieldLocator = By.Id("email");

        // Locator for the 'Retrieve Password' button
        private readonly By retrievePasswordButtonLocator = By.XPath("//i[contains(text(),'Retrieve password')]");

        // Locator for the page title
        private readonly By pageTitleLocator = By.TagName("h2");

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgotPasswordPage"/> class.
        /// Navigates to the 'Forgot Password' page.
        /// </summary>
        public ForgotPasswordPage() : base()
        {
            // Navigate to the 'Forgot Password' page
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/forgot_password");
        }

        /// <summary>
        /// Retrieves the title of the 'Forgot Password' page.
        /// </summary>
        /// <returns>The title of the page as a string.</returns>
        public string GetTitle()
        {
            try
            {
                // Retrieve the title of the page
                return driver.FindElement(pageTitleLocator).Text;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Page title element not found.");
                return string.Empty;
            }
        }

        /// <summary>
        /// Verifies if the 'Forgot Password' button is enabled or clickable.
        /// </summary>
        public void VerifyingButton()
        {
            try
            {
                // Find the 'Retrieve Password' button and check if it is enabled
                var retrievePasswordButton = driver.FindElement(retrievePasswordButtonLocator);
                if (retrievePasswordButton.Enabled)
                {
                    Console.WriteLine("The 'Retrieve Password' button is enabled.");
                }
                else
                {
                    Console.WriteLine("The 'Retrieve Password' button is disabled.");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("The 'Retrieve Password' button was not found.");
            }
        }

        /// <summary>
        /// Enters the email address into the 'Forgot Password' form field.
        /// </summary>
        public void EnteringEmail()
        {
            try
            {
                // Find the email input field and enter a sample email address
                var emailField = driver.FindElement(emailFieldLocator);
                emailField.Clear();
                emailField.SendKeys("testuser@example.com");
                Console.WriteLine("Email entered successfully.");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Email input field not found.");
            }
        }

        /// <summary>
        /// Clicks the 'Retrieve Password' button to initiate the password retrieval process.
        /// </summary>
        public void ClickingRetrievePassword()
        {
            try
            {
                // Find the 'Retrieve Password' button and click it
                var retrievePasswordButton = driver.FindElement(retrievePasswordButtonLocator);
                retrievePasswordButton.Click();
                Console.WriteLine("Clicked the 'Retrieve Password' button.");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("The 'Retrieve Password' button was not found.");
            }
        }
    }
}
