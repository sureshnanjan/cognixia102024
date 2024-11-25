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
    /// Interface for interacting with the Slow Resources page on the HerokuApp website.
    /// Defines methods for retrieving information about the header and content of the page, including waiting for slow-loading content.
    /// </summary>
    public interface ISlowResources
    {
        /// <summary>
        /// Retrieves the header text from the Slow Resources page.
        /// </summary>
        /// <returns>A string representing the header text of the page.</returns>
        string GetHeaderText();

        /// <summary>
        /// Waits for the content to load and retrieves the content text after loading.
        /// </summary>
        /// <param name="timeoutInSeconds">The time to wait for the content to load (in seconds).</param>
        /// <returns>A string representing the content text of the page after it has loaded.</returns>
        string GetContentAfterLoading(int timeoutInSeconds);
    }
}