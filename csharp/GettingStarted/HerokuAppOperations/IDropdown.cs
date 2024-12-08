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

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents a contract for interacting with a dropdown element on a web page.
    /// This interface provides methods to select an option, get the selected option text,
    /// and retrieve all available options in the dropdown.
    /// </summary>
    public interface IDropdown : IDisposable
    {
        /// <summary>
        /// Selects an option from the dropdown by its visible text.
        /// </summary>
        /// <param name="optionText">The visible text of the option to select.</param>
        void SelectOptionByText(string optionText);

        /// <summary>
        /// Retrieves the text of the currently selected option in the dropdown.
        /// </summary>
        /// <returns>The text of the selected option.</returns>
        string GetSelectedOptionText();

        /// <summary>
        /// Retrieves all available options in the dropdown as a list of strings.
        /// </summary>
        /// <returns>A list of strings containing the text of all options in the dropdown.</returns>
        List<string> GetAllOptionsText();

        /// <summary>
        /// Releases the resources used by the dropdown, such as WebDriver instances, if any.
        /// This method is required for proper cleanup and memory management.
        /// </summary>
        void Dispose();
    }
}
