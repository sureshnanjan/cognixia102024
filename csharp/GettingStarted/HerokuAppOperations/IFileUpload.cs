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
    /// Defines the operations for file upload functionality.
    /// </summary>
    public interface IFileUpload
    {
        /// <summary>
        /// Navigates to the File Upload page.
        /// </summary>
        void NavigateToFileUploadPage();

        /// <summary>
        /// Checks if the File Upload page is loaded.
        /// </summary>
        /// <returns>True if the page is loaded; otherwise, false.</returns>
        bool IsPageLoaded();

        /// <summary>
        /// Chooses a file to upload by setting the file path in the file input field.
        /// </summary>
        /// <param name="filePath">The full path of the file to upload.</param>
        void ChooseFile(string filePath);

        /// <summary>
        /// Initiates the file upload by clicking the Upload button.
        /// </summary>
        void FileUpload();

        /// <summary>
        /// Verifies if the file upload was successful by checking the uploaded files element.
        /// </summary>
        /// <returns>True if the upload is successful; otherwise, false.</returns>
        bool VerifyUploadSuccess();

        /// <summary>
        /// Closes the browser by disposing of the WebDriver instance.
        /// </summary>
        void CloseBrowser();

        /// <summary>
        /// Retrieves the selected file path from the file input field.
        /// </summary>
        /// <returns>The file path entered into the file input field.</returns>
        string GetSelectedFilePath();
    }
}
