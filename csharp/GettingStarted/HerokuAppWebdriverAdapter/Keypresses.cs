// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------
using HerokuAppOperations;
using OpenQA.Selenium;
using System;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents the Key Presses page object model for HerokuApp.
    /// Provides methods to interact with and retrieve information from the Key Presses page.
    /// </summary>
    public class KeyPresses : HerokuAppCommon, IKeyPresses
    {
        // Locator for the input field where keys can be pressed
        private By inputField;

        // Locator for the field that displays the result of the key press
        private By resultField;

        /// <summary>
        /// Constructor to initialize the KeyPresses class with the WebDriver instance.
        /// Inherits from the base class HerokuAppCommon for shared functionality.
        /// </summary>
        /// <param name="arg">The WebDriver instance used to interact with the page.</param>
        public KeyPresses(IWebDriver arg) : base(arg)
        {
            // Initialize the locators for input and result fields
            this.inputField = By.Id("target");
            this.resultField = By.Id("result");
        }

        /// <summary>
        /// Retrieves the title of the current web page using the WebDriver's Title property.
        /// </summary>
        /// <returns>A string containing the page title.</returns>
        public string GetTitle()
        {
            return this.driver.Title; // Fetches the page title directly from the browser
        }

        /// <summary>
        /// Simulates pressing a key in the input field.
        /// </summary>
        /// <param name="key">The key to be pressed, passed as a string.</param>
        public void PressKey(string key)
        {
            // Sends the specified key to the input field
            this.driver.FindElement(inputField).SendKeys(key);
        }

        /// <summary>
        /// Retrieves the text displayed in the result field, indicating the key pressed.
        /// </summary>
        /// <returns>A string containing the result of the key press.</returns>
        public string GetKeyPressed()
        {
            // Fetches the text displayed in the result field
            return this.driver.FindElement(resultField).Text;
        }
    }
}
