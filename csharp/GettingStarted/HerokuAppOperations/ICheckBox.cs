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
    /// Defines the contract for interacting with checkboxes on a webpage.
    /// This interface must be implemented by any class responsible for handling checkbox operations.
    /// </summary>
    public interface ICheckBox
    {
        /// <summary>
        /// Retrieves the title of the checkbox section on the page.
        /// This method should return the title text of the checkbox section.
        /// </summary>
        /// <returns>The title of the checkbox section as a string.</returns>
        string getTitle();

        /// <summary>
        /// Gets the status (checked or unchecked) of the first checkbox.
        /// This method should return a boolean indicating whether the first checkbox is checked (true) or unchecked (false).
        /// </summary>
        /// <returns>True if the first checkbox is checked, otherwise false.</returns>
        bool getCheckboxOneDefaultStatus();

        /// <summary>
        /// Gets the status (checked or unchecked) of the second checkbox.
        /// This method should return a boolean indicating whether the second checkbox is checked (true) or unchecked (false).
        /// </summary>
        /// <returns>True if the second checkbox is checked, otherwise false.</returns>
        bool getCheckboxTwoDefaultStatus();

        /// <summary>
        /// Toggles the state of the first checkbox.
        /// </summary>
        public void ClickCheckboxOne(); //toggle the checkbox if it is ON change to OFF, if it is OFF change to ON

        /// <summary>
        /// Toggles the state of the second checkbox.
        /// </summary>
        public void ClickCheckboxTwo(); //toggle the checkbox if it is ON change to OFF, if it is OFF change to ON
    }
}