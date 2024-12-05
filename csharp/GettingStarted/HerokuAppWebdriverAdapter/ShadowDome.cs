
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
under the License.*/

using System;
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// This class interacts with the Shadow DOM elements on the specified URL.
    /// It provides methods to retrieve text content from the Shadow DOM and perform necessary cleanup.
    /// </summary>
    public class ShadowDom : IShadowDom
    {
        private readonly IWebDriver driver;
        private readonly string url = "https://the-internet.herokuapp.com/shadowdom";  // URL of the Shadow DOM page
        private readonly By shadowHostLocator = By.TagName("my-app");  // Locator to find the shadow host element

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowDom"/> class.
        /// This constructor sets up the WebDriver (ChromeDriver) and navigates to the Shadow DOM page.
        /// </summary>
        public ShadowDom()
        {
            // Initialize the WebDriver (ChromeDriver) here
            driver = new ChromeDriver();  // You can replace ChromeDriver with another driver if needed
            driver.Navigate().GoToUrl(url);  // Navigate to the Shadow DOM page
        }

        /// <summary>
        /// Retrieves the text content inside the Shadow DOM by accessing the shadow root.
        /// </summary>
        /// <returns>
        /// A string containing the text content inside the Shadow DOM.
        /// Returns an empty string if there is an error or no text is found.
        /// </returns>
        public string GetShadowText()
        {
            try
            {
                // Find the shadow host element.
                var shadowHost = driver.FindElement(shadowHostLocator);

                // Use JavaScript to access the shadow root and fetch text content.
                var jsExecutor = (IJavaScriptExecutor)driver;
                string script = @"
                    return arguments[0].shadowRoot.querySelector('my-container').shadowRoot
                        .querySelector('content').textContent.trim();";
                var shadowText = (string)jsExecutor.ExecuteScript(script, shadowHost);

                return shadowText;
            }
            catch (Exception e)
            {
                // Log any error that occurs during interaction with the Shadow DOM
                Console.WriteLine($"Error interacting with Shadow DOM: {e.Message}");
                return string.Empty;  // Return an empty string if an error occurs
            }
        }

        /// <summary>
        /// Cleans up the WebDriver by quitting the browser and disposing of the WebDriver instance.
        /// This should be called after test execution to ensure proper resource management.
        /// </summary>
        public void CleanUp()
        {
            if (driver != null)
            {
                driver.Quit();  // Close the browser window
                driver.Dispose();  // Dispose of the WebDriver instance to release resources
            }
        }
    }
}
