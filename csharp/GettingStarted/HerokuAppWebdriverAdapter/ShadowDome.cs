
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
using System;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class ShadowDom : IShadowDom
    {
        private readonly IWebDriver driver;
        private readonly string url = "https://the-internet.herokuapp.com/shadowdom";
        private readonly By shadowHostLocator = By.TagName("my-app");

        // Constructor to initialize WebDriver and navigate to the page.
        public ShadowDom(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver), "WebDriver cannot be null");
            driver.Navigate().GoToUrl(url);  // Navigate to Shadow DOM page
        }

        // Method to retrieve the text content inside the Shadow DOM.
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
                Console.WriteLine($"Error interacting with Shadow DOM: {e.Message}");
                return string.Empty;
            }
        }

        // Cleanup method to close the WebDriver.
        public void CleanUp()
        {
            if (driver != null)
            {
                driver.Quit();  // Close the browser window.
                driver.Dispose();  // Dispose of the WebDriver instance.
            }
        }
    }
}
