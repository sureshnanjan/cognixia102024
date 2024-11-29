// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace HerokuAppWebdriverAdapter
{
    // Class that represents the "Dynamic Controls" page in the Heroku App, and implements IDynamicControlsPage interface.
    // This class provides various methods to interact with and retrieve information from elements on the page.
    public class DynamicControlsPage : IDynamicControlsPage
    {
        private readonly IWebDriver _driver;  // WebDriver instance to interact with the browser
        private readonly WebDriverWait _wait; // WebDriverWait instance for waiting until certain conditions are met

        // Locators for various elements on the page
        private readonly By checkboxLocator = By.Id("checkbox");  // Locator for the checkbox element
        private readonly By addRemoveButtonLocator = By.XPath("//button[text()='Add'] | //button[text()='Remove']");  // Locator for Add/Remove button
        private readonly By textboxLocator = By.XPath("//input[@type='text']");  // Locator for the textbox element
        private readonly By enableDisableButtonLocator = By.XPath("//button[text()='Enable'] | //button[text()='Disable']");  // Locator for Enable/Disable button
        private readonly By loadingMessageLocator = By.Id("loading");  // Locator for the loading message
        private readonly By completionMessageLocator = By.Id("message");  // Locator for the completion message

        // Constructor that initializes the WebDriver and WebDriverWait
        public DynamicControlsPage(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));  // Ensure driver is not null
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));  // Set the wait time to 10 seconds
        }

        // Adds a checkbox to the page by clicking the "Add" button
        public void AddCheckbox()
        {
            var button = _driver.FindElement(addRemoveButtonLocator);  // Find the Add/Remove button
            if (button.Text.Equals("Add"))  // If the button text is "Add", click it to add the checkbox
            {
                button.Click();
                _wait.Until(driver => IsCheckboxDisplayed());  // Wait until the checkbox is displayed
            }
        }

        // Removes the checkbox from the page by clicking the "Remove" button
        public void RemoveCheckbox()
        {
            var button = _driver.FindElement(addRemoveButtonLocator);  // Find the Add/Remove button
            if (button.Text.Equals("Remove"))  // If the button text is "Remove", click it to remove the checkbox
            {
                button.Click();
                _wait.Until(driver => !IsCheckboxDisplayed());  // Wait until the checkbox is no longer displayed
            }
        }

        // Checks if the checkbox is displayed on the page
        public bool IsCheckboxDisplayed()
        {
            try
            {
                return _driver.FindElement(checkboxLocator).Displayed;  // Return true if checkbox is displayed, otherwise false
            }
            catch (NoSuchElementException)
            {
                return false;  // Return false if checkbox is not found (not displayed)
            }
        }

        // Enables the textbox by clicking the "Enable" button and waiting for the textbox to become enabled
        public void EnableTextbox()
        {
            _driver.FindElement(enableDisableButtonLocator).Click();  // Find and click the Enable/Disable button
            _wait.Until(driver => IsTextboxEnabled());  // Wait until the textbox is enabled
        }

        // Disables the textbox by clicking the "Disable" button and waiting for the textbox to become disabled
        public void DisableTextbox()
        {
            _driver.FindElement(enableDisableButtonLocator).Click();  // Find and click the Enable/Disable button
            _wait.Until(driver => !IsTextboxEnabled());  // Wait until the textbox is disabled
        }

        // Checks if the textbox is enabled by checking its 'Enabled' property
        public bool IsTextboxEnabled()
        {
            return _driver.FindElement(textboxLocator).Enabled;  // Return true if textbox is enabled, false otherwise
        }

        // Clicks the "Remove" button to remove the checkbox
        public void ClickRemoveButton()
        {
            var removeButton = _wait.Until(driver => driver.FindElement(By.CssSelector("button[onclick='swapCheckbox()']")));  // Wait for and find the Remove button
            removeButton.Click();  // Click the Remove button
        }

        // Waits for the loading message to disappear from the page
        public void WaitForLoadingToDisappear()
        {
            // Wait until there are no elements with the loading message or if the first element is not displayed
            _wait.Until(driver =>
            {
                var elements = driver.FindElements(loadingMessageLocator);  // Find all elements with the loading message locator
                return elements.Count == 0 || !elements[0].Displayed;  // Return true if loading message is no longer displayed
            });
        }

        // Waits for the completion message to appear and retrieves its text
        public string GetCompletionMessage()
        {
            var element = _wait.Until(driver => driver.FindElement(completionMessageLocator));  // Wait for and find the completion message element
            return element.Text;  // Return the text of the completion message
        }

        // Waits for the loading message to appear and retrieves its text
        public string GetLoadingMessage()
        {
            var element = _wait.Until(driver => driver.FindElement(loadingMessageLocator));  // Wait for and find the loading message element
            return element.Text;  // Return the text of the loading message
        }

        // Clicks the "Enable" button to enable the textbox
        public void ClickEnableButton()
        {
            var enableButton = _wait.Until(driver => driver.FindElement(By.CssSelector("button[onclick='swapInput()']")));  // Wait for and find the Enable button
            enableButton.Click();  // Click the Enable button
        }

        // Clicks the "Disable" button to disable the textbox
        public void ClickDisableButton()
        {
            var disableButton = _wait.Until(driver => driver.FindElement(By.CssSelector("button[onclick='swapInput()']")));  // Wait for and find the Disable button
            disableButton.Click();  // Click the Disable button
        }

        // Checks if the textbox is enabled by checking the 'Enabled' property
        public bool IsTextBoxEnabled()
        {
            var textBox = _wait.Until(driver => driver.FindElement(By.CssSelector("input[type='text']")));  // Wait for and find the textbox element
            return textBox.Enabled;  // Return true if the textbox is enabled, false otherwise
        }
    }
}
