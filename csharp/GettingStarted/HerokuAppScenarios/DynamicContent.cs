// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;  // Import system utilities
using HerokuAppOperations;  // Import operations related to dynamic content
using HerokuAppWebdriverAdapter;  // Import the WebDriver adapter for dynamic content interactions
using NUnit.Framework;  // Import NUnit framework for unit testing
using OpenQA.Selenium;  // Import Selenium WebDriver for browser automation
using OpenQA.Selenium.Chrome;  // Import ChromeDriver for Selenium

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for validating dynamic content on the Heroku app's dynamic content page.
    /// </summary>
    [TestFixture]  // Indicates this class contains NUnit tests
    public class DynamicContentTest
    {
        private ChromeDriver driver;  // WebDriver instance to interact with the browser
        private IDynamicContent dynamicContent;  // DynamicContent interface for interacting with dynamic content

        /// <summary>
        /// SetUp method to initialize resources before each test.
        /// It creates a new WebDriver instance, maximizes the window, and navigates to the dynamic content page.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            try
            {
                // Initialize WebDriver (using ChromeDriver for Chrome browser)
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();  // Maximize the browser window
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_content");  // Navigate to the dynamic content page

                // Initialize the dynamic content page object
                dynamicContent = new DynamicContent(driver);  // Instantiate the DynamicContent object passing the WebDriver
            }
            catch (Exception ex)
            {
                Assert.Fail($"SetUp failed: {ex.Message}");
            }
        }

        /// <summary>
        /// TearDown method to clean up after each test.
        /// It ensures the WebDriver instance is disposed of properly to avoid memory leaks.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            try
            {
                // Dispose of the WebDriver to prevent memory leaks or stale connections
                if (driver != null)
                {
                    driver.Quit();  // Quit the WebDriver and close all open browser windows
                    driver.Dispose();  // Dispose the WebDriver instance
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during TearDown: {ex.Message}");
            }
            finally
            {
                driver = null;  // Set the driver to null to ensure it's not used again
            }
        }

        /// <summary>
        /// Test method for validating dynamic content.
        /// It checks that the page title and content text are not empty, ensuring dynamic content is loaded.
        /// </summary>
        [Test]
        public void TestDynamicContent()
        {
            // Retrieve the title and content text using methods from the DynamicContent class
            string pageTitle = dynamicContent.GetTitle();  // Call GetTitle method from DynamicContent to get the page title
            string contentText = dynamicContent.GetContentText();  // Call GetContentText method from DynamicContent to get the content text

            // Perform some assertions to validate the content
            // Assert that the page title is not empty
            Assert.IsNotEmpty(pageTitle, "Title should not be empty.");
            // Assert that the content text is not empty
            Assert.IsNotEmpty(contentText, "Content text should not be empty.");
        }
    }
}
