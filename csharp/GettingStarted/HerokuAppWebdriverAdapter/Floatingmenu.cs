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
using OpenQA.Selenium;
using HerokuAppOperations;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents the Floating Menu page on the HerokuApp website.
    /// Provides functionality to interact with and verify the behavior of the floating menu.
    /// </summary>
    public class FloatingMenu : HerokuAppCommon, IFloatingmenu
    {
        // Locator for the floating menu element
        private readonly By floatingMenuLocator = By.Id("menu");  // Assuming the floating menu has an ID of 'menu'
        private readonly By titleLocator = By.TagName("h1");  // Assuming the title is within an <h1> tag
        private readonly By floatingMenuItemsLocator = By.CssSelector(".floating-menu-item");  // Example class for menu items

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatingMenu"/> class.
        /// Navigates to the Floating Menu page.
        /// </summary>
        public FloatingMenu() : base()
        {
            // Navigate to the floating menu page
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/floating_menu");
        }

        /// <summary>
        /// Opens the target URL for checking the title.
        /// </summary>
        public void GetTittle()
        {
            try
            {
                // Output the title of the page
                string pageTitle = driver.FindElement(titleLocator).Text;
                Console.WriteLine($"Page title: {pageTitle}");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Title not found on the page.");
            }
        }

        /// <summary>
        /// Scrolls to the specified position on the page.
        /// </summary>
        /// <param name="position">The position to scroll to.</param>
        public void ScrollTo(int position)
        {
            try
            {
                // Use JavaScript to scroll to the specified position
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript($"window.scrollTo(0, {position});");
                Console.WriteLine($"Scrolled to position: {position}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error scrolling to position {position}: {e.Message}");
            }
        }

        /// <summary>
        /// Checks if the floating menu is visible on the screen.
        /// </summary>
        /// <returns>True if the floating menu is visible, false otherwise.</returns>
        public bool IsFloatingMenuVisible()
        {
            try
            {
                // Check if the floating menu is visible
                IWebElement floatingMenu = driver.FindElement(floatingMenuLocator);
                return floatingMenu.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        /// <summary>
        /// Closes the browser.
        /// </summary>
        public void CloseBrowser()
        {
            try
            {
                driver.Quit();
                driver = null;
                Console.WriteLine("Browser closed.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error closing the browser: {e.Message}");
            }
        }
    }
}
