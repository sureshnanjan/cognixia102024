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

using System;
using System.Collections.Generic;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents the Disappearing Elements page on the HerokuApp website.
    /// Provides functionality to interact with and verify the visibility of menu items.
    /// </summary>
    public class DisappearingElements : HerokuAppCommon, IDisappearingElements
    {
        // Locator for the menu items (links) on the page
        private readonly By menuLocator = By.XPath("//ul/li/a");

        /// <summary>
        /// Initializes a new instance of the <see cref="DisappearingElements"/> class.
        /// Navigates to the Disappearing Elements page.
        /// </summary>
        public DisappearingElements() : base()
        {
            // Navigate to the disappearing elements page
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/disappearing_elements");
        }

        /// <summary>
        /// Retrieves a list of all visible menu items on the page.
        /// </summary>
        /// <returns>A list of menu item names as strings.</returns>
        public List<string> GetMenuItems()
        {
            var menuItems = new List<string>();
            try
            {
                // Find all menu items (links) on the page
                var elements = driver.FindElements(menuLocator);
                foreach (var element in elements)
                {
                    // Add the text of each visible menu item to the list
                    menuItems.Add(element.Text);
                }
            }
            catch (NoSuchElementException)
            {
                // Handle the case where no menu items are found
                Console.WriteLine("No menu items found.");
            }
            return menuItems;
        }

        /// <summary>
        /// Clicks a menu item based on the specified text.
        /// </summary>
        /// <param name="menuItem">The text of the menu item to click.</param>
        public void ClickMenuItem(string menuItem)
        {
            try
            {
                // Find all menu items (links) on the page
                var elements = driver.FindElements(menuLocator);
                foreach (var element in elements)
                {
                    // Check if the current menu item's text matches the specified menu item
                    if (element.Text.Equals(menuItem, StringComparison.OrdinalIgnoreCase))
                    {
                        // Click the matching menu item and exit the method
                        element.Click();
                        return;
                    }
                }
                // Handle the case where the menu item is not found
                Console.WriteLine($"Menu item '{menuItem}' not found.");
            }
            catch (Exception e)
            {
                // Handle any error that occurs while trying to click the menu item
                Console.WriteLine($"Error clicking menu item: {e.Message}");
            }
        }

        /// <summary>
        /// Refreshes the page to reload the content.
        /// </summary>
        public void RefreshPage()
        {
            // Refresh the page
            driver.Navigate().Refresh();
        }

        /// <summary>
        /// Gets the title of the current page.
        /// </summary>
        /// <returns>The title of the page as a string.</returns>
        public string GetTitle()
        {
            return driver.Title;
        }

        public string GetpageTitle()
        {
            return driver.FindElement(By.TagName("h3")).Text; ;
        }
        public string GetDescription()
        {
            return driver.FindElement(By.TagName("p")).Text; // Assuming the description is in a <p> tag.
        }

        public void Quit()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
