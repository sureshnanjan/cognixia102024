using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    // Interface definition for handling context menu operations
    public interface IContextMenu
    {
        // Method to handle the action of right-clicking on an element
        void RightClickOnElement();

        // Method to retrieve the available context menu options
        // Returns an array of strings representing menu options
        string[] GetMenuOptions();

        // Method to select a specific menu option
        // Takes a string 'option' as the parameter, which is the menu option to select
        void SelectMenuOption(string option);
    }
}
