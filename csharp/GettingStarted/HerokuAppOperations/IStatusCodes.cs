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
        /// This method will take the user to a page that corresponds to the given status code.
        /// The page will show information about the specific status code (e.g., 200 OK, 404 Not Found).
        /// </summary>
        /// <param name="code">The HTTP status code to navigate to (e.g., "200", "404").</param>
        void NavigateToStatusCode(string code);

        /// <summary>
        /// Retrieves the header text displayed on the Status Codes page.
        /// This is the main heading or title of the page, which usually gives context for the status code displayed on that page.
        /// </summary>
        /// <returns>A string representing the header text of the page.</returns>
        string GetPageHeader();

        /// <summary>
        /// Retrieves the descriptive text of the HTTP status code displayed on the page.
        /// This method returns a string that describes the status code, such as "OK" for 200 or "Not Found" for 404.
        /// </summary>
        /// <returns>A string representing the description of the HTTP status code.</returns>
        string GetStatusCodeText();

        /// <summary>
        /// Retrieves the title of the page.
        /// This method returns the title of the page, typically found in the <title> tag of the HTML, which represents the status code's page title.
        /// </summary>
        /// <returns>A string representing the title of the page.</returns>
        string GetPageTitle();

        /// <summary>
        /// Retrieves the error message displayed on the page, if any.
        /// This method returns an error message that may be shown when a particular status code page indicates an issue, such as a 404 error message.
        /// </summary>
        /// <returns>A string representing any error message displayed on the page.</returns>
        string GetErrorMessage();

        /// <summary>
        /// Retrieves the HTTP status code from the page.
        /// This method returns the status code, represented as a double, which corresponds to the status of the HTTP response.
        /// </summary>
        /// <returns>A double representing the HTTP status code.</returns>
        double GetHttpStatusCode();
    }
}
