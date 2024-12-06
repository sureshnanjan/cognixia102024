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
using OpenQA.Selenium;
using HerokuAppOperations;
using OpenQA.Selenium.Support.UI;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents a page object model for interacting with the Infinite Scroll page
    /// on the HerokuApp website. Implements the IInfiniteScroll interface to provide
    /// methods for handling infinite scrolling actions.
    /// </summary>
    public class InfiniteScroll : HerokuAppCommon, IInfiniteScroll
    {
        // Locator for the container holding scrollable items
        private readonly By itemContainer = By.CssSelector("#content .jscroll-inner > div");
        private readonly By loader = By.CssSelector(".loading-indicator");

        /// <summary>
        /// Initializes a new instance of the <see cref="InfiniteScroll"/> class.
        /// </summary>
        /// <param name="driver">The WebDriver instance used to interact with the page.</param>
        public InfiniteScroll(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Navigates to the Infinite Scroll page on HerokuApp.
        /// </summary>
        public void NavigateToInfiniteScrollPage()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/infinite_scroll");
        }

        /// <summary>
        /// Checks if the Infinite Scroll page is fully loaded.
        /// </summary>
        /// <returns>True if the page is loaded; otherwise, false.</returns>
        public bool IsPageLoaded()
        {
            return driver.FindElements(itemContainer).Count > 0;
        }

        /// <summary>
        /// Scrolls down the page to trigger loading more items.
        /// </summary>
        public void ScrollDownToLoadMore()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("window.scrollBy(0, document.body.scrollHeight);");
        }

        /// <summary>
        /// Checks if new content is loaded after scrolling.
        /// </summary>
        /// <param name="itemSelector">The selector for the scrollable items.</param>
        /// <returns>True if new content is loaded; otherwise, false.</returns>
        public bool IsNewContentLoaded(string itemSelector)
        {
            var items = driver.FindElements(By.CssSelector(itemSelector));
            return items.Count > 0;
        }

        /// <summary>
        /// Gets the total number of items currently loaded on the page.
        /// </summary>
        /// <param name="itemSelector">The selector for the scrollable items.</param>
        /// <returns>The total number of loaded items.</returns>
        public int GetNumberOfItems(string itemSelector)
        {
            return driver.FindElements(By.CssSelector(itemSelector)).Count;
        }

        /// <summary>
        /// Scrolls down repeatedly until the end of the content or the maximum scrolls are reached.
        /// </summary>
        /// <param name="itemSelector">The selector for the scrollable items.</param>
        /// <param name="maxScrolls">The maximum number of scroll attempts.</param>
        public void ScrollUntilEnd(string itemSelector, int maxScrolls = 10)
        {
            int scrollCount = 0;
            while (scrollCount < maxScrolls)
            {
                int itemsBeforeScroll = GetNumberOfItems(itemSelector);
                ScrollDownToLoadMore();
                int itemsAfterScroll = GetNumberOfItems(itemSelector);

                if (itemsAfterScroll <= itemsBeforeScroll)
                {
                    break; // No more items loaded; end scrolling.
                }
                scrollCount++;
            }
        }
    }
}
   