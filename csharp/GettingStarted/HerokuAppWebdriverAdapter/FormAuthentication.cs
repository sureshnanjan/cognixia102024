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
using OpenQA.Selenium.Chrome;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Adapter class for the Form Authentication page.
    /// Implements the methods defined in the IFormAuthentication interface.
    /// Provides functionality for logging in, retrieving credentials, and verifying login success or failure.
    /// </summary>
    public class FormAuthenticationPage : IFormAuthentication
    {
        private readonly IWebDriver driver;

        // Locator for username and password fields, and the login button.
        private readonly By usernameField = By.Id("username");
        private readonly By passwordField = By.Id("password");
        private readonly By loginButton = By.CssSelector("button[type='submit']");
        private readonly By loginErrorMessage = By.CssSelector(".flash.error");
        private readonly By loginSuccessMessage = By.CssSelector(".flash.success");

        /// <summary>
        /// Initializes a new instance of the FormAuthenticationPage class.
        /// Navigates to the login page.
        /// </summary>
        public FormAuthenticationPage()
        {
            driver = new ChromeDriver(); // Assuming ChromeDriver, adjust based on your setup.
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
        }

        /// <summary>
        /// Retrieves the title of the 'Forgot Password' page.
        /// </summary>
        /// <returns>The page title.</returns>
        public string GetTitle()
        {
            return driver.Title;
        }

        /// <summary>
        /// Verifies if the 'Forgot Password' button is enabled or clickable.
        /// </summary>
        public void VerifyingButton()
        {
            try
            {
                var button = driver.FindElement(loginButton);
                bool isEnabled = button.Enabled;
                if (isEnabled)
                {
                    Console.WriteLine("Login button is enabled.");
                }
                else
                {
                    Console.WriteLine("Login button is disabled.");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Login button not found.");
            }
        }

        /// <summary>
        /// Enters the email address into the 'Forgot Password' form field.
        /// </summary>
        public void EnteringEmail()
        {
            try
            {
                var usernameFieldElement = driver.FindElement(usernameField);
                var passwordFieldElement = driver.FindElement(passwordField);

                usernameFieldElement.SendKeys("tomsmith"); // Enter the valid username.
                passwordFieldElement.SendKeys("SuperSecretPassword!"); // Enter the valid password.
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Username or password field not found.");
            }
        }

        /// <summary>
        /// Clicks the 'Retrieve Password' button to initiate the password retrieval process.
        /// </summary>
        public void ClickingRetrievePassword()
        {
            try
            {
                var loginButtonElement = driver.FindElement(loginButton);
                loginButtonElement.Click();
                Console.WriteLine("Clicked on the login button.");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Login button not found.");
            }
        }

        /// <summary>
        /// Submits the login form with the entered credentials.
        /// </summary>
        public void GetIntoLogin()
        {
            EnteringEmail();
            ClickingRetrievePassword();
        }

        /// <summary>
        /// Verifies whether the login attempt was successful or failed.
        /// </summary>
        public void VerifyingLoginSuccessorFail()
        {
            try
            {
                var errorMessage = driver.FindElements(loginErrorMessage);
                var successMessage = driver.FindElements(loginSuccessMessage);

                if (errorMessage.Count > 0)
                {
                    Console.WriteLine("Login failed: " + errorMessage[0].Text);
                }
                else if (successMessage.Count > 0)
                {
                    Console.WriteLine("Login successful: " + successMessage[0].Text);
                }
                else
                {
                    Console.WriteLine("Login result could not be determined.");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Error occurred while verifying login result.");
            }
        }

        /// <summary>
        /// Verifies the login status by checking if the user is logged in or if an error occurred.
        /// </summary>
        public void VerifyingLogin()
        {
            try
            {
                var errorMessage = driver.FindElements(loginErrorMessage);
                if (errorMessage.Count > 0)
                {
                    Console.WriteLine("Login failed: " + errorMessage[0].Text);
                }
                else
                {
                    Console.WriteLine("Login successful.");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Error occurred while verifying login status.");
            }
        }

        /// <summary>
        /// Closes the browser.
        /// </summary>
        public void Quit()
        {
            driver.Quit();
        }

        public void GetNavigatedTo()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
        }

        public void GetCredentials()
        {
            string username = "tomsmith";
            string password = "SuperSecretPassword!";

            // Find username and password fields on the page
            IWebElement usernameField = driver.FindElement(By.Id("username"));
            IWebElement passwordField = driver.FindElement(By.Id("password"));

            // Enter the credentials into the fields
            usernameField.SendKeys(username);
            passwordField.SendKeys(password); ;
        }
    }
}
