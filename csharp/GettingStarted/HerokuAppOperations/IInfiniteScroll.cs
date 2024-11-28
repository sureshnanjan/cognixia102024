using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
