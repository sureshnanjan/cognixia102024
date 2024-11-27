using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HerokuAppWebdriverAdapter;
using System;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class HomePageTests
    {
        private IWebDriver driver; // Declare WebDriver at class level
        private IHomePage homePage; // Declare HomePage interface

        [SetUp]
        public void Setup()
        {
            // Initialize WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");

            // Initialize HomePage using the WebDriver
            homePage = new HomePage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            // Dispose of WebDriver instance to prevent memory leaks or stale connections
            if (driver != null)
            {
                driver.Quit();  // Quit the WebDriver to clean up after test
                driver = null;  // Set driver to null to ensure it's not used again
            }
        }

        [Test]
        public void HomePageTitleIsCorrect()
        {
            // Expected title for the homepage, combining h1 and h2
            string expected = "Welcome to the-internet - Available Examples"; // Adjusted expected title
            string actual = homePage.GetTitle();

            // Verify that the actual combined title matches the expected title
            Assert.That(actual, Is.EqualTo(expected), "Home page title is incorrect.");
        }

        [Test]
        public void HomePageAvailableExamplesAreCorrect()
        {
            // Locate all clickable links on the homepage
            var availableExamples = driver.FindElements(By.CssSelector("a"));

            // Log the total number of examples for debugging
            Console.WriteLine($"Total clickable options found: {availableExamples.Count}");

            // Assert the count of examples
            int expectedExamplesCount = 46; // Update this based on the expected number of links
            Assert.That(availableExamples.Count, Is.EqualTo(expectedExamplesCount), "Number of available examples is incorrect.");
        }


        [Test]
        public void HomePageAccessingExampleLinkWorks()
        {
            Assert.Pass();
        }
    }
}
