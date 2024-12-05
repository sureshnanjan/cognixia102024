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
using System;
using HerokuAppOperations;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test suite for validating the functionality of the Notification Message page.
    /// Includes tests for verifying the appearance and dynamic nature of notification messages.
    /// </summary>
    [TestFixture]
    public class NotificationMessageTests
    {
        private NotificationMessage notificationMessage;

        /// <summary>
        /// Setup method to initialize test dependencies.
        /// This method runs before each test case.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            notificationMessage = new NotificationMessage();
        }

        /// <summary>
        /// TearDown method to clean up after each test.
        /// This method runs after each test case.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Close the browser to clean up resources.
            notificationMessage.Quit();
        }


        /// <summary>
        /// Test to validate that a notification message appears when the "Click here" link is clicked.
        /// </summary>
        [Test]
        public void ValidateNotificationMessageAppears()
        {
            // Arrange
            string expectedMessage = "Notification message is displayed.";

            // Act
            notificationMessage.ClickHere();
            string actualMessage = notificationMessage.GetNotificationMessage();

            // Assert
            Assert.IsNotEmpty(actualMessage, $"Expected: {expectedMessage}. Actual: No message displayed.");
            Console.WriteLine($"Displayed Notification: {actualMessage}");
        }

        /// <summary>
        /// Test to validate that multiple notifications show dynamic messages.
        /// Ensures the messages change after multiple clicks.
        /// </summary>
        [Test]
        public void ValidateMultipleNotifications()
        {
            // Arrange
            string previousMessage = string.Empty;
            bool differentMessageFound = false;
            string expectedCondition = "Dynamic notification messages are displayed.";

            // Act
            Random random = new Random();
            int min = 1;
            int max = 100;
            int randomNumber = random.Next(min, max + 1);
            for (int i = 0; i < randomNumber; i++)
            {
                notificationMessage.ClickHere();
                string currentMessage = notificationMessage.GetNotificationMessage();
                Console.WriteLine($"Notification {i + 1}: {currentMessage}");

                if (!string.IsNullOrEmpty(previousMessage) && !currentMessage.Equals(previousMessage))
                {
                    differentMessageFound = true;
                    break;
                }

                previousMessage = currentMessage;
            }

            // Assert
            Assert.IsTrue(differentMessageFound, $"Expected: {expectedCondition}. Actual: Messages did not change.");
        }

        /// <summary>
        /// Test to validate the title of the Notification Message page.
        /// </summary>
        [Test]
        public void ValidatePageTitle()
        {
            // Arrange
            string expectedTitle = "Notification Message";

            // Act
            string actualTitle = notificationMessage.GetPageTitle();

            // Assert
            Assert.AreEqual(expectedTitle, actualTitle, $"Expected: {expectedTitle}. Actual: {actualTitle}.");
            Console.WriteLine($"Page Title: {actualTitle}");
        }

        /// <summary>
        /// Test to validate the description on the Notification Message page.
        /// </summary>
        [Test]
        public void ValidatePageDescription()
        {
            // Arrange
            string expectedDescription = "The message displayed above the heading is a notification message. It is often used to convey information about an action previously taken by the user.\r\n\r\nSome rudimentary examples include 'Action successful', 'Action unsuccessful, please try again', etc.\r\n\r\nClick here to load a new message.";

            // Act
            string actualDescription = notificationMessage.GetPageDescription();

            // Assert
            Assert.AreEqual(expectedDescription, actualDescription, $"Expected: {expectedDescription}. Actual: {actualDescription}.");
            Console.WriteLine($"Page Description: {actualDescription}");
        }
    }
}
