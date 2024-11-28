﻿/*
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

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface representing the operations for interacting with the Notification Message page.
    /// Provides methods to trigger notifications, retrieve the notification message, and refresh the page.
    /// </summary>
    public interface INotificationMessage
    {
        /// <summary>
        /// Method to click the "Click here" link to trigger a notification.
        /// </summary>
        public void ClickHere();

        /// <summary>
        /// Method to get the current notification message text displayed on the page.
        /// </summary>
        /// <returns>A string representing the notification message text.</returns>
        public string GetNotificationMessage();

        /// <summary>
        /// Method to refresh the page, reloading the content.
        /// </summary>
        public void RefreshPage();
    }
}
