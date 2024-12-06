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
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;

namespace HerokuAppScenarios
{
    /// <summary>
    /// NUnit tests for File Upload functionality on HerokuApp.
    /// </summary>
    [TestFixture]
    public class FileUploadTests
    {
        private IWebDriver _driver;
        private FileUploadWebdriverAdapter _fileUploadAdapter;

        [SetUp]
        public void SetUp()
        {
            // Initialize WebDriver (you may choose other browsers, like Firefox)
            _driver = new ChromeDriver();
            _fileUploadAdapter = new FileUploadWebdriverAdapter(_driver);
        }

        [Test]
        public void UploadFileTest()
        {
            // Declare the file path
            string filePath = @"C:\Users\raj.kadambalu\Downloads\test.txt";  // Escaped backslashes or verbatim string

            // Navigate to the file upload page
            _fileUploadAdapter.NavigateToFileUploadPage();

            // Check if the page is loaded (optional)
            Assert.IsTrue(_fileUploadAdapter.IsPageLoaded(), "File upload page is not loaded");

            // Choose the file to upload
            _fileUploadAdapter.ChooseFile(filePath);  // Passing the file path to the ChooseFile method

            // Click the upload button
            _fileUploadAdapter.FileUpload();

            // Verify that the upload was successful
            bool isUploadSuccessful = _fileUploadAdapter.VerifyUploadSuccess();
            Assert.IsTrue(isUploadSuccessful, "File upload failed");

            // Optional: Validate the file path displayed on the page
            string selectedFilePath = _fileUploadAdapter.GetSelectedFilePath();
            Assert.AreEqual(filePath, selectedFilePath, "The selected file path is incorrect");
        }

        [TearDown]
        public void TearDown()
        {
            // Close the browser after the test
            if (_driver != null)
            {
                _driver.Dispose();
            }
        }
    }
}
