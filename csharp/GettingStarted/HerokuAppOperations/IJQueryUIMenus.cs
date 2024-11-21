namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for interacting with the JQuery UI Menus example page on the HerokuApp website.
    /// Defines methods for menu interactions such as navigation and submenu selection.
    /// </summary>
    public interface IJQueryUIMenus
    {
        /// <summary>
        /// Navigates to a specific menu item and optionally selects a submenu item.
        /// </summary>
        /// <param name="menuText">The visible text of the main menu item to interact with.</param>
        /// <param name="submenuText">The visible text of the submenu item to select (optional).</param>
        void SelectMenuItem(string menuText, string submenuText = null);

        /// <summary>
        /// Checks if the menu structure is fully visible and accessible.
        /// </summary>
        void VerifyMenuAccessibility();

        /// <summary>
        /// Gets the current URL after interacting with a menu item.
        /// </summary>
        /// <returns>The current URL as a string.</returns>
        string GetCurrentUrl();
    }
}
