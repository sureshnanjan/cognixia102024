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
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    internal class DisappearingElements: HerokuAppCommon
    {
        private By menuItemsLocator = By.CssSelector("ul li a"); // Adjust locator as needed

        public DisappearingElements(IWebDriver driver) : base(driver) { }

        public List<string> GetMenuItems()
        {
            var elements = this.driver.FindElements(menuItemsLocator);
            return elements.Select(element => element.Text).ToList();
        }

        public void ClickMenuItem(string menuItemName)
        {
            var menuItems = this.driver.FindElements(menuItemsLocator);
            var menuItem = menuItems.FirstOrDefault(item => item.Text.Equals(menuItemName, StringComparison.OrdinalIgnoreCase));
            if (menuItem != null)
            {
                menuItem.Click();
            }
            else
            {
                throw new NoSuchElementException($"Menu item '{menuItemName}' not found on the page.");
            }
        }

        public bool IsMenuItemPresent(string menuItemName)
        {
            var menuItems = this.driver.FindElements(menuItemsLocator);
            return menuItems.Any(item => item.Text.Equals(menuItemName, StringComparison.OrdinalIgnoreCase));
        }

        public string GetNavigationResult()
        {
            try
            {
                return this.driver.Title; // Returns the page title after navigation
            }
            catch (WebDriverException)
            {
                return "Navigation failed or page not found.";
            }
        }
    }
}
