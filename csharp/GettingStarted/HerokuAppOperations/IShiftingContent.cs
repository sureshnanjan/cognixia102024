﻿namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for interacting with the Shifting Content example page on the HerokuApp website.
    /// Defines methods for validating menu items, detecting shifting behavior, and navigation.
    /// </summary>
    public interface IShiftingContent
    {
        /// <summary>
        /// Verifies the menu items on the page to ensure they are loaded correctly.
        /// </summary>
        void VerifyMenuItems();

        /// <summary>
        /// Navigates to a specific menu item based on its text.
        /// </summary>
        /// <param name="menuItemText">The visible text of the menu item to navigate to.</param>
        void NavigateToMenuItem(string menuItemText);

        /// <summary>
        /// Detects if any content on the page shifts unexpectedly by comparing element positions before and after a refresh.
        /// </summary>
        void CheckShiftingBehavior();

        /// <summary>
        /// Gets the current URL of the page.
        /// </summary>
        /// <returns>The current URL as a string.</returns>
        string GetCurrentUrl();
    }
}
