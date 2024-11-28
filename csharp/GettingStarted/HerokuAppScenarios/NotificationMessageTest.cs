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

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test suite for validating the functionality of the Notification Message page.
    /// Includes tests for verifying the appearance and dynamic nature of notification messages.
    /// </summary>
    [TestFixture]
    public class NotificationMessageTests
    {
        // Instance of the NotificationMessage class to interact with the page.
        NotificationMessage notificationMessage;

        /// <summary>
        /// Setup method to initialize test dependencies.
        /// This method runs before each test case.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize the NotificationMessage instance.
            notificationMessage = new NotificationMessage();
        }

        /// <summary>
        /// Test to validate that a notification message appears when the "Click here" link is clicked.
        /// </summary>
        [Test]
        public void ValidateNotificationMessageAppears()
        {
            // Trigger a notification message by clicking the link.
            notificationMessage.ClickHere();

            // Get the displayed notification message.
            string message = notificationMessage.GetNotificationMessage();

            // Assert that a notification message is displayed.
            Assert.IsNotEmpty(message, "Notification message is not displayed.");
            Console.WriteLine($"Displayed Notification: {message}");
        }

        /// <summary>
        /// Test to validate that multiple notifications show dynamic messages.
        /// Ensures the messages change after multiple clicks.
        /// </summary>
        [Test]
        public void ValidateMultipleNotifications()
        {
            // Store the previous notification message for comparison.
            string previousMessage = string.Empty;
            bool differentMessageFound = false;

            // Click the "Click here" link multiple times to observe changes in the notification message.
            for (int i = 0; i < 5; i++) // Try clicking multiple times to observe dynamic messages.
            {
                notificationMessage.ClickHere(); // Trigger a notification message.
                string currentMessage = notificationMessage.GetNotificationMessage(); // Retrieve the current message.
                Console.WriteLine($"Notification {i + 1}: {currentMessage}");

                // Check if a new message different from the previous one is found.
                if (!string.IsNullOrEmpty(previousMessage) && !currentMessage.Equals(previousMessage))
                {
                    differentMessageFound = true;
                    break;
                }

                // Update the previous message for the next iteration.
                previousMessage = currentMessage;
            }

            // Assert that at least one dynamic message was found.
            Assert.IsTrue(differentMessageFound, "No dynamic notification message was found.");
        }
    }
}