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
using OpenQA.Selenium.Support.UI;
using System;

namespace HerokuAppOperations
{
    /// <summary>
    /// Implementation of the Floating Menu page interactions.
    /// Provides methods to verify visibility and functionality of the floating menu.
    /// </summary>
    public class FloatingMenu : IFloatingMenu
    {
        public readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatingMenu"/> class.
        /// Sets up WebDriver and WebDriverWait.
        /// </summary>
        public FloatingMenu()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// Navigates to the Floating Menu page.
        /// </summary>
        public void NavigateToFloatingMenuPage()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/floating_menu");
        }

        /// <summary>
        /// Checks if the floating menu is visible on the page.
        /// </summary>
        /// <returns>True if the floating menu is visible; otherwise, false.</returns>
        public bool IsFloatingMenuVisible()
        {
            try
            {
                IWebElement floatingMenu = driver.FindElement(By.Id("menu"));
                return floatingMenu.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        /// <summary>
        /// Simulates scrolling and verifies if the menu remains visible.
        /// </summary>
        /// <returns>True if the menu is still visible after scrolling; otherwise, false.</returns>
        public bool VerifyMenuVisibilityAfterScroll()
        {
            try
            {
                // Scroll down the page
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

                // Check menu visibility after scrolling
                IWebElement floatingMenu = driver.FindElement(By.Id("menu"));
                return floatingMenu.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public string GetPageTitle()
        {
            return driver.FindElement(By.TagName("h3")).Text;
        }

        

        /// <summary>
        /// Closes the browser and cleans up resources.
        /// </summary>
        public void Close()
        {
            driver.Quit();
        }
    }
}

