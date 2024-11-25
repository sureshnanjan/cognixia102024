using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    internal interface IDisappearingElements
    {
        /// <summary>
        /// Retrieves the list of all available menu items.
        /// </summary>
        /// <returns>A list of menu item names as strings.</returns>
        List<string> GetMenuItems();

        /// <summary>
        /// Clicks on a specified menu item by its name.
        /// </summary>
        /// <param name="menuItemName">The name of the menu item to click.</param>
        void ClickMenuItem(string menuItemName);

        /// <summary>
        /// Checks if the specified menu item is present on the page.
        /// </summary>
        /// <param name="menuItemName">The name of the menu item.</param>
        /// <returns>True if the menu item is present, otherwise false.</returns>
        bool IsMenuItemPresent(string menuItemName);

        /// <summary>
        /// Validates the navigation result after clicking a menu item.
        /// </summary>
        /// <returns>The title of the page or an error message.</returns>
        string GetNavigationResult();
    }
}
