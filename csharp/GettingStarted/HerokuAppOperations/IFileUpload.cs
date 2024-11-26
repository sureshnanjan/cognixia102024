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
    public interface IFileUpload
    {
       

        /// <summary>
        /// Uploads a file to the target webpage.
        /// </summary>
        /// <param name="filePath">The full path to the file to be uploaded.</param>
        public void FileUpload();


        public void ChooseFile(string filePath);

        /// <summary>
        /// Verifies if the file upload was successful.
        /// </summary>
        /// <returns>A boolean indicating success or failure.</returns>
       

        /// <summary>
        /// Closes the browser.
        /// </summary>
        public void CloseBrowser();
    }
}
