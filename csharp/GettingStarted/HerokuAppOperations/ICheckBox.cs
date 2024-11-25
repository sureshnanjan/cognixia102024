using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    // This interface defines the contract for checkbox operations.
    public interface ICheckBox
    {
        // Method to get the title of the checkbox section.
        public string getTitle();

        // Method to get the status of the first checkbox.
        public bool getCheckboxOneStatus();

        // Method to get the status of the second checkbox.
        public bool getCheckboxTwoStatus();
    }
}