// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for handling input field operations on the Inputs page.
    /// Provides methods to interact with the input fields, validate values, and perform actions like clearing, entering, and modifying input values.
    /// </summary>
    public interface IInputs
    {
        /// <summary>
        /// Validates if the page is loaded correctly by checking the presence of the input field.
        /// </summary>
        /// <returns>Returns true if the input field is present and the page is loaded correctly.</returns>
        public bool IsPageLoaded();

        /// <summary>
        /// Gets the title of the Inputs page.
        /// </summary>
        /// <returns>Returns the title of the page as a string.</returns>
        public string GetPageTitle();

        /// <summary>
        /// Enters a specified value into the input field.
        /// </summary>
        /// <param name="value">The value to be entered into the input field.</param>
        public void EnterValue(string value);

        /// <summary>
        /// Clears the current value from the input field.
        /// </summary>
        public void ClearInputField();

        /// <summary>
        /// Retrieves the current value from the input field.
        /// </summary>
        /// <returns>Returns the current value in the input field as a string.</returns>
        public string GetInputValue();

        /// <summary>
        /// Validates whether the entered value is numeric.
        /// </summary>
        /// <param name="input">The value to test.</param>
        /// <returns>Returns true if the value is numeric, otherwise false.</returns>
        public bool ValidateNumericInput(string input);

        /// <summary>
        /// Simulates incrementing the input field value (if possible).
        /// </summary>
        /// <returns>The incremented value as a string.</returns>
        public string IncrementValue();

        /// <summary>
        /// Simulates decrementing the input field value (if possible).
        /// </summary>
        /// <returns>The decremented value as a string.</returns>
        public string DecrementValue();
    }
}
