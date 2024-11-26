using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class ABTestPageTest
    {
        public IWebDriver driver; // Declare driver at class level

        [SetUp]
        public void SetUp()
        {
            // Initialize WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/abtest");
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
        public void VerifyABTestPage()
        {
            // Create a WebDriverWait instance with timeout of 10 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Wait until the element with class 'example' is visible on the page
            IWebElement element = wait.Until(driver => driver.FindElement(By.CssSelector(".example")));

            // Get the page content text
            string pageContent = element.Text;

            // Debugging: Print the actual content to see what's returned
            Console.WriteLine("Page Content: " + pageContent);

            // Check if the page contains "Variation 1", "Variation 2", or "A/B Test Control"
            bool containsVariation1 = pageContent.Contains("Variation 1");
            bool containsVariation2 = pageContent.Contains("Variation 2");
            bool containsControl = pageContent.Contains("A/B Test Control");

            // Assert that one of the variations or control is present
            Assert.IsTrue(containsVariation1 || containsVariation2 || containsControl,
                $"Expected either 'Variation 1', 'Variation 2', or 'A/B Test Control' but found neither. Actual content: {pageContent}");
        }
    }
}
