// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using HerokuAppWebdriverAdapter;  // Importing the HerokuAppWebdriverAdapter for interacting with the Heroku app.
using OpenQA.Selenium.Chrome;  // Importing the Selenium ChromeDriver for web browser automation using Chrome.
using OpenQA.Selenium;  // Importing Selenium WebDriver interface for browser automation.
using System;  // Importing System namespace for common system utilities.
using System.Collections.Generic;  // Importing collections for working with lists or dictionaries.
using System.Linq;  // Importing LINQ for querying collections.
using System.Text;  // Importing Text for string manipulations.
using System.Threading.Tasks;  // Importing Task for handling asynchronous operations.

namespace HerokuAppScenarios
{
    // Internal class that contains test cases for the LargePage functionality.
    // These tests validate elements such as the page title and content on the "Large" page.
    internal class LargePageTests
    {
        private ChromeDriver driver;  // The WebDriver instance for Chrome browser interaction.
        private LargePage largePage;  // The LargePage object that abstracts interactions with the "Large" page.

        // SetUp method to initialize resources before each test.
        // It creates a new ChromeDriver instance and initializes the LargePage object.
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();  // Instantiate the ChromeDriver to control the browser.
            largePage = new LargePage(driver);  // Instantiate the LargePage object using the driver.
        }

        // Test method to validate the title of the "Large" page.
        [Test]
        public void ValidatePageTitle()
        {
            // The expected title of the page.
            string expectedTitle = "Large & Deep DOM";
            // Get the actual title from the LargePage object.
            string actualTitle = largePage.GetTitle();
            // Assert that the expected title matches the actual title.
            Assert.AreEqual(expectedTitle, actualTitle);
            // Log the page title for debugging purposes.
            Console.WriteLine($"Page title: {actualTitle}");
        }

        // Test method to validate the content of the "Large" page.
        // It checks that the content is not empty.
        [Test]
        public void ValidatePageContent()
        {
            // Retrieve the page content using the LargePage object.
            string content = largePage.GetPageContent();
            // Assert that the content is not empty.
            Assert.IsFalse(string.IsNullOrEmpty(content), "Page content is empty.");
            // Log the first 100 characters of the page content for inspection.
            Console.WriteLine($"Page content (first 100 chars): {content.Substring(0, Math.Min(100, content.Length))}...");
        }

        // TearDown method to clean up after each test.
        // It quits the WebDriver and disposes of any resources to prevent memory leaks.
        [TearDown]
        public void TearDown()
        {
            driver.Quit();  // Quit the WebDriver and close the browser.
            driver.Dispose();  // Dispose of the WebDriver instance to release resources.
        }
    }
}
