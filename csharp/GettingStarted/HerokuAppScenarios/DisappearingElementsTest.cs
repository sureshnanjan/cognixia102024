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
*/

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HerokuAppWebdriverAdapter;
using System.Collections.Generic;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test suite for validating the functionality of the Disappearing Elements page.
    /// Includes tests for verifying menu items, their dynamic behavior, and navigation.
    /// </summary>
    [TestFixture]
    public class DisappearingElementsTests
    {
        // Instance of the DisappearingElements class to interact with the page.
        private DisappearingElements disappearingElements;

        /// <summary>
        /// Setup method to initialize test dependencies.
        /// This method runs before each test case.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize the DisappearingElements instance.
            disappearingElements = new DisappearingElements();
        }

        /// <summary>
        /// TearDown method to clean up after each test case.
        /// This method runs after each test case.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Quit the browser to release resources.
            disappearingElements.Quit();
        }

        /// <summary>
        /// Test to validate that the menu items are visible and retrievable.
        /// </summary>
        [Test]
        public void ValidateMenuItems()
        {
            // Arrange: Prepare to retrieve menu items.

            // Act: Get the list of visible menu items.
            List<string> menuItems = disappearingElements.GetMenuItems();

            // Assert: Verify the menu items list is not null or empty.
            Assert.IsNotNull(menuItems, "Menu items list is null.");
            Assert.IsNotEmpty(menuItems, "No menu items are visible.");
            Console.WriteLine("Menu items visible: " + string.Join(", ", menuItems));
        }

        /// <summary>
        /// Test to validate the dynamic behavior of the menu items (appearance/disappearance).
        /// </summary>
        [Test]
        public void ValidateDynamicElementAppearance()
        {
            // Arrange: Prepare for dynamic behavior validation.
            bool foundExtraItem = false;

            // Act: Refresh the page multiple times to check for changes in the menu items.
            Random random = new Random();
            int min = 1;
            int max = 100;
            int randomNumber = random.Next(min, max + 1);
            for (int i = 0; i < randomNumber; i++)
            {
                disappearingElements.RefreshPage();
                List<string> menuItems = disappearingElements.GetMenuItems();

                if (menuItems.Count > 4) // Check if an extra menu item appeared.
                {
                    foundExtraItem = true;
                    Console.WriteLine("Extra menu item appeared: " + string.Join(", ", menuItems));
                    break;
                }
            }

            // Assert: Verify that at least one extra menu item appeared.
            Assert.IsTrue(foundExtraItem, "No extra menu item appeared after multiple refreshes.");
        }

        /// <summary>
        /// Test to validate navigation or action triggered by clicking a menu item.
        /// Verifies that clicking "Home" works as expected.
        /// </summary>
        [Test]
        public void ValidateClickOnMenuItem()
        {
            // Arrange: Specify the menu item to click.
            string menuItem = "Home";

            // Act: Perform the click action and retrieve the page title.
            disappearingElements.ClickMenuItem(menuItem);
            string actualTitle = disappearingElements.GetTitle();
            string expectedTitle = "The Internet";

            // Assert: Verify the page navigated successfully by checking the title.
            Assert.AreEqual(expectedTitle, actualTitle, "Navigation to 'Home' failed.");
        }

        /// <summary>
        /// Test to validate the page title.
        /// </summary>
        [Test]
        public void ValidatePageTitle()
        {
            // Arrange: Prepare the expected page title.
            string expectedTitle = "Disappearing Elements";

            // Act: Retrieve the actual page title.
            string actualTitle = disappearingElements.GetpageTitle();

            // Assert: Verify the page title matches the expected title.
            Assert.AreEqual(expectedTitle, actualTitle, "Page title mismatch.");
        }

        /// <summary>
        /// Test to validate the page description.
        /// </summary>
        [Test]
        public void ValidatePageDescription()
        {
            // Arrange: Prepare the expected page description.
            string expectedDescription = "This example demonstrates when elements on a page change by disappearing/reappearing on each page load.";

            // Act: Retrieve the actual page description.
            string actualDescription = disappearingElements.GetDescription();

            // Assert: Verify the page description matches the expected description.
            Assert.AreEqual(expectedDescription, actualDescription, "Page description mismatch.");
        }
    }
}


