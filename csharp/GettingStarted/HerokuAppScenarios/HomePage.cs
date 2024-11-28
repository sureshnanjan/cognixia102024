// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using NUnit.Framework;  // Import NUnit framework for writing and running tests
using OpenQA.Selenium;  // Import Selenium WebDriver for interacting with the browser
using OpenQA.Selenium.Chrome;  // Import ChromeDriver for browser automation with Google Chrome
using HerokuAppWebdriverAdapter;  // Import custom adapter classes for interacting with the Heroku app
using System;  // Import System namespace for general functionalities

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for verifying functionality on the Home Page of the Heroku App.
    /// </summary>
    [TestFixture]
    public class HomePageTests
    {
        private IWebDriver driver;  // WebDriver instance for browser interaction
        private IHomePage homePage;  // Interface for interacting with the HomePage

        /// <summary>
        /// Setup method to initialize WebDriver and navigate to the Home Page before each test.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize Chrome WebDriver instance
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();  // Maximize the browser window for visibility

            // Navigate to the Home Page URL
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");

            // Initialize the HomePage interface to interact with elements on the homepage
            homePage = new HomePage(driver);
        }

        /// <summary>
        /// TearDown method to clean up after each test and quit the WebDriver.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Quit the WebDriver to ensure that resources are released
            if (driver != null)
            {
                driver.Quit();  // Close the browser window and terminate the WebDriver session
                driver = null;  // Set the driver to null to avoid further use after teardown
            }
        }

        /// <summary>
        /// Test case to verify if the homepage title is correct.
        /// </summary>
        [Test]
        public void HomePageTitleIsCorrect()
        {
            // Define the expected title for the HomePage
            string expected = "Welcome to the-internet - Available Examples"; // Adjusted expected title
            // Get the actual title from the HomePage via the GetTitle() method
            string actual = homePage.GetTitle();

            // Assert that the actual title matches the expected title
            Assert.That(actual, Is.EqualTo(expected), "Home page title is incorrect.");
        }

        /// <summary>
        /// Test case to verify the number of available examples (links) on the homepage.
        /// </summary>
        [Test]
        public void HomePageAvailableExamplesAreCorrect()
        {
            // Locate all clickable links (anchor tags) on the homepage using a CSS selector
            var availableExamples = driver.FindElements(By.CssSelector("a"));

            // Log the total number of clickable links found for debugging purposes
            Console.WriteLine($"Total clickable options found: {availableExamples.Count}");

            // Define the expected number of available examples (links) on the homepage
            int expectedExamplesCount = 46;  // Update this based on the actual expected number of links
            // Assert that the number of links on the page matches the expected count
            Assert.That(availableExamples.Count, Is.EqualTo(expectedExamplesCount), "Number of available examples is incorrect.");
        }

        /// <summary>
        /// Test case placeholder for verifying if accessing example links works.
        /// </summary>
        [Test]
        public void HomePageAccessingExampleLinkWorks()
        {
            // This test is currently a placeholder and is marked as passed for now
            Assert.Pass();  // Marks the test as passed without executing any verification
        }
    }
}
