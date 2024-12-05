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
using System;
using HerokuAppWebdriverAdapter;

namespace HerokuAppScenarios
{
    /// <summary>
    /// This class contains the test scenarios for the ContextMenu functionality.
    /// It verifies the ability to interact with the context menu and handle alerts.
    /// </summary>
    [TestFixture]
    public class ContextMenuTest
    {
        private ContextMenu contextMenu;

        /// <summary>
        /// Setup method that initializes the ContextMenu instance and prepares the browser.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // Arrange: Initialize the ContextMenu instance
            contextMenu = new ContextMenu();
        }

        /// <summary>
        /// Test to right-click on the context menu box and verify if the alert displays the correct message.
        /// </summary>
        [Test]
        public void TestRightClickAndAlertText()
        {
            // Arrange: Ensure the context menu box is ready for interaction
            // contextMenu is initialized in SetUp()

            // Act: Perform a right-click on the context menu box
            contextMenu.RightClickOnBox();

            // Act: Get the alert text after the right-click
            string alertText = contextMenu.GetAlertText();

            // Assert: Verify that the alert text matches the expected message
            Assert.AreEqual("You selected a context menu", alertText, "Alert text does not match the expected message.");
        }

        /// <summary>
        /// Test to right-click on the context menu box and accept the alert.
        /// </summary>
        [Test]
        public void TestRightClickAndAcceptAlert()
        {
            // Arrange: Ensure the context menu box is ready for interaction
            // contextMenu is initialized in SetUp()

            // Act: Perform a right-click on the context menu box
            contextMenu.RightClickOnBox();

            // Act: Get the alert text
            string alertText = contextMenu.GetAlertText();

            // Assert: Verify the expected alert text is displayed
            Assert.AreEqual("You selected a context menu", alertText, "Alert text does not match the expected message.");

            // Act: Accept the alert
            contextMenu.AcceptAlert();
        }

        /// <summary>
        /// Test to right-click on the context menu box multiple times and verify the alert message consistency.
        /// </summary>
        [Test]
        public void TestAlertTextAfterMultipleRightClicks()
        {
            // Arrange: Ensure the context menu box is ready for interaction
            // contextMenu is initialized in SetUp()

            // Act: Perform the first right-click and get the alert text
            contextMenu.RightClickOnBox();
            string firstAlertText = contextMenu.GetAlertText();

            // Assert: Verify the first alert text matches the expected message
            Assert.AreEqual("You selected a context menu", firstAlertText, "First alert text should be 'You selected a context menu'.");

            // Act: Accept the first alert
            contextMenu.AcceptAlert();

            // Act: Perform a second right-click and get the alert text
            contextMenu.RightClickOnBox();
            string secondAlertText = contextMenu.GetAlertText();

            // Assert: Verify the second alert text matches the expected message
            Assert.AreEqual("You selected a context menu", secondAlertText, "Second alert text should be 'You selected a context menu'.");

            // Act: Accept the second alert
            contextMenu.AcceptAlert();
        }

        /// <summary>
        /// Test to perform both accepting and dismissing the alert to verify alert behavior.
        /// </summary>
        [Test]
        public void TestAcceptAndDismissAlert()
        {
            // Arrange: Ensure the context menu box is ready for interaction
            // contextMenu is initialized in SetUp()

            // Act: Perform a right-click on the context menu box to trigger the alert
            contextMenu.RightClickOnBox();

            // Act: Get the alert text before accepting it
            string alertText = contextMenu.GetAlertText();

            // Assert: Verify the alert text matches the expected message
            Assert.AreEqual("You selected a context menu", alertText, "The alert text should be 'You selected a context menu'.");

            // Act: Accept the alert
            contextMenu.AcceptAlert();

            // Act: Refresh the page and perform another right-click to trigger the alert again
          //  contextMenu.RefreshPage();
            contextMenu.RightClickOnBox();

            // Act: Dismiss the alert
            contextMenu.DismissAlert();
        }

        /// <summary>
        /// Cleanup method that cleans up after the test execution.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Arrange: Clean up WebDriver resources

            // Act: Quit the WebDriver after test execution
            contextMenu.CleanUp();
        }
    }
}
