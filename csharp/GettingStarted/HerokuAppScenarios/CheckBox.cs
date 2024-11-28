// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using HerokuAppOperations;  // Import operations related to HerokuApp (e.g., ICheckBox interface)
using OpenQA.Selenium;  // Import Selenium WebDriver to interact with the web elements
using System;  // Import system utilities for exception handling and basic operations

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents the CheckBox functionality on the HerokuApp's checkbox page.
    /// Inherits from HerokuAppCommon and implements ICheckBox interface.
    /// </summary>
    public class CheckBox : HerokuAppCommon, ICheckBox
    {
        // Locators for the two checkboxes on the page
        private By checkbox1;  // Locator for checkbox 1 (first checkbox)
        private By checkbox2;  // Locator for checkbox 2 (second checkbox)

        private IWebDriver driver;  // WebDriver instance to interact with the browser

        /// <summary>
        /// Constructor to initialize the CheckBox class with the given WebDriver.
        /// Initializes locators for checkbox 1 and checkbox 2.
        /// </summary>
        /// <param name="arg">WebDriver instance passed from the test case to interact with the browser.</param>
        public CheckBox(IWebDriver arg) : base(arg)
        {
            this.driver = arg;  // Assign the WebDriver passed from the test
            // XPath locators for the checkboxes
            this.checkbox1 = By.XPath("//*[@id='checkboxes']/input[1]");  // First checkbox
            this.checkbox2 = By.XPath("//*[@id='checkboxes']/input[2]");  // Second checkbox
        }

        /// <summary>
        /// Gets the status of checkbox 1 (whether it is selected or not).
        /// </summary>
        /// <returns>True if checkbox 1 is selected, otherwise false.</returns>
        public bool GetCheckboxOneStatus()
        {
            // Find checkbox 1 and check if it is selected
            return this.driver.FindElement(checkbox1).Selected;
        }

        /// <summary>
        /// Gets the status of checkbox 2 (whether it is selected or not).
        /// </summary>
        /// <returns>True if checkbox 2 is selected, otherwise false.</returns>
        public bool GetCheckboxTwoStatus()
        {
            // Find checkbox 2 and check if it is selected
            return this.driver.FindElement(checkbox2).Selected;
        }

        // The following methods are not yet implemented and throw NotImplementedException.
        // These are possibly legacy or required by the interface but should be implemented later.

        /// <summary>
        /// Legacy method to get the status of checkbox 1 (not implemented).
        /// </summary>
        /// <returns>Throws NotImplementedException</returns>
        public bool getCHekboxOneSatatus()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Legacy method to get the status of checkbox 2 (not implemented).
        /// </summary>
        /// <returns>Throws NotImplementedException</returns>
        public bool getCHekboxTwoSatatus()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the title of the page (optional method to retrieve page title).
        /// </summary>
        /// <returns>The title of the current page as a string.</returns>
        public string GetTitle()
        {
            return this.driver.Title;  // Return the title of the current page
        }

        /// <summary>
        /// Legacy method for getting the page title (not implemented).
        /// </summary>
        /// <returns>Throws NotImplementedException</returns>
        public string getTitle()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// TearDown method to clean up resources after test execution.
        /// Quits the WebDriver instance and closes all browser windows.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Dispose of the WebDriver to prevent memory leaks
            if (driver != null)
            {
                driver.Quit();  // Quit the WebDriver and close all browser windows
                driver.Dispose();
            }
        }
    }
}
