// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using HerokuAppWebdriverAdapter;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using HerokuAppOperations;

namespace HerokuAppTests
{
    /// <summary>
    /// Test suite to validate the behavior of the JavaScript Onload Event Error page.
    /// Includes tests to verify the page title and check for JavaScript error messages.
    /// </summary>
    [TestFixture]
    public class JavaScriptOnloadEventError
    {
        // WebDriver instance for browser interaction
        private IWebDriver driver;

        // Page object for the JavaScript Error page
        private JsError jsErrorPage;

        /// <summary>
        /// Setup method to initialize WebDriver and navigate to the test page.
        /// Called before each test.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize the Chrome WebDriver
            driver = new ChromeDriver();

            // Navigate to the JavaScript Onload Event Error page
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_error");

            // Initialize the page object for handling JavaScript errors
            jsErrorPage = new JsError(driver);
        }

        /// <summary>
        /// Test to verify the page title matches the expected value.
        /// </summary>
        [Test]
        public void VerifyPageTitle()
        {
            // Act: Retrieve the page title using the page object
            string title = jsErrorPage.GetTitle();

            // Assert: Verify the title matches the expected value
            Assert.AreEqual("Page with JavaScript errors on load", title, "The page title is not as expected.");
        }

        /// <summary>
        /// Test to check if a JavaScript error message is displayed on the page.
        /// Ensures no error message is visible to the user.
        /// </summary>
        [Test]
        public void CheckIfErrorMessageIsDisplayed()
        {
            // Act: Try to locate the JavaScript error message
            bool isErrorMessageDisplayed;

            try
            {
                // Check if the error message element is displayed
                isErrorMessageDisplayed = jsErrorPage.IsErrorMessageDisplayed();
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, assume no error message is displayed
                isErrorMessageDisplayed = false;
            }

            // Assert: Ensure the error message is not displayed
            Assert.IsFalse(isErrorMessageDisplayed, "JavaScript error message should not be displayed.");
        }

        /// <summary>
        /// TearDown method to close the browser and clean up resources.
        /// Called after each test.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Quit the WebDriver to close the browser
            driver.Quit();
            driver.Dispose();
        }
    }
}
