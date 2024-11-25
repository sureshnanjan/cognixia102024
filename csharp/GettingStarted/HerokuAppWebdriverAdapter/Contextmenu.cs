using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace HerokuAppWebdriverAdapter
{
    public class ContextMenu : IContextMenu
    {
        private string[] menuOptions = { "Option 1", "Option 2", "Option 3" };

        public void RightClickOnElement()
        {
            // Simulate right-click action (this could be more complex with actual UI testing, e.g., using Selenium)
            Console.WriteLine("Right-click action performed.");
        }

        public string[] GetMenuOptions()
        {
            // Return available menu options after right-click
            return menuOptions;
        }

        public void SelectMenuOption(string option)
        {
            // Simulate selecting a menu option
            Console.WriteLine($"{option} selected.");
        }
    }
}
