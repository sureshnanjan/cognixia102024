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
    /// Interface for interacting with the Status Codes page on the HerokuApp website.
    /// Defines methods for navigation and retrieving information about the HTTP status codes.
    /// </summary>
    public interface IStatusCodes
    {
        /// <summary>
        /// Navigates to the page for a specific HTTP status code.
        /// </summary>
        /// <param name="code">The HTTP status code to navigate to (e.g., "200", "404").</param>
        void NavigateToStatusCode(string code);

        /// <summary>
        /// Retrieves the header text displayed on the Status Codes page.
        /// </summary>
        /// <returns>A string representing the header text of the page.</returns>
        string GetPageHeader();

        /// <summary>
        /// Retrieves the descriptive text of the HTTP status code displayed on the page.
        /// </summary>
        /// <returns>A string representing the description of the HTTP status code.</returns>
        string GetStatusCodeText();
    }
}
