// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for operations related to interacting with a large and deep DOM structure in the HerokuApp.
    /// Provides methods to open the page, locate elements, interact with items, scroll through the DOM, and verify page load.
    /// </summary>
    public interface ILargeDeepDOM
    {
        /// <summary>
        /// Opens the Large Deep DOM page.
        /// </summary>
        void OpenLargeDeepDOMPage();

        /// <summary>
        /// Checks if a specific element is present in the DOM based on the given selector.
        /// </summary>
        /// <param name="elementSelector">The CSS selector of the element to find.</param>
        /// <returns>True if the element is present; otherwise, false.</returns>
        bool IsElementPresent(string elementSelector);

        /// <summary>
        /// Retrieves a list of all items within the deep DOM structure.
        /// </summary>
        /// <returns>A list of strings, each representing an item in the deep DOM structure.</returns>
        List<string> GetAllItemsInDeepDOM();

        /// <summary>
        /// Interacts with a specific item in the large DOM by clicking it.
        /// </summary>
        /// <param name="itemSelector">The CSS selector of the item to click.</param>
        void ClickItemInDOM(string itemSelector);

        /// <summary>
        /// Retrieves the title of the Large Deep DOM page.
        /// </summary>
        /// <returns>The page title as a string.</returns>
        string GetPageTitle();

        /// <summary>
        /// Scrolls through the DOM by a specified amount.
        /// </summary>
        /// <param name="scrollAmount">The amount to scroll, typically in pixels.</param>
        void ScrollThroughDOM(int scrollAmount);

        /// <summary>
        /// Waits until the DOM is fully loaded and ready for interaction.
        /// </summary>
        void WaitForDOMToLoad();
    }
}
