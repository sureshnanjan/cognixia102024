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
using OpenQA.Selenium;

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface defining the actions that can be performed on the "Download Secure" page.
    /// Implementing this interface ensures that the methods for interacting with the page are available.
    /// </summary>
    public interface IDownloadSecurePage
    {
        /// <summary>
        /// Gets the title of the "Download Secure" page.
        /// </summary>
        /// <returns>The title of the page.</returns>
        string GetPageTitle();

        /// <summary>
        /// Checks if the download link is visible on the page.
        /// </summary>
        /// <returns>True if the download link is visible, otherwise false.</returns>
        bool IsDownloadLinkVisible();

        /// <summary>
        /// Clicks the download link to initiate the file download.
        /// </summary>
        void ClickDownloadLink();
    }
}
