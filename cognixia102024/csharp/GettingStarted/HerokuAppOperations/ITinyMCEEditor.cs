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
    /// <summary>
    /// Interface for interacting with the TinyMCE editor.
    /// Defines methods to initialize the editor, get/set/clear content, and retrieve the editor iframe.
    /// </summary>
    public interface ITinyMCEEditor
    {
        /// <summary>
        /// Initializes the TinyMCE editor inside a specified iframe.
        /// </summary>
        /// <param name="iframeId">The ID of the iframe element where the TinyMCE editor is located.</param>
        void InitializeEditor(string iframeId);

        /// <summary>
        /// Gets the content from the TinyMCE editor.
        /// </summary>
        /// <returns>A string representing the current content inside the editor.</returns>
        string GetContent();

        /// <summary>
        /// Sets the content of the TinyMCE editor.
        /// </summary>
        /// <param name="content">The content to set inside the TinyMCE editor.</param>
        void SetContent(string content);

        /// <summary>
        /// Clears the content inside the TinyMCE editor.
        /// </summary>
        void ClearContent();

        /// <summary>
        /// set italic and bold of the content inside the TinyMCE editor.
        /// </summary>
        void SetItalyAndBold();
    }
}
