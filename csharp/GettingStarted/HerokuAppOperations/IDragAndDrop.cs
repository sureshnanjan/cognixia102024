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
using OpenQA.Selenium;

namespace HerokuAppOperations
{
    // This interface defines the contract for drag-and-drop operations.
    // The methods do not take arguments; the WebDriver and elements are assumed to be managed internally.
    public interface IDragAndDrop
    {
        /// <summary>
        /// Initiates the drag-and-drop operation, moving elements from a source to a target.
        /// </summary>
        void DragAndDropElements();

        /// <summary>
        /// Retrieves the text content of the source element involved in the drag-and-drop operation.
        /// </summary>
        /// <returns>The text of the source element.</returns>
        string GetSourceElementText();

        /// <summary>
        /// Retrieves the text content of the target element involved in the drag-and-drop operation.
        /// </summary>
        /// <returns>The text of the target element.</returns>
        string GetTargetElementText();
    }
}