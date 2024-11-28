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
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1;

namespace HerokuAppOperations
{
    /// <summary>
    /// Test suite for verifying window operations such as opening a new window, switching between windows, 
    /// and closing windows using Selenium WebDriver.
    /// </summary>
    [TestFixture]
    public class WindowOperationsTests
    {
        private ChromeDriver driver; // WebDriver instance for browser automation.
        private WindowOperations windowOperations; // Instance of the WindowOperations class to handle window interactions.

        /// <summary>
        /// Initializes the WebDriver and sets up the WindowOperations instance before each test.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(); // Initialize the Chrome WebDriver.
            windowOperations = new WindowOperations(driver); // Create an instance of the WindowOperations class.
        }

        /// <summary>
        /// Validates the behavior of opening, switching, and closing a new window.
        /// </summary>
        [Test]
        public void ValidateOpeningNewWindow()
        {
            // Step 1: Get the original window's title.
            string originalTitle = windowOperations.GetCurrentWindowTitle();

            // Assert that the original window's title is as expected.
            Assert.AreEqual("The Internet", originalTitle, "Original window title is incorrect.");

            // Step 2: Open a new window using the window operations class.
            windowOperations.OpenNewWindow();

            // Switch to the newly opened window.
            windowOperations.SwitchToNewWindow();

            // Step 3: Validate the title of the new window.
            string newWindowTitle = windowOperations.GetCurrentWindowTitle();
            Assert.AreEqual("New Window", newWindowTitle, "New window title is incorrect.");

            // Step 4: Close the new window.
            windowOperations.CloseCurrentWindow();

            // Switch back to the original window.
            windowOperations.SwitchToOriginalWindow();

            // Step 5: Validate that the window title is now back to the original.
            string titleAfterSwitch = windowOperations.GetCurrentWindowTitle();
            Assert.AreEqual("The Internet", titleAfterSwitch, "Failed to switch back to the original window.");
        }

        /// <summary>
        /// Cleans up and closes the browser after each test.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Quit the WebDriver and close the browser.
            driver.Quit();
            driver.Dispose();
        }
    }
}
