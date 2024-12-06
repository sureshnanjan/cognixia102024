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
using OpenQA.Selenium.Support.UI;

namespace HerokuAppOperations
{
    public class JQueryUIMenusOperations : IJQueryUIMenus
    {
        public readonly IWebDriver _driver;
        private readonly string _url = "https://the-internet.herokuapp.com/jqueryui/menu";

        public JQueryUIMenusOperations(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver), "WebDriver cannot be null");
        }

        public JQueryUIMenusOperations()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver(); // Example of default WebDriver setup.
        }

        public void SelectMenuItem(string menuText, string submenuText = null, string submenuItemText = null)
        {
            _driver.Navigate().GoToUrl(_url);

            // Wait for the page to load and the menu to become visible
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            // Find the main menu item by its text
            var menuItem = _driver.FindElements(By.CssSelector(".ui-menu li a"))
                                  .FirstOrDefault(item => item.Text.Equals(menuText, StringComparison.OrdinalIgnoreCase));

            if (menuItem == null)
            {
                throw new Exception($"Menu item with text '{menuText}' not found!");
            }

            // Hover over the main menu item
            var actions = new OpenQA.Selenium.Interactions.Actions(_driver);
            actions.MoveToElement(menuItem).Perform();

            // If submenuText is provided, locate the submenu item
            if (!string.IsNullOrEmpty(submenuText))
            {
                // Find the submenu item by its text
                var submenuItem = _driver.FindElements(By.CssSelector(".ui-menu li ul li a"))
                                         .FirstOrDefault(item => item.Text.Equals(submenuText, StringComparison.OrdinalIgnoreCase));

                if (submenuItem == null)
                {
                    throw new Exception($"Submenu item with text '{submenuText}' not found!");
                }

                // Hover over the submenu item to reveal further submenu items
                actions.MoveToElement(submenuItem).Perform();

                // If a specific submenuItemText is provided, select that item
                if (!string.IsNullOrEmpty(submenuItemText))
                {
                    var finalSubmenuItem = _driver.FindElements(By.CssSelector(".ui-menu li ul li a"))
                                                  .FirstOrDefault(item => item.Text.Equals(submenuItemText, StringComparison.OrdinalIgnoreCase));

                    if (finalSubmenuItem == null)
                    {
                        throw new Exception($"Final submenu item with text '{submenuItemText}' not found!");
                    }

                    finalSubmenuItem.Click();
                    Console.WriteLine($"Clicked final submenu item: {submenuItemText}");
                }
                else
                {
                    submenuItem.Click();
                    Console.WriteLine($"Clicked submenu item: {submenuText}");
                }
            }
            else
            {
                menuItem.Click();
                Console.WriteLine($"Clicked main menu item: {menuText}");
            }
        }

        public void VerifyMenuAccessibility()
        {
            _driver.Navigate().GoToUrl(_url);

            var menuItems = _driver.FindElements(By.CssSelector(".ui-menu li a"));

            if (menuItems.Count == 0)
                throw new Exception("No menu items found. The menu structure may not be accessible.");

            Console.WriteLine($"Menu is accessible with {menuItems.Count} items found.");
        }

        public string GetCurrentUrl()
        {
            return _driver.Url;
        }

        // Clean up WebDriver
        public void CleanUp()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            }
        }

        public void SelectMenuItem(string menuText, string submenuText = null)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}