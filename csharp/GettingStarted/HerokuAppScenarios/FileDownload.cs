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
    /// A stub implementation of the IFileDownload interface used for testing purposes.
    /// </summary>
    public class FileDownloadStub : IFileDownload
    {
        /// <summary>
        /// Gets a value indicating whether the Download method has been called.
        /// </summary>
        public bool IsDownloadCalled { get; private set; } = false;

        /// <summary>
        /// Simulates the file download process by setting IsDownloadCalled to true.
        /// </summary>
        public void Download()
        {
            IsDownloadCalled = true;
        }
    }

    /// <summary>
    /// Contains NUnit tests for the IFileDownload interface using the FileDownloadStub implementation.
    /// </summary>
    [TestFixture]
    public class FileDownloadTests
    {
        private FileDownloadStub _fileDownload;

        /// <summary>
        /// Initializes the FileDownloadStub instance before each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _fileDownload = new FileDownloadStub();
        }

        /// <summary>
        /// Tests that the Download method is called, setting IsDownloadCalled to true.
        /// </summary>
        [Test]
        public void Download_ShouldSetIsDownloadCalledToTrue()
        {
            // Act
            _fileDownload.Download();

            // Assert
            Assert.IsTrue(_fileDownload.IsDownloadCalled, "Download method should set IsDownloadCalled to true.");
        }
    }
}
