using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface Ifloatingmenu
    {
        /// <summary>
        /// Opens the target URL for testing the floating menu.
        /// </summary>
        /// <param name="url">The URL of the floating menu page.</param>

       public void ScrollTo(int position);

        /// <summary>
        /// Checks if the floating menu is visible on the screen.
        /// </summary>
        /// <returns>A boolean indicating whether the floating menu is visible.</returns>
       public bool IsFloatingMenuVisible();

        /// <summary>
        /// Closes the browser.
        /// </summary>
       public void CloseBrowser();
    }
}
