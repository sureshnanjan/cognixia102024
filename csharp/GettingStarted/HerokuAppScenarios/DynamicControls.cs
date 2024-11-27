using System;
using HerokuAppWebdriverAdapter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HerokuAppScenarios
{
    /// <summary>
    /// NUnit test class for verifying dynamic controls operations on the HerokuApp.
    /// </summary>
    [TestFixture]
    public class DynamicControlsTests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private DynamicControlsPage _dynamicControls;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_controls");
            _dynamicControls = new DynamicControlsPage(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void Test_GetTitle()
        {
            // Verify the page title
            string title = _dynamicControls.GetTitle();
            Assert.AreEqual("Dynamic Controls", title, "The title should match 'Dynamic Controls'.");
        }

        [Test]
    
        public void Test_EnableCheckbox()
        {
            // Log the current page title for debugging
            Console.WriteLine("Page Title: " + _dynamicControls.GetTitle());

            try
            {
                // Perform the enable checkbox operation
                _dynamicControls.EnableCheckbox();
                Console.WriteLine("Checkbox enable operation initiated...");

                // Use an explicit wait to ensure the checkbox is enabled
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
                bool isCheckboxEnabled = wait.Until(d => _dynamicControls.IsCheckboxEnabled());

                // Log and assert the checkbox state
                Console.WriteLine($"Is checkbox enabled after operation: {isCheckboxEnabled}");
                Assert.IsTrue(isCheckboxEnabled, "Checkbox should be enabled but is not.");
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Fail("Checkbox did not become enabled within the expected time.");
            }
            catch (NoSuchElementException ex)
            {
                Assert.Fail($"Failed due to missing element: {ex.Message}");
            }
        }


        [Test]
        public void Test_DisableCheckbox()
        {
            // Log the current title for debugging
            Console.WriteLine("Page Title: " + _dynamicControls.GetTitle());

            // Perform the disable checkbox operation
            _dynamicControls.DisableCheckbox();

            // Wait for the checkbox to be disabled (use GetAttribute to check "disabled")
            var checkbox = _driver.FindElement(By.Id("checkbox"));
            var isCheckboxDisabled = checkbox.GetAttribute("disabled") != null;

            // Assert checkbox is disabled
            Assert.IsFalse(isCheckboxDisabled, "Checkbox should be disabled but is not.");
        }



    }
}
