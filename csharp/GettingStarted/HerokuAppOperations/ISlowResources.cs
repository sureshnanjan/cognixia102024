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
    /// Interface for interacting with the Slow Resources page on the HerokuApp website.
    /// Defines methods for retrieving information about the header, title, content,
    /// and network responses from the page, including functionality to handle slow-loading resources.
    /// </summary>
    public interface ISlowResources
    {
        /// <summary>
        /// Navigates to the Slow Resources page.
        /// This method is responsible for loading the Slow Resources page in the browser
        /// and preparing it for further interactions.
        /// </summary>
        void NavigateToPage();

        /// <summary>
        /// Retrieves the title of the Slow Resources page.
        /// This method fetches the content of the <title> HTML tag for the current page.
        /// </summary>
        /// <returns>The title of the page as a string.</returns>
        string GetPageTitle();

        /// <summary>
        /// Retrieves the header text from the Slow Resources page.
        /// This method extracts the content of the header element (typically a <h1> or <h2>) on the page.
        /// </summary>
        /// <returns>The header text of the page as a string.</returns>
        string GetHeaderText();

        /// <summary>
        /// Waits for the content to load on the page and retrieves it after the specified timeout.
        /// This method helps in ensuring that slow-loading resources have completed loading
        /// before attempting to interact with the content of the page.
        /// </summary>
        /// <param name="timeoutInSeconds">The maximum number of seconds to wait for the content to load.</param>
        /// <returns>The content of the page after loading as a string.</returns>
        string GetContentAfterLoading(int timeoutInSeconds);

        /// <summary>
        /// Tracks network responses for slow resources, particularly focusing on long-running GET requests.
        /// This method can be used to monitor network traffic and identify delays in fetching resources.
        /// </summary>
        /// <param name="url">The URL to monitor for network responses.</param>
        /// <returns>A dynamic object containing the network response data, such as status, headers, and timings.</returns>
        dynamic GetNetworkResponse(string url);

        /// <summary>
        /// Closes the browser session.
        /// This method shuts down the browser and cleans up any resources associated with it.
        /// </summary>
        void CloseBrowser();

        /// <summary>
        /// Retrieves the current URL of the page being viewed in the browser.
        /// This can be used to check the current location on the website or to verify if navigation has occurred correctly.
        /// </summary>
        /// <returns>The current URL as a string.</returns>
        string GetCurrentUrl();

        /// <summary>
        /// Retrieves the content of the page excluding any slow-loading resources.
        /// This method is designed to fetch the page content quickly without waiting for long-running or slow resources.
        /// </summary>
        /// <returns>The page content as a string, excluding slow resources.</returns>
        string GetContentWithoutSlowResources();

        /// <summary>
        /// Tracks network responses for slow resources with a specified timeout period.
        /// This method allows monitoring of network traffic and long-running requests while accounting for timeouts.
        /// </summary>
        /// <param name="url">The URL to monitor for network responses.</param>
        /// <param name="timeout">The timeout period in milliseconds for waiting for network responses.</param>
        /// <returns>A dynamic object containing the network response data, such as status, headers, and timings.</returns>
        object GetNetworkResponseWithTimeout(string url, int timeout);

        /// <summary>
        /// Waits for content to load on the page and retrieves it without a specified timeout.
        /// This method can be useful when you want to wait indefinitely for content to load.
        /// </summary>
        /// <returns>The content of the page after loading as a string.</returns>
        string GetContentAfterLoading();
    }
}
