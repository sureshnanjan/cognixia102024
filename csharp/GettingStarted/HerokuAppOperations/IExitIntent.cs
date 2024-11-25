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

namespace HerokuAppOperations
{
    // The IExitIntent interface defines a contract for managing modal windows with title and description.
    public interface IExitIntent
    {
        // Gets the title of the modal window.
        // Returns: A string representing the title of the modal.
        string GetTitle();

        // Gets the description of the modal window.
        // Returns: A string representing the description of the modal.
        string GetDescription();

        // Opens the modal window.
        // This method is expected to trigger the necessary logic to display a modal window.
        void OpenModalWindow();

        // Closes the modal window.
        // This method is expected to handle the logic for dismissing or hiding the modal window.
        void CloseModalWindow();
    }
}

