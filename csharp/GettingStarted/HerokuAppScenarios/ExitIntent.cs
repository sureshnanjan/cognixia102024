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
    /// A stub implementation of the IExitIntent interface used for testing purposes.
    /// </summary>
    public class ExitIntentStub : IExitIntent
    {
        /// <summary>
        /// Gets or sets the title of the modal window.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description or content of the modal window.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets a value indicating whether the modal window is currently open.
        /// </summary>
        public bool IsModalOpen { get; private set; } = false;

        /// <summary>
        /// Retrieves the title of the modal window.
        /// </summary>
        /// <returns>A string representing the modal's title.</returns>
        public string GetTitle()
        {
            return Title;
        }

        /// <summary>
        /// Retrieves the description or content of the modal window.
        /// </summary>
        /// <returns>A string representing the modal's description.</returns>
        public string GetDescription()
        {
            return Description;
        }

        /// <summary>
        /// Opens the modal window by setting IsModalOpen to true.
        /// </summary>
        public void OpenModalWindow()
        {
            IsModalOpen = true;
        }

        /// <summary>
        /// Closes the modal window by setting IsModalOpen to false.
        /// </summary>
        public void CloseModalWindow()
        {
            IsModalOpen = false;
        }
    }

    /// <summary>
    /// Contains NUnit tests for the IExitIntent interface using the ExitIntentStub implementation.
    /// </summary>
    [TestFixture]
    public class ExitIntentTests
    {
        private ExitIntentStub _exitIntent;

        /// <summary>
        /// Initializes the ExitIntentStub instance before each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _exitIntent = new ExitIntentStub();
        }

        /// <summary>
        /// Tests that GetTitle() returns the correct title.
        /// </summary>
        [Test]
        public void GetTitle_ShouldReturnTitle()
        {
            // Arrange
            _exitIntent.Title = "Sample Modal Title";

            // Act
            var actualTitle = _exitIntent.GetTitle();

            // Assert
            Assert.AreEqual("Sample Modal Title", actualTitle);
        }

        /// <summary>
        /// Tests that GetDescription() returns the correct description.
        /// </summary>
        [Test]
        public void GetDescription_ShouldReturnDescription()
        {
            // Arrange
            _exitIntent.Description = "This is a sample modal description.";

            // Act
            var actualDescription = _exitIntent.GetDescription();

            // Assert
            Assert.AreEqual("This is a sample modal description.", actualDescription);
        }

        /// <summary>
        /// Tests that calling OpenModalWindow() sets IsModalOpen to true.
        /// </summary>
        [Test]
        public void OpenModalWindow_ShouldSetIsModalOpenToTrue()
        {
            // Act
            _exitIntent.OpenModalWindow();

            // Assert
            Assert.IsTrue(_exitIntent.IsModalOpen);
        }

        /// <summary>
        /// Tests that calling CloseModalWindow() sets IsModalOpen to false.
        /// </summary>
        [Test]
        public void CloseModalWindow_ShouldSetIsModalOpenToFalse()
        {
            // Arrange
            _exitIntent.OpenModalWindow();

            // Act
            _exitIntent.CloseModalWindow();

            // Assert
            Assert.IsFalse(_exitIntent.IsModalOpen);
        }
    }
}
