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
    /// Defines operations related to managing and interacting with browser windows.
    /// </summary>
    public interface IWindowOperations
    {
        /// <summary>
        /// Opens a new browser window by triggering a link click.
        /// </summary>
        /// <remarks>
        /// This method assumes that a clickable link exists in the current browser context 
        /// that triggers the opening of a new window.
        /// </remarks>
        public void OpenNewWindow();

        /// <summary>
        /// Switches the focus of the WebDriver to the most recently opened browser window.
        /// </summary>
        /// <remarks>
        /// This method is typically used after opening a new window to perform actions in it.
        /// Ensure the new window has been fully loaded before calling this method.
        /// </remarks>
        public void SwitchToNewWindow();

        /// <summary>
        /// Switches the focus of the WebDriver back to the original browser window.
        /// </summary>
        /// <remarks>
        /// Use this method to return to the initial window after interacting with a new one.
        /// It's essential to store the original window handle before switching away from it.
        /// </remarks>
        public void SwitchToOriginalWindow();

        /// <summary>
        /// Retrieves the title of the currently active browser window.
        /// </summary>
        /// <returns>
        /// A string containing the title of the current browser window.
        /// </returns>
        /// <remarks>
        /// Useful for verifying the window's content or ensuring the correct window is in focus.
        /// </remarks>
        public string GetCurrentWindowTitle();

        /// <summary>
        /// Closes the currently active browser window.
        /// </summary>
        /// <remarks>
        /// If this method is called on the last open window, the WebDriver session may terminate.
        /// </remarks>
        public void CloseCurrentWindow();
    }
}
