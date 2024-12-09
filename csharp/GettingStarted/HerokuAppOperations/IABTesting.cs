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

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for interacting with the A/B Test functionality on the Heroku app.
    /// Defines methods to retrieve the A/B Test message and the current page URL.
    /// </summary>
    public interface IABTest
    {
        //public void OptInABTest();
        //public void OptOutABTest();
        /// <summary>
        /// Method to get the text of the A/B Test message.
        /// </summary>
        /// <returns>The message displayed for the A/B Test.</returns>
        public string GetABTestMessage();

        /// <summary>
        /// Method to get the URL of the current page.
        /// </summary>
        /// <returns>The current URL of the page.</returns>
        public string GetCurrentUrl();
        void QuitDriver();
    }
}
