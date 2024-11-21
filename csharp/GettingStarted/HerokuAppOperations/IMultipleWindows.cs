using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IMultipleWindows
    {
        // Navigate to the "Multiple Windows" section on the website
        void NavigateToMultipleWindowsPage();

        // Click on the button/link that opens a new window
        void OpenNewWindow();

        // Switch to the new window (handle switching between windows)
        void SwitchToNewWindow();

        // Switch back to the main window
        void SwitchToMainWindow();

        // Get the title of the current window
        string GetWindowTitle();

        // Verify that a new window has opened
        bool IsNewWindowOpened();
    }
}
