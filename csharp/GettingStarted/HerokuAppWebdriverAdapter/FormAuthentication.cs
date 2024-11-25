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
    public class FormAuthentication : HerokuAppCommon ,IFormAuthentication
    {
        public FormAuthentication()
        {
            
        }
        public void GetNavigated()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com");

        }
        public void GetCredentials()
        {
            IWebElement usernameField = driver.FindElement(By.Id("username"));
            usernameField.SendKeys("yourUsername");

            IWebElement passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys("yourPassword");
        }
        public void GetIntoLogin()
        {
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys(Keys.Enter);

        }
        public void VerifyingLoginSuccessful()
        {
            // Check for an element that is only visible after login (e.g., the user profile button)
            try
            {
                IWebElement userProfileButton = driver.FindElement(By.LinkText("Login Success"));
               
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Login failed.");
            }
            try
            {
                // Check if the error message is displayed (example: "Invalid username or password")
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
        public void VerifyLogin()
        {
            // Example of post-login check: Verify if logout button is visible
            IWebElement logoutButton = driver.FindElement(By.Id("logoutButton"));
            

        }
    }
}
