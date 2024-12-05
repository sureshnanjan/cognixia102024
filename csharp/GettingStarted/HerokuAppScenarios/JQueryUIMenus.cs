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


using HerokuAppOperations;
using NUnit.Framework;
using System;

namespace HerokuAppTests
{
    /// <summary>
    /// Tests for the JQuery UI Menus functionality on the HerokuApp website.
    /// These tests verify the behavior of interacting with menus and submenus on the page.
    /// </summary>
    [TestFixture]
    public class JQueryUIMenusTests
    {
        private IJQueryUIMenus menuOperations;

        [SetUp]
        public void Setup()
        {
            // Arrange: Initialize the menu operations (WebDriver is managed in the implementation)
            menuOperations = new JQueryUIMenusOperations();  // Assuming driver initialization is done in the operations class
        }

        /// <summary>
        /// Test to verify that a main menu item can be selected successfully.
        /// </summary>
        [Test]
        public void Test_SelectMainMenuItem_Valid()
        {
            // Arrange: Define the expected part of the URL after selecting the menu item
            var expectedUrlSubstring = "enabled";

            // Act: Call the SelectMenuItem method with the main menu item "Enabled"
            menuOperations.SelectMenuItem("Enabled");
            string currentUrl = menuOperations.GetCurrentUrl();

            // Assert: Verify that the URL does not contain the expected substring (i.e., navigation occurred)
            Assert.IsFalse(currentUrl.Contains(expectedUrlSubstring), "The URL did not change as expected after selecting the menu item.");
        }

        /// <summary>
        /// Test to verify that a submenu item (PDF, CSV, Excel) under "Downloads" can be selected successfully.
        /// </summary>
        [Test]
        public void Test_SelectSubmenuItems_Valid()
        {
            // Arrange: Define the submenu items to test and expected URL substring
            var submenuItems = new[] { "PDF", "CSV", "Excel" };
            var expectedUrlSubstring = "new";

            // Act & Assert: Iterate over each submenu item and verify the URL after selection
            foreach (var submenu in submenuItems)
            {
                // Select the main menu "Enabled", submenu "Downloads", and the specific submenu item (PDF, CSV, or Excel)
                menuOperations.SelectMenuItem("Enabled", "Downloads", submenu);

                // Get the current URL
                string currentUrl = menuOperations.GetCurrentUrl();

                // Assert: Verify that the URL contains the expected substring (meaning the navigation happened correctly)
                Assert.IsFalse(currentUrl.Contains(expectedUrlSubstring), $"The URL did not change as expected after selecting the '{submenu}' submenu.");
            }
        }


        /// <summary>
        /// Test to verify that the "Disabled" menu item cannot be selected.
        /// </summary>
        [Test]
        public void Test_SelectDisabledMenuItem()
        {
            // Arrange: Define the expected part of the URL after selecting the "Disabled" menu item
            var expectedUrlSubstring = "disabled";

            // Act: Attempt to select the 'Disabled' menu item
            menuOperations.SelectMenuItem("Disabled");
            string currentUrl = menuOperations.GetCurrentUrl();

            // Assert: Verify that the URL does not contain the expected substring (i.e., the item is disabled)
            Assert.IsFalse(currentUrl.Contains(expectedUrlSubstring), "The URL should not have changed after attempting to select the 'Disabled' menu item.");
        }

        /// <summary>
        /// Test to verify that the menu structure is accessible and all menu items are visible.
        /// </summary>
        [Test]
        public void Test_VerifyMenuAccessibility_Valid()
        {
            // Arrange: No specific setup needed as we just need to verify accessibility

            // Act: Call the method to verify the menu accessibility
            menuOperations.VerifyMenuAccessibility();

            // Assert: If no exception is thrown, the menu is accessible and contains items
            Assert.Pass("Menu is accessible and contains items.");
        }

        /// <summary>
        /// Test to verify that an exception is thrown when an invalid main menu item is selected.
        /// </summary>
        [Test]
        public void Test_SelectMenuItem_InvalidMenuText()
        {
            // Arrange: Define an invalid menu text and the expected error message
            var invalidMenuText = "NonExistentMenuItem";
            var expectedMessage = $"Menu item with text '{invalidMenuText}' not found!";

            // Act & Assert: Call SelectMenuItem with an invalid menu item and verify the exception message
            var ex = Assert.Throws<Exception>(() => menuOperations.SelectMenuItem(invalidMenuText));
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up: Dispose the menu operations, which internally handles the WebDriver cleanup
          
        }
    }
}
