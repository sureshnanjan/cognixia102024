// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;  // Import basic system utilities
using HerokuAppWebdriverAdapter;  // Import custom WebDriver adapter classes
using NUnit.Framework;  // Import NUnit testing framework
using OpenQA.Selenium;  // Import Selenium WebDriver for browser automation
using OpenQA.Selenium.Chrome;  // Import ChromeDriver for Chrome browser support
using OpenQA.Selenium.Support.UI;  // Import WebDriver support utilities for explicit wait

namespace HerokuAppScenarios
{
    /// <summary>
    /// NUnit test class for verifying dynamic controls operations on the HerokuApp.
    /// Contains test cases to interact with checkboxes and dynamically change their state.
    /// </summary>
    [TestFixture]
    public class DynamicControlsTests
    {
        private IWebDriver _driver;  // WebDriver instance for interacting with the browser
        private WebDriverWait _wait;  // WebDriverWait instance for handling explicit waits
        private DynamicControlsPage _dynamicControls;  // Page object to interact with dynamic controls on the page

        /// <summary>
        /// Setup method to initialize WebDriver and navigate to the test page.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize Chrome WebDriver and set up implicit wait
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Initialize WebDriverWait for explicit waiting
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            // Navigate to the Dynamic Controls page of HerokuApp
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_controls");

            // Initialize the page object for interacting with dynamic controls
            _dynamicControls = new DynamicControlsPage(_driver);
        }

        /// <summary>
        /// TearDown method to quit the WebDriver after each test.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Close the browser and quit WebDriver after each test to free resources
            _driver.Quit();
            _driver.Dispose();
        }

        /// <summary>
        /// Test case to verify the page title of the Dynamic Controls page.
        /// </summary>
        [Test]
        public void Test_GetTitle()
        {
            // Get the title of the current page
            string title = _dynamicControls.GetTitle();

            // Assert that the title matches the expected value
            Assert.AreEqual("Dynamic Controls", title, "The title should match 'Dynamic Controls'.");
        }

        /// <summary>
        /// Test case to enable the checkbox and verify that it becomes enabled.
        /// </summary>
        [Test]
        public void Test_EnableCheckbox()
        {
            // Log the current page title for debugging purposes
            Console.WriteLine("Page Title: " + _dynamicControls.GetTitle());

            try
            {
                // Perform the operation to enable the checkbox
                _dynamicControls.EnableCheckbox();
                Console.WriteLine("Checkbox enable operation initiated...");

                // Use explicit wait to ensure the checkbox is enabled
                bool isCheckboxEnabled = _wait.Until(d => _dynamicControls.IsCheckboxEnabled());

                // Log and assert the checkbox state
                Console.WriteLine($"Is checkbox enabled after operation: {isCheckboxEnabled}");
                Assert.IsTrue(isCheckboxEnabled, "Checkbox should be enabled but is not.");
            }
            catch (WebDriverTimeoutException)
            {
                // Fail the test if the checkbox does not become enabled within the expected time
                Assert.Fail("Checkbox did not become enabled within the expected time.");
            }
            catch (NoSuchElementException ex)
            {
                // Fail the test if there is an issue with finding the checkbox element
                Assert.Fail($"Failed due to missing element: {ex.Message}");
            }
        }

        /// <summary>
        /// Test case to disable the checkbox and verify that it becomes disabled.
        /// </summary>
        [Test]
        public void Test_DisableCheckbox()
        {
            // Log the current title for debugging purposes
            Console.WriteLine("Page Title: " + _dynamicControls.GetTitle());

            // Perform the operation to disable the checkbox
            _dynamicControls.DisableCheckbox();

            // Wait for the checkbox to be disabled and check its "disabled" attribute
            var checkbox = _driver.FindElement(By.Id("checkbox"));
            var isCheckboxDisabled = checkbox.GetAttribute("disabled") != null;

            // Assert that the checkbox is disabled
            Assert.IsFalse(isCheckboxDisabled, "Checkbox should be disabled but is not.");
        }
    }
}
