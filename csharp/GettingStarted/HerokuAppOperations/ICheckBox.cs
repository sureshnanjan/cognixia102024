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
    /// Defines the interface for interacting with checkboxes in the HerokuApp application.
    /// </summary>
    /// <remarks>
    /// This interface provides methods for retrieving the page title and the status of checkboxes. 
    /// It is designed to simulate user interaction and validation in test automation scenarios.
    /// </remarks>
    public interface ICheckBox
    {
        /// <summary>
        /// Retrieves the title of the current page.
        /// </summary>
        /// <returns>A string representing the page title.</returns>
        /// <remarks>
        /// Useful for debugging and ensuring the test is being executed on the correct page within the application.
        /// </remarks>
        public string GetTitle();

        /// <summary>
        /// Retrieves the current status of the first checkbox on the page.
        /// </summary>
        /// <returns>A boolean value indicating whether the first checkbox is checked (true) or unchecked (false).</returns>
        /// <remarks>
        /// This method is primarily used to validate the state of the first checkbox during testing scenarios.
        /// </remarks>
        public bool GetCheckboxOneStatus();

        /// <summary>
        /// Retrieves the current status of the second checkbox on the page.
        /// </summary>
        /// <returns>A boolean value indicating whether the second checkbox is checked (true) or unchecked (false).</returns>
        /// <remarks>
        /// This method is primarily used to validate the state of the second checkbox during testing scenarios.
        /// </remarks>
        public bool GetCheckboxTwoStatus();
    }
}
