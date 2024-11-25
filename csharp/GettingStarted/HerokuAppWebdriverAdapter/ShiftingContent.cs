
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
*/using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HerokuAppOperations
{
    /// <summary>
    /// This class contains methods to interact with the Shifting Content example page on the HerokuApp website.
    /// It implements the IShiftingContent interface to ensure consistency and modularity.
    /// </summary>
    public class ShiftingContentOperations : IShiftingContent
    {
        private readonly IWebDriver _driver;
        private readonly string _url = "https://the-internet.herokuapp.com/shifting_content/menu";

        /// <summary>
        /// Constructor to initialize the WebDriver.
        /// </summary>
        /// <param name="driver">The WebDriver instance to interact with the browser.</param>
        public ShiftingContentOperations(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Verifies that all expected menu items are present on the page.
        /// </summary>
        /// <exception cref="Exception">Thrown if the menu structure is not fully visible.</exception>
        public void VerifyMenuItems()
        {
            // Navigate to the Shifting Content page
            _driver.Navigate().GoToUrl(_url);

            // Locate menu items using CSS selector
            var menuItems = _driver.FindElements(By.CssSelector("ul li a"));
            Console.WriteLine("Menu Items Found:");

            foreach (var item in menuItems)
            {
                Console.WriteLine(item.Text); // Log menu item names
            }

            // Check if the expected number of menu items are present
            if (menuItems.Count < 5)
                throw new Exception("Not all menu items are visible. Possible shifting behavior.");
        }

        /// <summary>
        /// Navigates to a specific menu item based on its visible text.
        /// </summary>
        /// <param name="menuItemText">The visible text of the menu item to navigate to.</param>
        /// <exception cref="Exception">Thrown if the specified menu item is not found.</exception>
        public void NavigateToMenuItem(string menuItemText)
        {
            // Navigate to the Shifting Content page
            _driver.Navigate().GoToUrl(_url);

            // Find the menu item using its visible text
            var menuItem = _driver.FindElements(By.CssSelector("ul li a"))
                                  .FirstOrDefault(item => item.Text.Equals(menuItemText, StringComparison.OrdinalIgnoreCase));

            if (menuItem == null)
                throw new Exception($"Menu item with text '{menuItemText}' not found!");

            // Click on the menu item to navigate
            menuItem.Click();
            Console.WriteLine($"Navigated to menu item: {menuItemText}");
        }

        /// <summary>
        /// Detects whether any content on the page shifts unexpectedly by comparing element positions before and after a page refresh.
        /// </summary>
        /// <exception cref="Exception">Thrown if shifting behavior is detected in the menu items.</exception>
        public void CheckShiftingBehavior()
        {
            // Navigate to the Shifting Content page
            _driver.Navigate().GoToUrl(_url);

            // Capture the initial horizontal positions of menu items
            var menuItems = _driver.FindElements(By.CssSelector("ul li a"));
            var initialPositions = new List<int>();

            foreach (var item in menuItems)
            {
                initialPositions.Add(item.Location.X); // Store the X-coordinate
            }

            // Refresh the page to simulate potential shifting
            _driver.Navigate().Refresh();

            // Capture the refreshed horizontal positions
            var refreshedMenuItems = _driver.FindElements(By.CssSelector("ul li a"));
            var refreshedPositions = new List<int>();

            foreach (var item in refreshedMenuItems)
            {
                refreshedPositions.Add(item.Location.X); // Store the refreshed X-coordinate
            }

            // Compare the initial and refreshed positions
            if (!initialPositions.SequenceEqual(refreshedPositions))
                throw new Exception("Shifting behavior detected in the menu items!");
        }

        /// <summary>
        /// Gets the current URL of the browser.
        /// </summary>
        /// <returns>The current URL as a string.</returns>
        public string GetCurrentUrl()
        {
            // Use WebDriver's Url property to fetch the current URL
            return _driver.Url;
        }
    }
}
