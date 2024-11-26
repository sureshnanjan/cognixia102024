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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for interacting with the notification message system on the HerokuApp website.
    /// Defines methods for triggering, retrieving, validating, and clearing notification messages.
    /// </summary>
    public interface INotificationMessage
    {
        /// <summary>
        /// Clicks the notification link to trigger a new message.
        /// This method should contain the logic to simulate a click action on the notification link,
        /// which will generate a new notification message.
        /// </summary>
        void ClickNotificationLink();

        /// <summary>
        /// Retrieves the current notification message text.
        /// This method should return the text of the current notification message as a string.
        /// </summary>
        /// <returns>The text of the notification message.</returns>
        string GetNotificationMessage();

        /// <summary>
        /// Verifies if the notification message matches one of the expected values.
        /// This method should take an array of expected notification messages and check if the current
        /// notification message matches any of these expected values.
        /// </summary>
        /// <param name="expectedMessages">An array of expected notification messages.</param>
        /// <returns>True if the notification message matches any expected value; otherwise, false.</returns>
        bool IsNotificationMessageValid(string[] expectedMessages);

        /// <summary>
        /// Clears the current notification message, if applicable.
        /// This method should contain the logic to clear or dismiss the current notification message.
        /// </summary>
        void ClearNotificationMessage();
    }
}