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
using System.Linq;

namespace HerokuAppOperations
{
    /// <summary>
    /// This class contains methods to interact with the JQuery UI Menus example page on the HerokuApp website.
    /// Implements the IJQueryUIMenus interface to ensure modular and testable functionality.
    /// </summary>
    public class JQueryUIMenusOperations : IJQueryUIMenus
    {
        private readonly IWebDriver _driver;
        private readonly string _url = "https://the-internet.herokuapp.com/jqueryui/menu";

        /// <summary>
        /// Constructor to initialize the WebDriver.
        /// </summary>
        /// <param name="driver">The WebDriver instance to interact with the browser.</param>
        public JQueryUIMenusOperations(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Navigates to a specific menu item and optionally selects a submenu item.
        /// </summary>
        /// <param name="menuText">The visible text of the main menu item to interact with.</param>
        /// <param name="submenuText">The visible text of the submenu item to select (optional).</param>
        public void SelectMenuItem(string menuText, string submenuText = null)
        {
            // Navigate to the JQuery UI Menus page
            _driver.Navigate().GoToUrl(_url);

            // Find the main menu item by its text
            var menuItem = _driver.FindElements(By.CssSelector(".ui-menu li a"))
                                  .FirstOrDefault(item => item.Text.Equals(menuText, StringComparison.OrdinalIgnoreCase));

            if (menuItem == null)
                throw new Exception($"Menu item with text '{menuText}' not found!");

            // Hover over the main menu item
            var actions = new OpenQA.Selenium.Interactions.Actions(_driver);
            actions.MoveToElement(menuItem).Perform();

            if (!string.IsNullOrEmpty(submenuText))
            {
                // Find the submenu item by its text
                var submenuItem = _driver.FindElements(By.CssSelector(".ui-menu li ul li a"))
                                         .FirstOrDefault(item => item.Text.Equals(submenuText, StringComparison.OrdinalIgnoreCase));

                if (submenuItem == null)
                    throw new Exception($"Submenu item with text '{submenuText}' not found!");

                submenuItem.Click();
                Console.WriteLine($"Clicked submenu item: {submenuText}");
            }
            else
            {
                // If no submenu specified, click the main menu item
                menuItem.Click();
                Console.WriteLine($"Clicked main menu item: {menuText}");
            }
        }

        /// <summary>
        /// Verifies that the menu structure is fully visible and accessible.
        /// </summary>
        public void VerifyMenuAccessibility()
        {
            _driver.Navigate().GoToUrl(_url);

            // Check for the presence of menu items
            var menuItems = _driver.FindElements(By.CssSelector(".ui-menu li a"));

            if (menuItems.Count == 0)
                throw new Exception("No menu items found. The menu structure may not be accessible.");

            Console.WriteLine($"Menu is accessible with {menuItems.Count} items found.");
        }

        /// <summary>
        /// Gets the current URL of the browser.
        /// </summary>
        /// <returns>The current URL as a string.</returns>
        public string GetCurrentUrl()
        {
            return _driver.Url; // Returns the current URL of the browser
        }
    }
}
