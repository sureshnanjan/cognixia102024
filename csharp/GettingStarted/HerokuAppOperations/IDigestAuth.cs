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
    /// Interface representing the operations for interacting with the Digest Authentication page.
    /// Provides methods to authenticate using credentials and retrieve the success message.
    /// </summary>
    public interface IDigestAuth
    {
        /// <summary>
        /// Method to perform authentication by navigating to the page with embedded credentials in the URL.
        /// </summary>
        /// <param name="username">The username to authenticate.</param>
        /// <param name="password">The password associated with the username.</param>
        public void Authenticate(string username, string password);

        /// <summary>
        /// Method to retrieve the success message displayed after authentication.
        /// </summary>
        /// <returns>A string representing the success message if found, or a fallback message if not.</returns>
        public string GetSuccessMessage();
        public string GetPageDescription();
        public string GetPageTitle();
    }
}
