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
*/using System;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using NUnit.Framework;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for the Shifting Content example page.
    /// Contains tests to validate menu items, detect shifting behavior, and verify navigation.
    /// </summary>
    [TestFixture]
    public class ShiftingContentTests
    {
        private HomePage _page; // The homepage instance used for navigation
        private IShiftingContent _shiftingContent; // The Shifting Content page object

        /// <summary>
        /// Set up the environment for each test.
        /// Initializes the homepage and navigates to the Shifting Content page.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // Initialize the homepage and navigate to the Shifting Content page
            _page = new HomePage();
            _shiftingContent = _page.navigateToExample("ShiftingContent") as IShiftingContent;
        }

        /// <summary>
        /// Test to verify all expected menu items are present and visible on the page.
        /// </summary>
        [Test]
        public void VerifyMenuItemsLoaded()
        {
            Assert.NotNull(_shiftingContent, "ShiftingContent page did not load correctly.");

            // Verify the menu items without throwing an exception
            Assert.DoesNotThrow(() => _shiftingContent.VerifyMenuItems(), "Menu item validation failed.");
        }

        /// <summary>
        /// Test to verify navigation to a specific menu item.
        /// </summary>
        [Test]
        public void NavigateToSpecificMenuItem()
        {
            Assert.NotNull(_shiftingContent, "ShiftingContent page did not load correctly.");

            // Define the target menu item to navigate to
            string targetMenuItem = "Home";

            // Navigate and ensure no exception is thrown
            Assert.DoesNotThrow(() => _shiftingContent.NavigateToMenuItem(targetMenuItem), $"Failed to navigate to {targetMenuItem}.");

            // Verify the resulting URL contains the expected path
            string currentUrl = _shiftingContent.GetCurrentUrl();
            Assert.IsTrue(currentUrl.Contains("home"), $"Expected URL to contain 'home', but got {currentUrl}.");
        }

        /// <summary>
        /// Test to detect unexpected shifting behavior in the menu items.
        /// </summary>
        [Test]
        public void DetectShiftingBehavior()
        {
            Assert.NotNull(_shiftingContent, "ShiftingContent page did not load correctly.");

            // Detect shifting behavior without throwing an exception
            Assert.DoesNotThrow(() => _shiftingContent.CheckShiftingBehavior(), "Shifting behavior detected in the menu items.");
        }

    }
}
