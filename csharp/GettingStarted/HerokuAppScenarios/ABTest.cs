using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for verifying A/B test page functionality.
    /// This class uses Selenium WebDriver to test the content of the A/B Test page on HerokuApp.
    /// </summary>
    [TestFixture]
    public class ABTest
    {
        // Declare the WebDriver instance at the class level so it can be used across the methods
        private IWebDriver driver;

        /// <summary>
        /// SetUp method to initialize WebDriver before each test.
        /// Creates a new ChromeDriver instance, maximizes the browser window, and navigates to the A/B Test page.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            try
            {
                // Initialize WebDriver with ChromeDriver
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();  // Maximize the browser window for better visibility
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/abtest");  // Navigate to the A/B Test page URL
            }
            catch (Exception ex)
            {
                // Fail the test if setup fails and log the exception
                Assert.Fail($"SetUp failed: {ex.Message}");
            }
        }

        /// <summary>
        /// TearDown method to clean up after each test.
        /// Quits the WebDriver to ensure that there are no memory leaks or stale connections after the test.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Ensure that the WebDriver is not null and not disposed before calling Quit
            if (driver != null)
            {
                try
                {
                    driver.Quit();  // Close the browser and quit WebDriver
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error during TearDown while quitting the WebDriver: {ex.Message}");
                }
                finally
                {
                    // Dispose the WebDriver properly and set it to null to prevent reuse in the next test
                    driver.Dispose();
                    driver = null;
                }
            }
            else
            {
                Console.WriteLine("Driver was null in TearDown.");
            }
        }

        /// <summary>
        /// Test method to verify the content of the A/B Test page.
        /// This method waits for an element with class 'example' to appear and checks the content for variations.
        /// </summary>
        [Test]
        public void VerifyABTestPage()
        {
            // Create an explicit wait with a timeout of 10 seconds to wait for the element to be present
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                // Wait until the element with the CSS class 'example' is visible on the page
                IWebElement element = wait.Until(driver => driver.FindElement(By.CssSelector(".example")));

                // Retrieve the text content of the element
                string pageContent = element.Text;

                // Debugging: Output the page content to the console for inspection
                Console.WriteLine("Page Content: " + pageContent);

                // Check if the page content contains any of the following strings: "Variation 1", "Variation 2", or "A/B Test Control"
                bool containsVariation1 = pageContent.Contains("Variation 1");
                bool containsVariation2 = pageContent.Contains("Variation 2");
                bool containsControl = pageContent.Contains("A/B Test Control");

                // Assert that at least one of the variations or the control text is found in the page content
                Assert.IsTrue(containsVariation1 || containsVariation2 || containsControl,
                    $"Expected either 'Variation 1', 'Variation 2', or 'A/B Test Control' but found neither. Actual content: {pageContent}");
            }
            catch (WebDriverTimeoutException e)
            {
                // If the WebDriverTimeoutException occurs, fail the test with an appropriate message
                Assert.Fail("Test failed due to timeout: " + e.Message);
            }
            catch (Exception ex)
            {
                // If any unexpected exception occurs, fail the test and print the exception message
                Assert.Fail("Test failed with unexpected exception: " + ex.Message);
            }
        }
    }
}
