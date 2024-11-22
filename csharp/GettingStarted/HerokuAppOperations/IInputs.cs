namespace HerokuAppOperations
{
    public interface IInputs
    {
        /// <summary>
        /// Validates if the page is loaded correctly.
        /// </summary>
        /// <returns>Returns true if the input field is present and the page is loaded correctly.</returns>
        public bool IsPageLoaded();

        /// <summary>
        /// Gets the title of the Inputs page.
        /// </summary>
        /// <returns>Returns the title of the page as a string.</returns>
        public string GetPageTitle();

        /// <summary>
        /// Enters a value into the input field.
        /// </summary>
        /// <param name="value">The value to be entered into the input field.</param>
        public void EnterValue(string value);

        /// <summary>
        /// Clears the input field.
        /// </summary>
        public void ClearInputField();

        /// <summary>
        /// Gets the current value from the input field.
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
