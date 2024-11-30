// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HerokuAppWebdriverAdapter; // Reference to your page object model
using System;

namespace HerokuAppScenarios
{
    /// <summary>
    /// This test suite contains scenarios to validate the functionality of dynamic controls on the page:
    /// https://the-internet.herokuapp.com/dynamic_controls.
    /// It tests various elements like checkboxes, textboxes, and their interactions with loading indicators.
    /// </summary>
    [TestFixture]
    public class DynamicControlsTest
    {
        private IWebDriver driver; // WebDriver instance for browser interactions
        private IDynamicControlsPage dynamicControlsPage; // Interface for Dynamic Controls page interaction

        /// <summary>
        /// Sets up the browser (Chrome) and navigates to the Dynamic Controls page before each test.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize the WebDriver and navigate to the target page
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // Maximize the browser window for clarity
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_controls");

            // Initialize the Page Object for interacting with the Dynamic Controls page
            dynamicControlsPage = new DynamicControls(driver);
        }

        /// <summary>
        /// Tears down the WebDriver instance after each test, ensuring proper resource cleanup.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit(); // Close the browser
                driver.Dispose(); // Dispose of the WebDriver resources
                driver = null; // Reset the driver to null
            }
        }

        /// <summary>
        /// Tests adding and removing the checkbox on the page.
        /// Verifies the checkbox's visibility after each operation.
        /// </summary>
        [Test]
        public void TestAddAndRemoveCheckbox()
        {
            // Remove the checkbox and verify it is no longer displayed
            dynamicControlsPage.RemoveCheckbox();
            Assert.False(dynamicControlsPage.IsCheckboxDisplayed(), "Checkbox was not removed.");

            // Add the checkbox back and verify it is displayed
            dynamicControlsPage.AddCheckbox();
            Assert.True(dynamicControlsPage.IsCheckboxDisplayed(), "Checkbox was not added.");
        }

        /// <summary>
        /// Tests enabling and disabling the textbox.
        /// Validates that the textbox state changes correctly after each operation.
        /// </summary>
        [Test]
        public void TestEnableAndDisableTextbox()
        {
            // Enable the textbox and verify it is enabled
            dynamicControlsPage.EnableTextbox();
            Assert.True(dynamicControlsPage.IsTextBoxEnabled(), "Textbox was not enabled.");

            // Disable the textbox and verify it is disabled
            dynamicControlsPage.DisableTextbox();
            Assert.False(dynamicControlsPage.IsTextBoxEnabled(), "Textbox was not disabled.");
        }

        /// <summary>
        /// Tests the loading and completion messages when performing actions on the dynamic controls.
        /// Verifies that appropriate messages are displayed during and after the operations.
        /// </summary>
        [Test]
        public void TestLoadingAndCompletionMessages()
        {
            // Click the "Remove" button and verify the loading message appears
            dynamicControlsPage.ClickRemoveButton();
            string loadingMessage = dynamicControlsPage.GetLoadingMessage();
            Assert.IsNotNull(loadingMessage, "Loading message did not appear.");
            Console.WriteLine($"Loading message: {loadingMessage}");

            // Wait for the loading message to disappear
            dynamicControlsPage.WaitForLoadingToDisappear();
            Console.WriteLine("Loading message disappeared.");

            // Verify the completion message matches expected text
            string completionMessage = dynamicControlsPage.GetCompletionMessage();
            Assert.AreEqual("It's gone!", completionMessage, "Completion message did not match expected value.");
        }

        /// <summary>
        /// Tests the Enable and Disable button functionality for the textbox.
        /// Validates state changes and the display of loading indicators.
        /// </summary>
        [Test]
        public void TestEnableAndDisableButtonFunctionality()
        {
            // Click the Enable button and verify the textbox becomes enabled
            dynamicControlsPage.ClickEnableButton();
            string enableLoadingMessage = dynamicControlsPage.GetLoadingMessage();
            Assert.IsNotNull(enableLoadingMessage, "Loading message for enabling the textbox did not appear.");
            Console.WriteLine($"Loading message (Enable): {enableLoadingMessage}");

            // Wait for the loading message to disappear
            dynamicControlsPage.WaitForLoadingToDisappear();
            Assert.True(dynamicControlsPage.IsTextBoxEnabled(), "Textbox was not enabled.");
            Console.WriteLine("Textbox is enabled.");

            // Click the Disable button and verify the textbox becomes disabled
            dynamicControlsPage.ClickDisableButton();
            string disableLoadingMessage = dynamicControlsPage.GetLoadingMessage();
            Assert.IsNotNull(disableLoadingMessage, "Loading message for disabling the textbox did not appear.");
            Console.WriteLine($"Loading message (Disable): {disableLoadingMessage}");

            // Wait for the loading message to disappear
            dynamicControlsPage.WaitForLoadingToDisappear();
            Assert.False(dynamicControlsPage.IsTextBoxEnabled(), "Textbox was not disabled.");
            Console.WriteLine("Textbox is disabled.");
        }

        /// <summary>
        /// Tests the page title and description to ensure they match expected values.
        /// </summary>
        [Test]
        public void TestPageTitleAndDescription()
        {
            // Retrieve and verify the page title
            string pageTitle = dynamicControlsPage.GetPageTitle();
            Assert.AreEqual("Dynamic Controls", pageTitle, "Page title did not match expected value.");
            Console.WriteLine($"Page Title: {pageTitle}");

            // Retrieve and verify the page description
            string pageDescription = dynamicControlsPage.GetPageDescription();
            string expectedDescription = "This example demonstrates when elements (e.g., checkbox, input field, etc.) are changed asynchronously.";
            Assert.AreEqual(expectedDescription, pageDescription, "Page description did not match expected value.");
            Console.WriteLine($"Page Description: {pageDescription}");
        }
    }
}
