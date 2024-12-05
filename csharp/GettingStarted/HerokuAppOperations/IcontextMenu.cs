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
    /// Defines the contract for performing context menu operations on a web page.
    /// This interface allows for interactions such as right-clicking on an element, 
    /// retrieving the alert text, and accepting the alert that is displayed.
    /// </summary>
    public interface IContextMenu
    {
        /// <summary>
        /// Simulates a right-click action on the context menu box element.
        /// </summary>
        void RightClickOnBox();

        /// <summary>
        /// Retrieves the text from the alert that is triggered after a right-click action.
        /// </summary>
        /// <returns>The text displayed in the alert.</returns>
        string GetAlertText();

        /// <summary>
        /// Accepts the alert that is displayed after a right-click action.
        /// This action usually corresponds to pressing "OK" on the alert dialog.
        /// </summary>
        void AcceptAlert();
    }
}
