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

using System;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents the Notification Message page on the HerokuApp website.
    /// Provides functionality to interact with the page and retrieve notification messages.
    /// </summary>
    public class NotificationMessage : HerokuAppCommon, INotificationMessage
    {
        // Locator for the "Click here" link on the page
        private readonly By clickHereLink = By.XPath("//a[text()='Click here']");

        // Locator for the notification message element on the page
        private readonly By notificationMessageLocator = By.Id("flash");

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationMessage"/> class.
        /// Navigates to the Notification Message page.
        /// </summary>
        public NotificationMessage() : base()
        {
            // Navigate to the notification message rendered page
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/notification_message_rendered");
        }

        /// <summary>
        /// Clicks the "Click here" link to trigger the notification message.
        /// </summary>
        public void ClickHere()
        {
            try
            {
                // Attempt to find and click the "Click here" link
                driver.FindElement(clickHereLink).Click();
            }
            catch (NoSuchElementException)
            {
                // Handle the case when the link is not found
                Console.WriteLine("The 'Click here' link is not found.");
            }
        }

        /// <summary>
        /// Retrieves the text of the current notification message.
        /// </summary>
        /// <returns>The notification message text as a string.</returns>
        public string GetNotificationMessage()
        {
            try
            {
                // Attempt to find the notification message element
                var notificationElement = driver.FindElement(notificationMessageLocator);
                // Return the notification message text after trimming extra spaces or newlines
                return notificationElement.Text.Trim();
            }
            catch (NoSuchElementException)
            {
                // Handle the case when no notification message is displayed
                return "No notification message displayed.";
            }
        }

        /// <summary>
        /// Refreshes the page.
        /// </summary>
        public void RefreshPage()
        {
            // Refresh the browser page
            driver.Navigate().Refresh();
        }
    }
}
