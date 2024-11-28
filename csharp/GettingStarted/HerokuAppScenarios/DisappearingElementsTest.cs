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
        DisappearingElements disappearingElements;

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
        /// Test to validate that the menu items are visible and retrievable.
        /// </summary>
        [Test]
        public void ValidateMenuItems()
        {
            // Get the list of visible menu items.
            List<string> menuItems = disappearingElements.GetMenuItems();

            // Assert that the menu items list is not null or empty.
            Assert.IsNotNull(menuItems, "Menu items list is null.");
            Assert.IsNotEmpty(menuItems, "No menu items are visible.");
            Console.WriteLine("Menu items visible: " + string.Join(", ", menuItems));
        }

        /// <summary>
        /// Test to validate the dynamic behavior of the menu items (appearance/disappearance).
        /// Refreshes the page multiple times to check for changes.
        /// </summary>
        [Test]
        public void ValidateDynamicElementAppearance()
        {
            // Variable to track if an extra menu item is observed.
            bool foundExtraItem = false;

            // Refresh the page multiple times to check for dynamic changes in the menu.
            for (int i = 0; i < 5; i++)
            {
                disappearingElements.RefreshPage(); // Refresh the page.
                List<string> menuItems = disappearingElements.GetMenuItems(); // Retrieve menu items.

                // Check if more than the usual 4 menu items are present.
                if (menuItems.Count > 4)
                {
                    foundExtraItem = true;
                    Console.WriteLine("Extra menu item appeared: " + string.Join(", ", menuItems));
                    break;
                }
            }

            // Assert that at least one extra menu item appeared.
            Assert.IsTrue(foundExtraItem, "No extra menu item appeared after multiple refreshes.");
        }

        /// <summary>
        /// Test to validate navigation or action triggered by clicking a menu item.
        /// Verifies that clicking "Home" works as expected.
        /// </summary>
        [Test]
        public void ValidateClickOnMenuItem()
        {
            // Specify the menu item to click (e.g., 'Home').
            string menuItem = "Home";

            // Perform the click action.
            disappearingElements.ClickMenuItem(menuItem);

            // Assert that the page navigated successfully by verifying the title.
            string title = disappearingElements.getTitle();
            Assert.AreEqual("The Internet", title, "Navigation to 'Home' failed.");
        }
    }
}

