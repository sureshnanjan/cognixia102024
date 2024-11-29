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
        private IWebDriver driver; // WebDriver instance for managing browser actions
        private IHomePage homePage; // Interface for interacting with the HomePage

        [SetUp]
        public void Setup()
        {
            // Initialize WebDriver and navigate to the homepage
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");

            // Instantiate HomePage object
            homePage = new HomePage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            // Ensure WebDriver is properly disposed after tests
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }

        [Test]
        public void HomePageTitleIsCorrect()
        {
            // Validate the combined title (h1 and h2) of the homepage
            string expected = "Welcome to the-internet - Available Examples"; // Expected title
            string actual = homePage.GetTitle();

            Assert.That(actual, Is.EqualTo(expected), "Home page title does not match the expected value.");
        }

        [Test]
        public void HomePageAvailableExamplesAreCorrect()
        {
            // Validate the count of available examples on the homepage
            var availableExamples = homePage.GetAvailableExamples();
            int expectedExamplesCount = 44; // Adjust this count as needed based on the actual page content

            // Log examples for better debugging
            Console.WriteLine("Available examples:");
            foreach (var example in availableExamples)
            {
                Console.WriteLine($"- {example}");
            }

            Assert.That(availableExamples.Length, Is.EqualTo(expectedExamplesCount),
                $"Expected {expectedExamplesCount} examples, but found {availableExamples.Length}.");
        }

        [Test]
        public void HomePageAccessingExampleLinkWorks()
        {
            // Validate navigation to an example link
            var availableExamples = homePage.GetAvailableExamples();

            // Ensure there is at least one example
            Assert.That(availableExamples.Length, Is.GreaterThan(0), "No examples found on the homepage.");

            int exampleIndex = 0; // Index of the example to test
            string exampleUrl = homePage.GetExampleLinkUrl(exampleIndex);

            // Log the URL for better traceability
            Console.WriteLine($"Navigating to example link: {exampleUrl}");

            driver.Navigate().GoToUrl(exampleUrl);
            string expectedUrl = exampleUrl;
            string actualUrl = driver.Url;

            Assert.That(actualUrl, Is.EqualTo(expectedUrl),
                "Navigated URL does not match the expected example URL.");
        }
    }
}
