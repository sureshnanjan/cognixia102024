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
    /// Interface for handling operations related to multiple windows in the HerokuApp.
    /// Provides methods to navigate between windows, switch between them, and verify window statuses.
    /// </summary>
    public interface IMultipleWindows
    {
        /// <summary>
        /// Navigates to the "Multiple Windows" section on the website.
        /// </summary>
        void NavigateToMultipleWindowsPage();

        /// <summary>
        /// Clicks on the button or link that opens a new window.
        /// </summary>
        void OpenNewWindow();

        /// <summary>
        /// Switches to the newly opened window.
        /// </summary>
        void SwitchToNewWindow();

        /// <summary>
        /// Switches back to the main window.
        /// </summary>
        void SwitchToMainWindow();

        /// <summary>
        /// Retrieves the title of the current window.
        /// </summary>
        /// <returns>The title of the current window as a string.</returns>
        string GetWindowTitle();

        /// <summary>
        /// Verifies if a new window has been opened.
        /// </summary>
        /// <returns>True if a new window has opened; otherwise, false.</returns>
        bool IsNewWindowOpened();
    }
}
