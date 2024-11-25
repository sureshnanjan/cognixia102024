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
    /// Interface for Dropdown operations in the HerokuApp.
    /// Provides methods to get the dropdown title, select an option, and retrieve the selected option.
    /// </summary>
    public interface IDropdown
    {
        /// <summary>
        /// Retrieves the title of the dropdown.
        /// </summary>
        /// <returns>The title of the dropdown as a string.</returns>
        public string GetTitle();

        /// <summary>
        /// Selects an option in the dropdown based on the given option name.
        /// </summary>
        /// <param name="option">The option to be selected in the dropdown.</param>
        public void SelectDropdownOption(string option);

        /// <summary>
        /// Retrieves the currently selected option in the dropdown.
        /// </summary>
        /// <returns>The currently selected option as a string.</returns>
        public string GetSelectedOption();
    }
}
