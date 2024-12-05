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
    /// Represents the Digest Authentication page on the HerokuApp website.
    /// Provides functionality to perform authentication and retrieve success messages.
    /// </summary>
    public class DigestAuth : HerokuAppCommon, IDigestAuth
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DigestAuth"/> class.
        /// Navigates to the Digest Authentication page.
        /// </summary>
        public DigestAuth() : base()
        {
            // Navigate to the digest authentication page
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/digest_auth");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DigestAuth"/> class with a custom WebDriver.
        /// </summary>
        /// <param name="driver">The WebDriver to interact with the page.</param>
        public DigestAuth(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Performs authentication by embedding the credentials (username and password) in the URL.
        /// </summary>
        /// <param name="username">The username to authenticate.</param>
        /// <param name="password">The password associated with the username.</param>
        public void Authenticate(string username, string password)
        {
            // Construct the URL with embedded credentials for digest authentication
            string fullUrl = $"https://{username}:{password}@the-internet.herokuapp.com/digest_auth";
            // Navigate to the URL with credentials for authentication
            driver.Navigate().GoToUrl(fullUrl);
        }

        /// <summary>
        /// Retrieves the success message displayed after successful authentication.
        /// </summary>
        /// <returns>The success message text if found, otherwise a fallback message.</returns>
        public string GetSuccessMessage()
        {
            try
            {
                // Attempt to find the success message element on the page
                IWebElement messageElement = driver.FindElement(By.XPath("//div[@class='example']/p"));
                // Return the text of the success message
                return messageElement.Text;
            }
            catch (NoSuchElementException)
            {
                // Handle the case where the success message element is not found
                return "Success message not found.";
            }
        }
        public string GetPageTitle()
        {
            return driver.FindElement(By.TagName("h3")).Text;
        }
        public string GetPageDescription()
        {
            return driver.FindElement(By.TagName("p")).Text; // Assuming the description is in a <p> tag.
        }

        public void Quit()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }

}
