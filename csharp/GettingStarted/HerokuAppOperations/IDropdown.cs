// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace HerokuAppOperations
{
    /// <summary>
    /// Defines operations for interacting with dropdown elements in the HerokuApp application.
    /// </summary>
    /// <remarks>
    /// This interface provides methods for retrieving the title of a dropdown, selecting an option, 
    /// and retrieving the currently selected option. It is intended for use in test automation scenarios.
    /// </remarks>
    public interface IDropdown
    {
        /// <summary>
        /// Retrieves the title of the dropdown element.
        /// </summary>
        /// <returns>A string representing the title of the dropdown.</returns>
        /// <remarks>
        /// This method ensures that the test script operates on the correct dropdown element by validating its title.
        /// </remarks>
        public string GetTitle();

        /// <summary>
        /// Selects an option in the dropdown by its visible name.
        /// </summary>
        /// <param name="option">The name of the option to select from the dropdown.</param>
        /// <remarks>
        /// This method simulates the user action of selecting an option in the dropdown menu.
        /// The option name must match one of the options visible in the dropdown.
        /// </remarks>
        public void SelectDropdownOption(string option);

        /// <summary>
        /// Retrieves the currently selected option in the dropdown.
        /// </summary>
        /// <returns>A string representing the currently selected option.</returns>
        /// <remarks>
        /// This method verifies the dropdown's state by returning the value of the currently selected option.
        /// It is useful for validation during automated tests.
        /// </remarks>
        public string GetSelectedOption();
    }
}
