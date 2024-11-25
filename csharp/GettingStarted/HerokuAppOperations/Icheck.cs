using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface ICheck
    {
        string GetTitle();                      // Method to get the title of the checkbox
        bool GetCheckboxStatus();               // Method to get the checkbox status (checked or unchecked)
        void ToggleCheckboxStatus();            // Method to toggle checkbox status (check/uncheck)
    }
}