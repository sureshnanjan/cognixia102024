// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test suite for verifying the functionality of the Key Presses page on HerokuApp.
    /// Includes tests for page title and key press behavior.
    /// </summary>
    [TestFixture]
    public class KeyPress
    {
        // WebDriver instance for interacting with the browser
        private ChromeDriver driver;

        // Page object for Key Presses functionality
        private HerokuAppWebdriverAdapter.KeyPresses keyPresses;

        /// <summary>
        /// Setup method to initialize the WebDriver and navigate to the Key Presses page.
        /// Called before each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // Initialize Chrome WebDriver
            driver = new ChromeDriver();

            // Navigate to the Key Presses page
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/key_presses");

            // Initialize the KeyPresses page object with the WebDriver
            keyPresses = new HerokuAppWebdriverAdapter.KeyPresses(driver);
        }

        /// <summary>
        /// Test to verify the page title.
        /// Ensures the title matches the expected value.
        /// </summary>
        [Test]
        public void GetTitle_ShouldReturnCorrectTitle()
        {
            // Act: Retrieve the page title
            var title = keyPresses.GetTitle();

            // Assert: Verify that the title matches the expected value
            Assert.AreEqual("The Internet", title, "Page title does not match the expected value.");
        }

        /// <summary>
        /// Test to verify that pressing a key displays the correct result.
        /// </summary>
        [Test]
        public void PressKey_ShouldDisplayCorrectKeyPressed()
        {
            // Arrange: Specify the key to press
            string keyToPress = "A";

            // Act: Press the key and retrieve the displayed result
            keyPresses.PressKey(keyToPress);
            var result = keyPresses.GetKeyPressed();

            // Assert: Check if the displayed result matches the expected output
            Assert.IsTrue(result.Contains("You entered: A"), "Key press result does not match expected output.");
        }

        /// <summary>
        /// Test to verify behavior when pressing a special character key.
        /// Ensures the result field does not display unsupported characters.
        /// </summary>
        [Test]
        public void PressKey_SpecialCharacter_ShouldDisplayCorrectKeyPressed()
        {
            // Arrange: Specify the special character to press
            string keyToPress = "!";

            // Act: Press the special character key and retrieve the displayed result
            keyPresses.PressKey(keyToPress);
            var result = keyPresses.GetKeyPressed();

            // Assert: Verify that the displayed result does not incorrectly match the special character
            Assert.IsFalse(result.Contains("You entered: !"), "Key press result for special character does not match expected output.");
        }

        /// <summary>
        /// TearDown method to close the browser and release WebDriver resources.
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
