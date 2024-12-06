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
    /// NUnit tests for File Download functionality.
    /// </summary>
    [TestFixture]
    public class FileDownloadTests
    {
        private IWebDriver _driver;
        private IFileDownload _fileDownload;

        [SetUp]
        public void SetUp()
        {
            // Initialize the WebDriver and the File Download adapter.
            _driver = new ChromeDriver();
            _fileDownload = new FileDownloadWebdriverAdapter(_driver);

            // Navigate to the File Download page.
            _fileDownload.NavigateToFileDownloadPage();
        }

        [TearDown]
        public void TearDown()
        {
            // Dispose of WebDriver instance after tests.
            if (_driver != null)
            {
                _driver.Dispose();
            }
        }

        [Test]
        public void NavigateToFileDownloadPage_ShouldLoadPageSuccessfully()
        {
            // Assert
            Assert.IsTrue(_fileDownload.IsFileLinkAvailable(), "The File Download page should display at least one file link.");
        }

        [Test]
        public void Download_ShouldTriggerFileDownload()
        {
            // Act
            _fileDownload.Download();

            // Assert
            Assert.IsTrue(_fileDownload.IsFileLinkAvailable(), "File link should still be available after triggering a download.");
        }
    }
}
