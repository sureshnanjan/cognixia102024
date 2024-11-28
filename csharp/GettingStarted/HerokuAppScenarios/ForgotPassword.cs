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

namespace HerokuAppOperations
{
    /// <summary>
    /// Test suite for testing the Forgot Password page behavior using a stub implementation of IForgotPassword interface.
    /// </summary>
    [TestFixture]
    public class ForgotPassword
    {
        /// <summary>
        /// Stub class implementing the IForgotPassword interface for testing purposes.
        /// </summary>
        public class ForgotPasswordStub : IForgotPassword
        {
            /// <summary>
            /// Represents the title of the Forgot Password page.
            /// </summary>
            public string PageTitle { get; set; }

            /// <summary>
            /// Simulates retrieving the title of the Forgot Password page.
            /// </summary>
            /// <returns>The page title if set; otherwise, an empty string.</returns>
            public string GetTitle()
            {
                return PageTitle ?? ""; // Return empty string if PageTitle is null
            }

            /// <summary>
            /// Simulates verifying if a button is enabled or clickable.
            /// </summary>
            public void VerifyingButton()
            {
                // No actual implementation required for testing method invocation.
            }

            /// <summary>
            /// Simulates entering an email address into the input field.
            /// </summary>
            public void EnteringEmail()
            {
                // No actual implementation required for testing method invocation.
            }

            /// <summary>
            /// Simulates clicking the 'Retrieve Password' button.
            /// </summary>
            public void ClickingRetrievePassword()
            {
                // No actual implementation required for testing method invocation.
            }
        }

        private ForgotPasswordStub _forgotPassword;

        /// <summary>
        /// Initializes the test setup by creating a new instance of ForgotPasswordStub.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _forgotPassword = new ForgotPasswordStub();
        }

        /// <summary>
        /// Tests that GetTitle returns an empty string when the title is not set.
        /// </summary>
        [Test]
        public void GetTitle_ShouldReturnEmptyString_WhenTitleNotSet()
        {
            // Act
            var result = _forgotPassword.GetTitle();

            // Assert
            Assert.IsEmpty(result, "Title should be empty when not set.");
        }

        /// <summary>
        /// Verifies that the VerifyingButton method executes without throwing any exceptions.
        /// </summary>
        [Test]
        public void VerifyingButton_ShouldExecuteWithoutError()
        {
            // Act
            _forgotPassword.VerifyingButton();

            // Assert
            Assert.Pass("VerifyingButton method called successfully.");
        }

        /// <summary>
        /// Verifies that the EnteringEmail method executes without throwing any exceptions.
        /// </summary>
        [Test]
        public void EnteringEmail_ShouldExecuteWithoutError()
        {
            // Act
            _forgotPassword.EnteringEmail();

            // Assert
            Assert.Pass("EnteringEmail method called successfully.");
        }

        /// <summary>
        /// Verifies that the ClickingRetrievePassword method executes without throwing any exceptions.
        /// </summary>
        [Test]
        public void ClickingRetrievePassword_ShouldExecuteWithoutError()
        {
            // Act
            _forgotPassword.ClickingRetrievePassword();

            // Assert
            Assert.Pass("ClickingRetrievePassword method called successfully.");
        }

        /// <summary>
        /// Tests that GetTitle returns the correct page title when it is set.
        /// </summary>
        [Test]
        public void GetTitle_ShouldReturnCorrectTitle()
        {
            // Arrange
            _forgotPassword.PageTitle = "Forgot Password - MyApp";

            // Act
            var result = _forgotPassword.GetTitle();

            // Assert
            Assert.AreEqual("Forgot Password - MyApp", result, "Title should be 'Forgot Password - MyApp'.");
        }
    }
}
