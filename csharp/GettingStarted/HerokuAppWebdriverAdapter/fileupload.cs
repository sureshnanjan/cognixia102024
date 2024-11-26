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
using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Handles file upload operations in the Heroku app, including file selection, upload, and browser closure.
    /// </summary>
    public class fileupload : HerokuAppCommon, Iupload
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="fileupload"/> class with the specified WebDriver.
        /// </summary>
        /// <param name="driver">The WebDriver instance used to interact with the browser.</param>
        public fileupload(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Closes the browser after completing the file upload process.
        /// </summary>
        public void CloseBrowser()
        {
            // Close all browser windows and end the WebDriver session
            driver.Quit();
        }

        /// <summary>
        /// Chooses a file from the specified local path to upload.
        /// </summary>
        /// <param name="filePath">The full path of the file to be uploaded.</param>
        public void ChooseFile(string filePath)
        {
            // Locate the file input element by its ID
            IWebElement ChooseFile = driver.FindElement(By.XPath("//input[@id='file-upload']"));

            // Wait for 2 seconds to ensure the element is ready (can be replaced with explicit waits)
            Thread.Sleep(2000);

            // Send the file path to the input element to select the file
            ChooseFile.SendKeys(filePath);
        }

        /// <summary>
        /// Uploads the selected file by clicking the upload button.
        /// </summary>
        public void UploadFile()
        {
            // Locate the file upload button by its ID
            IWebElement upload = driver.FindElement(By.XPath("//input[@id='file-submit']"));

            // Wait for 2 seconds to ensure the button is interactable (can be replaced with explicit waits)
            Thread.Sleep(2000);

            // Click the upload button to start the upload process
            upload.Click();
        }
    }
}