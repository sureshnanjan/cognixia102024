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
using OpenQA.Selenium;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test suite for validating Floating Menu functionality on the HerokuApp website.
    /// </summary>
    [TestFixture]
    public class FloatingMenuTests
    {
        private FloatingMenu floatingMenu;

        /// <summary>
        /// Sets up the test environment before each test.
        /// </summary>
        [SetUp]
        public void Setup()
        {

            floatingMenu = new FloatingMenu();
        }

        /// <summary>
        /// Cleans up after each test.
        /// </summary>
        [TearDown]
        public void Teardown()
        {
            floatingMenu.Close();
        }

        [Test]
        public void Title()
        {
            // Arrange: Navigate to the Floating Menu page.
            floatingMenu.NavigateToFloatingMenuPage();

            // Act: Retrieve the page title.
            string actualTitle = floatingMenu.GetPageTitle(); // Assuming this is implemented as a utility in base class.
            string expectedTitle = "Floating Menu";

            // Assert: Verify that the title matches the expected page title.
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        

        /// <summary>
        /// Test: Verify that the floating menu is visible when the page is loaded.
        /// Description: Ensures that the floating menu is displayed upon loading the page.
        /// </summary>
        [Test]
        public void VerifyFloatingMenuIsVisibleOnPageLoad()
        {
            // Arrange: Navigate to the Floating Menu page.
            floatingMenu.NavigateToFloatingMenuPage();

            // Act: Check if the floating menu is visible.
            bool isVisible = floatingMenu.IsFloatingMenuVisible();

            // Assert: Verify that the floating menu is visible.
            Assert.IsTrue(isVisible, "Floating menu is not visible on page load.");
        }

        /// <summary>
        /// Test: Verify that the floating menu remains visible after scrolling to the bottom of the page.
        /// Description: Confirms that the floating menu stays visible when scrolling down.
        /// </summary>
        [Test]
        public void VerifyFloatingMenuVisibilityAfterScrolling()
        {
            // Arrange: Navigate to the Floating Menu page.
            floatingMenu.NavigateToFloatingMenuPage();

            // Act: Simulate scrolling and check menu visibility.
            bool isVisibleAfterScroll = floatingMenu.VerifyMenuVisibilityAfterScroll();

            // Assert: Verify that the floating menu is visible after scrolling.
            Assert.IsTrue(isVisibleAfterScroll, "Floating menu is not visible after scrolling.");
        }

        /// <summary>
        /// Test: Verify menu remains visible after partial scroll.
        /// Description: Ensures the menu is visible when the user scrolls halfway through the page.
        /// </summary>
        [Test]
        public void VerifyFloatingMenuVisibilityAfterPartialScroll()
        {
            // Arrange: Navigate to the Floating Menu page.
            floatingMenu.NavigateToFloatingMenuPage();

            // Act: Simulate partial scrolling.
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)floatingMenu.driver;
            jsExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight / 2);");

            // Verify menu visibility.
            bool isVisibleAfterPartialScroll = floatingMenu.IsFloatingMenuVisible();

            // Assert: Confirm the menu is visible after partial scrolling.
            Assert.IsTrue(isVisibleAfterPartialScroll, "Floating menu is not visible after partial scrolling.");
        }

        /// <summary>
        /// Test: Verify menu remains visible when scrolling up after scrolling to the bottom.
        /// Description: Ensures the floating menu remains visible when the user scrolls back to the top after reaching the bottom.
        /// </summary>
        [Test]
        public void VerifyFloatingMenuVisibilityWhenScrollingUp()
        {
            // Arrange: Navigate to the Floating Menu page.
            floatingMenu.NavigateToFloatingMenuPage();

            // Act: Scroll to the bottom and then back to the top.
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)floatingMenu.driver;
            jsExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            jsExecutor.ExecuteScript("window.scrollTo(0, 0);");

            // Verify menu visibility.
            bool isVisibleAfterScrollUp = floatingMenu.IsFloatingMenuVisible();

            // Assert: Confirm the menu is visible after scrolling up.
            Assert.IsTrue(isVisibleAfterScrollUp, "Floating menu is not visible after scrolling back to the top.");
        }

        /// <summary>
        /// Test: Verify floating menu functionality under rapid scrolls.
        /// Description: Simulates rapid scrolling and verifies the menu remains visible throughout.
        /// </summary>
        [Test]
        public void VerifyFloatingMenuVisibilityUnderRapidScrolls()
        {
            // Arrange: Navigate to the Floating Menu page.
            floatingMenu.NavigateToFloatingMenuPage();

            // Act: Simulate rapid scrolling up and down.
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)floatingMenu.driver;
            for (int i = 0; i < 5; i++)
            {
                jsExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                jsExecutor.ExecuteScript("window.scrollTo(0, 0);");
            }

            // Verify menu visibility after rapid scrolling.
            bool isVisibleAfterRapidScroll = floatingMenu.IsFloatingMenuVisible();

            // Assert: Confirm the menu remains visible during rapid scrolling.
            Assert.IsTrue(isVisibleAfterRapidScroll, "Floating menu is not visible after rapid scrolling.");
        }
    }
}
