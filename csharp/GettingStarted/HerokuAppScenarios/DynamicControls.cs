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
    // NUnit test fixture for testing dynamic controls functionality on the Heroku app
    [TestFixture]
    public class DynamicControlsTests
    {
        private IWebDriver driver;  // WebDriver instance to interact with the browser
        private IDynamicControlsPage dynamicControlsPage;  // Interface to interact with the Dynamic Controls page

        // Setup method that runs before each test
        [SetUp]
        public void Setup()
        {
            // Initialize the ChromeDriver for Selenium WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();  // Maximize the browser window for better visibility
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_controls");  // Navigate to the dynamic controls page

            // Create an instance of the page object model to interact with the page
            dynamicControlsPage = new DynamicControlsPage(driver);
        }

        // TearDown method that runs after each test
        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();  // Close the browser and clean up resources
                driver.Dispose();  // Dispose of the WebDriver instance
                driver = null;
            }
        }

        // Test method for adding and removing the checkbox
        [Test]
        public void TestAddAndRemoveCheckbox()
        {
            // Test removing the checkbox and assert that it's no longer displayed
            dynamicControlsPage.RemoveCheckbox();
            Assert.False(dynamicControlsPage.IsCheckboxDisplayed(), "Checkbox was not removed.");

            // Test adding the checkbox and assert that it is displayed
            dynamicControlsPage.AddCheckbox();
            Assert.True(dynamicControlsPage.IsCheckboxDisplayed(), "Checkbox was not added.");
        }

        // Test method for enabling and disabling the textbox
        [Test]
        public void TestEnableAndDisableTextbox()
        {
            // Test enabling the textbox and assert that it's enabled
            dynamicControlsPage.EnableTextbox();
            Assert.True(dynamicControlsPage.IsTextBoxEnabled(), "Textbox was not enabled.");

            // Test disabling the textbox and assert that it's disabled
            dynamicControlsPage.DisableTextbox();
            Assert.False(dynamicControlsPage.IsTextBoxEnabled(), "Textbox was not disabled.");
        }

        // Test method for loading and completion messages when interacting with dynamic controls
        [Test]
        public void TestLoadingAndCompletionMessages()
        {
            // Trigger the action that shows the loading message (e.g., clicking the "Remove" button)
            dynamicControlsPage.ClickRemoveButton();
            Console.WriteLine("Remove button clicked.");

            // Ensure that the loading message appears and verify it's not null
            string loadingMessage = dynamicControlsPage.GetLoadingMessage();
            Assert.IsNotNull(loadingMessage, "Loading message did not appear.");
            Console.WriteLine($"Loading message: {loadingMessage}");

            // Wait for the loading message to disappear and verify it
            dynamicControlsPage.WaitForLoadingToDisappear();
            Console.WriteLine("Loading message disappeared.");

            // Retrieve and verify the completion message after the operation is complete
            string completionMessage = dynamicControlsPage.GetCompletionMessage();
            Assert.IsNotNull(completionMessage, "Completion message did not appear.");
            Console.WriteLine($"Completion message: {completionMessage}");

            // Assert that the completion message matches the expected value
            Assert.AreEqual("It's gone!", completionMessage, "Completion message did not match expected value.");
        }

        // Test method for the functionality of the Enable and Disable buttons
        [Test]
        public void TestEnableAndDisableButtonFunctionality()
        {
            // Trigger the action to enable the textbox and verify that the textbox is enabled
            dynamicControlsPage.ClickEnableButton();
            Console.WriteLine("Enable button clicked.");

            // Ensure that the loading message appears for enabling the textbox
            string enableLoadingMessage = dynamicControlsPage.GetLoadingMessage();
            Assert.IsNotNull(enableLoadingMessage, "Loading message for enabling the text box did not appear.");
            Console.WriteLine($"Loading message (Enable): {enableLoadingMessage}");

            // Wait for the loading message to disappear and verify it
            dynamicControlsPage.WaitForLoadingToDisappear();
            Console.WriteLine("Loading message for enabling the text box disappeared.");

            // Verify that the textbox is enabled
            bool IsTextBoxEnabled = dynamicControlsPage.IsTextBoxEnabled();
            Assert.IsTrue(IsTextBoxEnabled, "The text box was not enabled.");
            Console.WriteLine("The text box is enabled.");

            // Trigger the action to disable the textbox and verify that the textbox is disabled
            dynamicControlsPage.ClickDisableButton();
            Console.WriteLine("Disable button clicked.");

            // Ensure that the loading message appears for disabling the textbox
            string disableLoadingMessage = dynamicControlsPage.GetLoadingMessage();
            Assert.IsNotNull(disableLoadingMessage, "Loading message for disabling the text box did not appear.");
            Console.WriteLine($"Loading message (Disable): {disableLoadingMessage}");

            // Wait for the loading message to disappear and verify it
            dynamicControlsPage.WaitForLoadingToDisappear();
            Console.WriteLine("Loading message for disabling the text box disappeared.");

            // Verify that the textbox is disabled
            bool isTextBoxDisabled = !dynamicControlsPage.IsTextBoxEnabled();
            Assert.IsTrue(isTextBoxDisabled, "The text box was not disabled.");
            Console.WriteLine("The text box is disabled.");
        }
    }
}
