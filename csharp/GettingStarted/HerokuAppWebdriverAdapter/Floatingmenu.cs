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
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Handles operations related to the floating menu on the Heroku app, such as visibility checks, scrolling, and browser closure.
    /// </summary>
    public class floatingmenu : HerokuAppCommon, Ifloatingmenu
    {
        /// <summary>
        /// Closes the browser session after operations are complete.
        /// </summary>
        public void CloseBrowser()
        {
            // Method implementation for closing the browser (to be added if needed).
        }

        /// <summary>
        /// Checks if the floating menu is visible on the page.
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> if the floating menu is visible; otherwise, <c>false</c>.
        /// </returns>
        public bool IsFloatingMenuVisible()
        {
            try
            {
                // Locate the floating menu by its ID
                IWebElement floatingMenu = driver.FindElement(By.Id("menu"));

                // Check if the menu is displayed and return the result
                return floatingMenu.Displayed;
            }
            catch (NoSuchElementException)
            {
                // Return false if the floating menu is not found
                return false;
            }
        }

        /// <summary>
        /// Scrolls the page to a specific vertical position.
        /// </summary>
        /// <param name="position">The vertical position (in pixels) to scroll to.</param>
        public void ScrollTo(int position)
        {
            // Use JavaScript to scroll the window to the specified position
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript($"window.scrollTo(0, {position});");
        }
    }
}
