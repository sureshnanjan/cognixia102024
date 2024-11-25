using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace HerokuAppWebdriverAdapter
{

    public class CheckBox : ICheckBox
    {
        public string Title { get; set; }          // Title of the checkbox
        public bool IsChecked { get; set; }        // Status of the checkbox (checked or unchecked)

        // Constructor to initialize the checkbox title and status
        public CheckBox(string title, bool isChecked = false)
        {
            Title = title;
            IsChecked = isChecked;
        }

        // Implementing GetTitle() method
        public string GetTitle()
        {
            return Title;
        }

        // Implementing GetCheckboxStatus() method
        public bool GetCheckboxStatus()
        {
            return IsChecked;
        }

        // Implementing ToggleCheckboxStatus() method
        public void ToggleCheckboxStatus()
        {
            IsChecked = !IsChecked;  // Toggle between true and false
        }
    }
}

