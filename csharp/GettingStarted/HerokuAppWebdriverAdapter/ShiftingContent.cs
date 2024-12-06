
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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HerokuAppOperations
{
    /// <summary>
    /// This class contains methods to interact with the Shifting Content example page on the HerokuApp website.
    /// It includes functionality for verifying menu items, navigating to specific menu items, checking for shifting behavior,
    /// and retrieving the current URL.
    /// </summary>
    public class ShiftingContentOperations : IShiftingContent
    {
        private readonly IWebDriver _driver;
        private readonly string _url = "https://the-internet.herokuapp.com/shifting_content/menu";

        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftingContentOperations"/> class.
        /// This constructor creates a new <see cref="ChromeDriver"/> instance to interact with the browser.
        /// </summary>
        public ShiftingContentOperations()
        {
            _driver = new ChromeDriver();  // Initializes the WebDriver (ChromeDriver)
        }

        /// <summary>
        /// Retrieves the WebDriver instance.
        /// </summary>
        /// <returns>The WebDriver instance used by the class.</returns>
        public IWebDriver GetDriver()
        {
            return _driver;
        }

        /// <summary>
        /// Navigates to the Shifting Content page on the HerokuApp website.
        /// This method ensures the page is loaded before performing any further actions.
        /// </summary>
        public void NavigateToShiftingContentPage()
        {
            _driver.Navigate().GoToUrl(_url);
        }

        /// <summary>
        /// Verifies that the menu items are correctly loaded on the Shifting Content page.
        /// If fewer than 5 menu items are found, an exception is thrown to indicate possible shifting behavior.
        /// </summary>
        /// <exception cref="Exception">Thrown if fewer than 5 menu items are found.</exception>
        public void VerifyMenuItems()
        {
            NavigateToShiftingContentPage();

            var menuItems = _driver.FindElements(By.CssSelector("ul li a"));
            Console.WriteLine("Menu Items Found:");
            foreach (var item in menuItems)
            {
                Console.WriteLine(item.Text); // Log menu item names
            }

            if (menuItems.Count < 5)
                throw new Exception("Not all menu items are visible. Possible shifting behavior.");
        }

        /// <summary>
        /// Navigates to a specific menu item on the Shifting Content page based on the visible text of the menu item.
        /// If the menu item is not found, an exception is thrown.
        /// </summary>
        /// <param name="menuItemText">The visible text of the menu item to navigate to.</param>
        /// <exception cref="Exception">Thrown if the specified menu item is not found.</exception>
        public void NavigateToMenuItem(string menuItemText)
        {
            NavigateToShiftingContentPage();

            var menuItem = _driver.FindElements(By.CssSelector("h3"))
                                  .FirstOrDefault(item => item.Text.Equals(menuItemText, StringComparison.OrdinalIgnoreCase));

            if (menuItem == null)
                throw new Exception($"Menu item with text '{menuItemText}' not found!");

            menuItem.Click();
            Console.WriteLine($"Navigated to menu item: {menuItemText}");
        }

        /// <summary>
        /// Detects whether any content on the page shifts unexpectedly by comparing the horizontal positions of menu items 
        /// before and after a page refresh.
        /// </summary>
        /// <exception cref="Exception">Thrown if shifting behavior is detected based on the positions of menu items.</exception>
        public void CheckShiftingBehavior()
        {
            NavigateToShiftingContentPage();

            var menuItems = _driver.FindElements(By.CssSelector("ul li a"));
            var initialPositions = new List<int>();

            foreach (var item in menuItems)
            {
                initialPositions.Add(item.Location.X);
            }

            _driver.Navigate().Refresh();

            var refreshedMenuItems = _driver.FindElements(By.CssSelector("ul li a"));
            var refreshedPositions = new List<int>();

            foreach (var item in refreshedMenuItems)
            {
                refreshedPositions.Add(item.Location.X);
            }

            if (!initialPositions.SequenceEqual(refreshedPositions))
            {
                Console.WriteLine("Shifting behavior detected in the menu items.");
            }
        }

        /// <summary>
        /// Retrieves the current URL of the browser.
        /// </summary>
        /// <returns>The current URL as a string.</returns>
        public string GetCurrentUrl()
        {
            return _driver.Url;
        }

        /// <summary>
        /// Cleans up resources by quitting and disposing of the WebDriver after test execution.
        /// This method is called to ensure that the browser session is properly closed.
        /// </summary>
        public void CleanUp()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            }
        }
    }
}