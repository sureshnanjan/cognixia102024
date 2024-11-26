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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// The FormAuthentication class implements the IFormAuthentication interface and defines the 
    /// actions required for logging into the Heroku App. This class uses Selenium WebDriver 
    /// to perform operations such as navigating to the login page, entering credentials, 
    /// submitting the login form, and verifying the login status.
    /// </summary>
    public class FormAuthentication : HerokuAppCommon, IFormAuthentication
    {
        /// <summary>
        /// Initializes a new instance of the FormAuthentication class.
        /// </summary>
        public FormAuthentication()
        {
        }

        /// <summary>
        /// Navigates to the home page of the Heroku App.
        /// This method opens the URL of the Heroku App where the login form is located.
        /// </summary>
        public void GetNavigatedTo()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com");
        }

        /// <summary>
        /// Enters the login credentials (username and password) into the corresponding form fields.
        /// This method simulates typing the username and password into the login form on the webpage.
        /// </summary>
        public void GetCredentials()
        {
            IWebElement usernameField = driver.FindElement(By.Id("username"));
            usernameField.SendKeys("yourUsername");

            IWebElement passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys("yourPassword");
        }

        /// <summary>
        /// Submits the login form by sending the "Enter" key to the password field.
        /// This method simulates the action of submitting the login form after entering credentials.
        /// </summary>
        public void GetIntoLogin()
        {
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys(Keys.Enter);
        }

        /// <summary>
        /// Verifies whether the login was successful by checking for the presence of specific elements.
        /// This method checks if the login success indicator is visible or if an error message is displayed.
        /// </summary>
        public void VerifyingLoginSuccessorFail()
        {
            // Check for an element that is only visible after login (e.g., the user profile button)
            try
            {
                IWebElement userProfileButton = driver.FindElement(By.LinkText("Login Success"));
                // Add verification logic here if needed
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Login failed.");
            }

            // Check if the error message is displayed (example: "Invalid username or password")
            try
            {
                IWebElement errorMessage = driver.FindElement(By.Id("errorMessage")); // Change this ID based on your app's error message element
                Console.WriteLine("Error Message: " + errorMessage.Text);

                // Validate if the error message is correct
                if (errorMessage.Text.Contains("Invalid username"))
                {
                    Console.WriteLine("Test passed: Correct error message displayed for invalid username.");
                }
                else
                {
                    Console.WriteLine("Test failed: Unexpected error message.");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Error message not found. Login might have succeeded, or the element is different.");
            }
        }

        /// <summary>
        /// Verifies that the login was successful by checking for the presence of a logout button.
        /// This method assumes that the presence of the logout button indicates a successful login.
        /// </summary>
        public void VerifyingLogin()
        {
            // Example of post-login check: Verify if logout button is visible
            IWebElement logoutButton = driver.FindElement(By.Id("logoutButton"));
            // Add verification logic here if needed
        }
    }
}
