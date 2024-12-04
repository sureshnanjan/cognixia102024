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

using HerokuAppOperations; // Importing the interface that this class implements (IBasicAuth).
using OpenQA.Selenium.Edge; // Importing the Selenium EdgeDriver (not used here but can be an alternative browser).
using OpenQA.Selenium.Support.UI; // Importing support for WebDriverWait, which helps with waiting for elements.
using OpenQA.Selenium; // Importing Selenium WebDriver, which is used for automating the browser.
using System; // Importing System namespace for basic types like string, int, etc.
using System.Collections.Generic; // Importing the System.Collections.Generic namespace (useful for collections like List, Dictionary).
using System.Linq; // Importing LINQ, which is useful for querying collections (not used here).
using System.Text; // Importing the System.Text namespace (could be used for string manipulations).
using System.Threading.Tasks; // Importing for asynchronous tasks (not needed here but could be useful in the future).
using OpenQA.Selenium.Chrome; // Importing the ChromeDriver from Selenium, used to interact with Chrome browser.

namespace HerokuAppWebdriverAdapter
{
    // Implementation of the IBasicAuth interface for Basic Authentication handling on the Heroku app.
    public class BasicAuth : IBasicAuth
    {
        // WebDriver instance, which will be used to interact with the browser.
        public IWebDriver driver;

        // Basic Authentication credentials (username and password)
        public string username = "admin";
        public string password = "admin";

        // URL for the Basic Auth page on Heroku app
        public string url = "https://the-internet.herokuapp.com/basic_auth";

        // Constructor to initialize the WebDriver. Here, we're using ChromeDriver but it could be any other driver (Edge, Firefox, etc.)
        public BasicAuth()
        {
            driver = new ChromeDriver();  // ChromeDriver is used to open the Chrome browser. You can also use EdgeDriver or FirefoxDriver.
        }

        // Method to navigate to the Basic Authentication page, using embedded credentials in the URL.
        public void NavigateToBasicAuthPage()
        {
            // Formulate the URL with credentials (username and password embedded directly into the URL).
            string authUrl = $"https://{username}:{password}@the-internet.herokuapp.com/basic_auth";

            // Navigate to the URL with the credentials embedded, allowing automatic authentication.
            driver.Navigate().GoToUrl(authUrl);  // This takes the user directly to the page with the credentials embedded in the URL.
        }

        // Method to validate if the authentication was successful by checking for a success message.
        public bool IsAuthenticationSuccessful()
        {
            // Wait for the page to load completely and check for the success message element.
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));  // Create a WebDriverWait instance to wait for up to 10 seconds.
            wait.Until(driver => driver.FindElement(By.XPath("//div[@class='example']")));  // Wait until the 'example' div is present, indicating the page is loaded.

            // Find the success message on the page by locating the h3 element inside the 'example' div.
            var successMessage = driver.FindElement(By.XPath("//div[@class='example']/h3")).Text;

            // Check if the success message contains the text "Congratulations!", indicating successful authentication.
            return successMessage.Contains("Congratulations!");  // Return true if the success message is found, otherwise false.
        }

        // Method to print the success message if the authentication was successful.
        public void PrintSuccessMessage()
        {
            // Check if authentication was successful by calling the IsAuthenticationSuccessful method.
            if (IsAuthenticationSuccessful())
            {
                // If successful, get the success message and print it to the console.
                var successMessage = driver.FindElement(By.XPath("//div[@class='example']/h3")).Text;
                Console.WriteLine("Authentication Successful: " + successMessage);  // Print the success message to the console.
            }
            else
            {
                // If authentication failed, print a failure message.
                Console.WriteLine("Authentication Failed.");  // Print a message indicating that authentication was unsuccessful.
            }
        }

        // Method to log in by entering credentials in a form (not part of the original, added here).
        public void EnterUsername(string username)
        {
            // Find the username input field by its XPath and enter the username.
            var usernameField = driver.FindElement(By.Id("username"));  // Locate the username input field using its ID.
            usernameField.SendKeys(username);  // Enter the username into the input field.
        }

        // Method to enter the password for logging in (not part of the original, added here).
        public void EnterPassword(string password)
        {
            // Find the password input field by its XPath and enter the password.
            var passwordField = driver.FindElement(By.Id("password"));  // Locate the password input field using its ID.
            passwordField.SendKeys(password);  // Enter the password into the input field.
        }

        // Method to click the login button (added here for the sign-in process).
        public void ClickSignInButton()
        {
            // Locate the login button using its XPath and click it to submit the login form.
            var loginButton = driver.FindElement(By.XPath("//button[@type='submit']"));  // Locate the login button using XPath.
            loginButton.Click();  // Click the login button to submit the credentials.
        }

        // Method to verify if the user was redirected to a dashboard or homepage after login.
        public bool IsUserRedirectedToDashboard()
        {
            // Check if the page contains a specific element that indicates successful login/redirect.
            try
            {
                // Wait for the page to load and look for an element that only appears after successful login.
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));  // Set a maximum wait time of 10 seconds.
                wait.Until(driver => driver.FindElement(By.Id("dashboard")));  // Look for the 'dashboard' element to confirm redirection.

                // Return true if the element is found, indicating successful redirection.
                return true;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, it means the redirection didn't happen successfully.
                return false;
            }
        }

        // Method to log out the user (added here).
        public void LogOut()
        {
            // Locate and click the logout button to log out the user.
            var logoutButton = driver.FindElement(By.XPath("//button[@id='logout']"));  // Locate the logout button using its ID or XPath.
            logoutButton.Click();  // Click the logout button to log the user out.
        }

        // Cleanup method to quit the WebDriver and close the browser after tests.
        public void Cleanup()
        {
            driver.Quit();  // Close the browser and quit the WebDriver instance.
        }

        public bool IsOnLoginPage()
        {
            throw new NotImplementedException();
        }
    }
}


