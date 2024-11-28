// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using NUnit.Framework;  // Import NUnit for test framework functionality
using OpenQA.Selenium;  // Import Selenium WebDriver for browser automation
using OpenQA.Selenium.Chrome;  // Import ChromeDriver for Chrome browser support
using HerokuAppWebdriverAdapter;  // Import custom WebDriver adapter classes for page object interactions
using OpenQA.Selenium.Support.UI;  // Import WebDriver support utilities for explicit wait

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for verifying dynamic loading operations on HerokuApp.
    /// This includes starting the loading process and verifying that elements become visible.
    /// </summary>
    [TestFixture]
    public class DynamicLoadingTests
    {
        private IWebDriver _driver;  // WebDriver instance for interacting with the browser
        private DynamicLoading _dynamicLoading;  // Page object instance to interact with dynamic loading page

        /// <summary>
        /// Setup method for initializing WebDriver and navigating to the Dynamic Loading page before each test.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize Chrome WebDriver and set an implicit wait for element lookup
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Navigate to the Dynamic Loading page
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading");

            // Initialize the page object for dynamic loading operations
            _dynamicLoading = new DynamicLoading(_driver);
        }

        /// <summary>
        /// TearDown method for cleaning up after each test by quitting the WebDriver.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Close the browser and quit WebDriver to release resources
            _driver.Quit();
        }

        /// <summary>
        /// Test case to verify the page title of the Dynamic Loading page.
        /// </summary>
        [Test]
        public void Test_GetTitle()
        {
            // Get the page title using the page object method
            string title = _dynamicLoading.GetTitle();

            // Assert that the title matches the expected value
            Assert.AreEqual("Dynamically Loaded Page Elements", title,
                "The page title should match 'Dynamically Loaded Page Elements'.");
        }

        /// <summary>
        /// Test case to start loading and verify that the dynamic element becomes visible after loading.
        /// </summary>
        [Test]
        public void Test_StartLoadingAndVerifyElement()
        {
            // Start the loading operation using the page object method
            _dynamicLoading.StartLoading();
            Console.WriteLine("Started loading...");

            try
            {
                // Use WebDriverWait to wait for the element to become visible
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
                bool isElementVisible = wait.Until(d =>
                {
                    try
                    {
                        // Attempt to find the element with the specified XPath
                        var element = d.FindElement(By.XPath("//*[@id=\"finish\"]/h4"));
                        return element.Displayed;  // Return true if the element is visible
                    }
                    catch (NoSuchElementException)
                    {
                        // If element is not found, return false
                        return false;
                    }
                });

                // Assert that the element is visible after loading
                Assert.IsTrue(isElementVisible, "The element should be visible after loading.");
            }
            catch (WebDriverTimeoutException)
            {
                // Fail the test if the element did not become visible in time
                Assert.Fail("The element did not become visible within the expected time.");
            }
        }

    }
}
