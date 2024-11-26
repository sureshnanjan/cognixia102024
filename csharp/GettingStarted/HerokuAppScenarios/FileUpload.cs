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
using NUnit.Framework;
using HerokuAppOperations;

namespace HerokuAppOperations.Tests
{
    /// <summary>
    /// A stub implementation of the IFileUpload interface used for testing purposes.
    /// </summary>
    public class FileUploadStub : IFileUpload
    {
        public string SelectedFilePath { get; private set; }
        public bool IsFileUploaded { get; private set; }
        public bool IsBrowserClosed { get; private set; }

        /// <summary>
        /// Simulates choosing a file by setting SelectedFilePath to the given file path.
        /// </summary>
        public void ChooseFile(string filePath)
        {
            SelectedFilePath = filePath;
        }

        /// <summary>
        /// Simulates the file upload process by setting IsFileUploaded to true if a file was chosen.
        /// </summary>
        public void FileUpload()
        {
            if (!string.IsNullOrEmpty(SelectedFilePath))
            {
                IsFileUploaded = true;
            }
        }

        /// <summary>
        /// Simulates verification of the file upload by returning the IsFileUploaded status.
        /// </summary>
        public bool VerifyUploadSuccess()
        {
            return IsFileUploaded;
        }

        /// <summary>
        /// Simulates closing the browser by setting IsBrowserClosed to true.
        /// </summary>
        public void CloseBrowser()
        {
            IsBrowserClosed = true;
        }
    }

    /// <summary>
    /// Contains NUnit tests for the IFileUpload interface using the FileUploadStub implementation.
    /// </summary>
    [TestFixture]
    public class FileUploadTests
    {
        private FileUploadStub _fileUpload;

        /// <summary>
        /// Initializes the FileUploadStub instance before each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _fileUpload = new FileUploadStub();
        }

        /// <summary>
        /// Tests that ChooseFile correctly sets the file path.
        /// </summary>
        [Test]
        public void ChooseFile_ShouldSetFilePath()
        {
            // Arrange
            string testFilePath = "C:\\path\\to\\file.txt";

            // Act
            _fileUpload.ChooseFile(testFilePath);

            // Assert
            Assert.AreEqual(testFilePath, _fileUpload.SelectedFilePath);
        }

        /// <summary>
        /// Tests that FileUpload sets IsFileUploaded to true if a file was chosen.
        /// </summary>
        [Test]
        public void FileUpload_ShouldSetIsFileUploadedToTrue_WhenFileIsChosen()
        {
            // Arrange
            _fileUpload.ChooseFile("C:\\path\\to\\file.txt");

            // Act
            _fileUpload.FileUpload();

            // Assert
            Assert.IsTrue(_fileUpload.IsFileUploaded);
        }

        /// <summary>
        /// Tests that VerifyUploadSuccess returns true if the file upload was successful.
        /// </summary>
        [Test]
        public void VerifyUploadSuccess_ShouldReturnTrue_WhenFileUploadIsSuccessful()
        {
            // Arrange
            _fileUpload.ChooseFile("C:\\path\\to\\file.txt");
            _fileUpload.FileUpload();

            // Act
            var uploadSuccess = _fileUpload.VerifyUploadSuccess();

            // Assert
            Assert.IsTrue(uploadSuccess);
        }

        /// <summary>
        /// Tests that VerifyUploadSuccess returns false if the file upload was not successful.
        /// </summary>
        [Test]
        public void VerifyUploadSuccess_ShouldReturnFalse_WhenFileUploadIsNotSuccessful()
        {
            // Act
            var uploadSuccess = _fileUpload.VerifyUploadSuccess();

            // Assert
            Assert.IsFalse(uploadSuccess);
        }

        /// <summary>
        /// Tests that CloseBrowser sets IsBrowserClosed to true.
        /// </summary>
        [Test]
        public void CloseBrowser_ShouldSetIsBrowserClosedToTrue()
        {
            // Act
            _fileUpload.CloseBrowser();

            // Assert
            Assert.IsTrue(_fileUpload.IsBrowserClosed);
        }
    }
}
