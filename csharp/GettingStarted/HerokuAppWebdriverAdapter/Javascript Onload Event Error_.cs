// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents the JavaScript Error page object model for HerokuApp.
    /// Provides methods to interact with and retrieve information from the page.
    /// </summary>
    public class JsError : HerokuAppCommon, IJsError
    {
        // Locator for the error message element on the page
        private By errorMessage;

        /// <summary>
        /// Constructor to initialize the JsError class with the WebDriver instance.
        /// Inherits from the base class HerokuAppCommon for shared functionality.
        /// </summary>
        /// <param name="arg">The WebDriver instance used to interact with the page.</param>
        public JsError(IWebDriver arg) : base(arg)
        {
            // Initialize the locator for the error message
            this.errorMessage = By.Id("error-message");
        }

        /// <summary>
        /// Retrieves the title of the current web page using the WebDriver's Title property.
        /// </summary>
        /// <returns>A string containing the page title.</returns>
        public string GetTitle()
        {
            return driver.Title; // Fetches the page title directly from the browser
        }

        /// <summary>
        /// Checks if the JavaScript error message is displayed on the page.
        /// </summary>
        /// <returns>A boolean indicating whether the error message is visible or not.</returns>
        public bool IsErrorMessageDisplayed()
        {
            // Find the error message element and return its visibility status
            return this.driver.FindElement(errorMessage).Displayed;
        }
    }
}
