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
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    /// <summary>
    /// Handles operations related to browser windows such as opening, switching between,
    /// and closing windows using Selenium WebDriver.
    /// </summary>
    public class WindowOperations : HerokuAppCommon, IWindowOperations
    {
        // Locator for the "Click Here" link that opens a new window.
        private readonly By newWindowLink = By.LinkText("Click Here");

        // Stores the handle of the original window.
        private string originalWindowHandle;

        // Stores all the current window handles.
        private List<string> windowHandles;

        /// <summary>
        /// Constructor initializes the driver and navigates to the target URL.
        /// </summary>
        /// <param name="driver">The Selenium WebDriver instance.</param>
        public WindowOperations(IWebDriver driver) : base(driver)
        {
            // Navigate to the target webpage for window operations.
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");

            // Store the handle of the original window.
            originalWindowHandle = driver.CurrentWindowHandle;
        }

        /// <summary>
        /// Opens a new browser window by clicking the specified link.
        /// </summary>
        public void OpenNewWindow()
        {
            try
            {
                // Locate and click the link to open a new window.
                driver.FindElement(newWindowLink).Click();

                // Update the list of window handles to include the new window.
                UpdateWindowHandles();
            }
            catch (NoSuchElementException)
            {
                // Handle case where the "Click Here" link is not found.
                Console.WriteLine("New window link not found.");
            }
        }

        /// <summary>
        /// Switches the WebDriver's focus to the newly opened browser window.
        /// </summary>
        public void SwitchToNewWindow()
        {
            // Ensure there is more than one window available.
            if (windowHandles.Count > 1)
            {
                foreach (var handle in windowHandles)
                {
                    // Switch to the window that is not the original.
                    if (handle != originalWindowHandle)
                    {
                        driver.SwitchTo().Window(handle);
                        break;
                    }
                }
            }
            else
            {
                // Handle case where no new window is available.
                Console.WriteLine("No new window to switch to.");
            }
        }

        /// <summary>
        /// Switches the WebDriver's focus back to the original browser window.
        /// </summary>
        public void SwitchToOriginalWindow()
        {
            // Switch to the original window using its stored handle.
            driver.SwitchTo().Window(originalWindowHandle);
        }

        /// <summary>
        /// Retrieves the title of the currently focused browser window.
        /// </summary>
        /// <returns>The title of the current window as a string.</returns>
        public string GetCurrentWindowTitle()
        {
            return driver.Title;
        }

        /// <summary>
        /// Closes the currently focused browser window.
        /// </summary>
        public void CloseCurrentWindow()
        {
            // Close the current window.
            driver.Close();

            // Update the list of window handles after closing the window.
            UpdateWindowHandles();
        }

        /// <summary>
        /// Helper method to refresh the list of browser window handles.
        /// </summary>
        private void UpdateWindowHandles()
        {
            // Retrieve all open window handles from the WebDriver.
            windowHandles = new List<string>(driver.WindowHandles);
        }
    }
}
