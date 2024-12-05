/*
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
 
  http://www.apache.org/licenses/LICENSE-2.0
 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.
*/using HerokuAppOperations;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for the Shifting Content example page.
    /// Contains tests to validate menu items, detect shifting behavior, and verify navigation.
    /// </summary>
    [TestFixture]
    public class ShiftingContentTests
    {
        private IWebDriver driver;
        private ShiftingContentOperations shiftingContentOperations;

        /// <summary>
        /// Setup method to initialize WebDriver and the ShiftingContentOperations instance.
        /// This runs before each test to prepare the environment.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // Arrange: Initialize the WebDriver (Chrome in this case)
            driver = new ChromeDriver();
            shiftingContentOperations = new ShiftingContentOperations(driver);
        }

        /// <summary>
        /// Test case to verify that the menu items are loaded correctly on the Shifting Content page.
        /// The method VerifyMenuItems() is invoked and should not throw any exception if the menu items are visible.
        /// </summary>
        [Test]
        public void VerifyMenuItems_ShouldDisplayMenuItems()
        {
            // Act: Verify that menu items are loaded correctly
            // Assert: No exception should be thrown if the menu items are visible
            Assert.DoesNotThrow(() => shiftingContentOperations.VerifyMenuItems(), "Menu items are not displayed properly.");
        }

        /// <summary>
        /// Test case to verify that navigation to a specific menu item works correctly.
        /// The method NavigateToMenuItem() is invoked with a sample menu item text,
        /// and then it checks whether the current URL contains the expected menu item.
        /// </summary>
        [Test]
        public void NavigateToMenuItem_ShouldNavigateToTheCorrectPage()
        {
            // Arrange: Prepare the menu item text to navigate
            string menuItemText = "Shifting Content: Menu Element"; // Ensure this matches the printed text exactly

            // Act: Navigate to the specific menu item
            Assert.DoesNotThrow(() => shiftingContentOperations.NavigateToMenuItem(menuItemText), $"Navigation to '{menuItemText}' failed.");

            // Assert: Check the page header matches the expected menu item text
            var pageHeader = driver.FindElement(By.CssSelector("h3"));
            Assert.AreEqual(menuItemText, pageHeader.Text, $"Navigation did not lead to the expected page for '{menuItemText}'. The header text is '{pageHeader.Text}' instead.");
        }

        /// <summary>
        /// Test case to check if the page detects shifting behavior of menu items correctly.
        /// The method CheckShiftingBehavior() is invoked to simulate a page refresh and compare the positions of the menu items before and after the refresh.
        /// </summary>
        [Test]
        public void CheckShiftingBehavior_ShouldDetectShiftingWhenContentChanges()
        {
            // Act: Check for shifting behavior in the menu items
            // Assert: No exception should be thrown for shifting detection
            Assert.DoesNotThrow(() => shiftingContentOperations.CheckShiftingBehavior(), "Shifting behavior detected in the menu items.");
        }

        /// <summary>
        /// Test case to verify that the current URL is returned correctly.
        /// The method GetCurrentUrl() is invoked, and the current URL should match the expected URL of the Shifting Content page.
        /// </summary>
        [Test]
        public void GetCurrentUrl_ShouldReturnCorrectUrl()
        {
            // Arrange: Prepare expected URL and navigate to the Shifting Content page
            string expectedUrl = "https://the-internet.herokuapp.com/shifting_content/menu";
            driver.Navigate().GoToUrl(expectedUrl);

            // Act: Get the current URL
            string currentUrl = shiftingContentOperations.GetCurrentUrl();

            // Assert: Validate that the current URL matches the expected URL
            Assert.AreEqual(expectedUrl, currentUrl, "The current URL is not correct.");
        }

        /// <summary>
        /// Tear down method to close the WebDriver instance after each test.
        /// This ensures that the browser is closed and resources are released after every test.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Cleanup: Close and dispose of the WebDriver after the test
            shiftingContentOperations.CleanUp();
        }
    }
}
