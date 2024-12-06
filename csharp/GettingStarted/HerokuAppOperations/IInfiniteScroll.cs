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

namespace HerokuAppOperations
{
    // Interface for operations related to Infinite Scroll functionality on a page.
    public interface IInfiniteScroll
    {
        /// <summary>
        /// Navigate to the page with infinite scroll.
        /// </summary>
        void NavigateToInfiniteScrollPage();

        /// <summary>
        /// Verify if the page with infinite scroll has loaded successfully.
        /// </summary>
        /// <returns>True if the page is loaded, otherwise false.</returns>
        bool IsPageLoaded();

        /// <summary>
        /// Scroll down the page to trigger the loading of more items.
        /// </summary>
        void ScrollDownToLoadMore();

        /// <summary>
        /// Verify if new content has been loaded after scrolling.
        /// </summary>
        /// <param name="itemSelector">CSS selector for the dynamically loaded items.</param>
        /// <returns>True if new content is loaded, otherwise false.</returns>
        bool IsNewContentLoaded(string itemSelector);

        /// <summary>
        /// Get the current number of items on the page.
        /// </summary>
        /// <param name="itemSelector">CSS selector for the items on the page.</param>
        /// <returns>The number of items currently visible on the page.</returns>
        int GetNumberOfItems(string itemSelector);

        /// <summary>
        /// Scroll continuously until the end of the content or a maximum number of scroll attempts is reached.
        /// </summary>
        /// <param name="itemSelector">CSS selector for the items on the page.</param>
        /// <param name="maxScrolls">Maximum number of scrolls before stopping (to avoid infinite loops).</param>
        void ScrollUntilEnd(string itemSelector, int maxScrolls = 10);
    }
}
