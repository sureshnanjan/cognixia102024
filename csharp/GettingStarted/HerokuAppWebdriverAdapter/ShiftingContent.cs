
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
    public class ShiftingContentOperations : IShiftingContent
    {
        private readonly IWebDriver _driver;
        private readonly string _url = "https://the-internet.herokuapp.com/shifting_content/menu";

        // Constructor to initialize WebDriver and navigate to the page
        public ShiftingContentOperations(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver), "WebDriver cannot be null");
        }

        // Navigates to the Shifting Content page
        public void NavigateToShiftingContentPage()
        {
            _driver.Navigate().GoToUrl(_url);
        }

        // Verifies that all expected menu items are present on the page
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

        // Navigates to a specific menu item based on its visible text
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

        // Detects whether any content on the page shifts unexpectedly by comparing element positions
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

        // Gets the current URL of the browser
        public string GetCurrentUrl()
        {
            return _driver.Url;
        }

        // Cleanup method to close WebDriver after test execution
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
