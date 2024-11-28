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
    /// Test suite for testing form authentication using a stub implementation of IFormAuthentication interface.
    /// </summary>
    [TestFixture]
    public class FormAuthenticationTests
    {
        /// <summary>
        /// Stub class implementing the IFormAuthentication interface for testing purposes.
        /// </summary>
        public class FormAuthenticationStub : IFormAuthentication
        {
            /// <summary>
            /// Indicates if the user has navigated to the login page.
            /// </summary>
            public bool IsNavigated { get; set; }

            /// <summary>
            /// Indicates if the credentials have been set.
            /// </summary>
            public bool IsCredentialsSet { get; set; }

            /// <summary>
            /// Indicates if the login attempt was initiated.
            /// </summary>
            public bool IsLoggedIn { get; set; }

            /// <summary>
            /// Indicates if the login status was verified as successful.
            /// </summary>
            public bool IsLoginVerified { get; set; }

            /// <summary>
            /// Simulates navigating to the login page.
            /// </summary>
            public void GetNavigatedTo()
            {
                IsNavigated = true;
            }

            /// <summary>
            /// Simulates setting the login credentials.
            /// </summary>
            public void GetCredentials()
            {
                IsCredentialsSet = true;
            }

            /// <summary>
            /// Simulates a login attempt.
            /// </summary>
            public void GetIntoLogin()
            {
                IsLoggedIn = true;
            }

            /// <summary>
            /// Simulates verifying whether the login was successful or failed.
            /// </summary>
            public void VerifyingLoginSuccessorFail()
            {
                IsLoginVerified = IsLoggedIn;
            }

            /// <summary>
            /// Simulates verifying the current login status.
            /// </summary>
            public void VerifyingLogin()
            {
                IsLoginVerified = IsLoggedIn;
            }
        }

        private FormAuthenticationStub _formAuth;

        /// <summary>
        /// Initializes the test setup by creating a new instance of FormAuthenticationStub.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _formAuth = new FormAuthenticationStub();
        }

        /// <summary>
        /// Tests that the user is successfully navigated to the login page.
        /// </summary>
        [Test]
        public void GetNavigatedTo_ShouldExecuteWithoutError()
        {
            // Act
            _formAuth.GetNavigatedTo();

            // Assert
            Assert.IsTrue(_formAuth.IsNavigated, "User should be navigated to the login page.");
        }

        /// <summary>
        /// Tests that login credentials are successfully set.
        /// </summary>
        [Test]
        public void GetCredentials_ShouldExecuteWithoutError()
        {
            // Act
            _formAuth.GetCredentials();

            // Assert
            Assert.IsTrue(_formAuth.IsCredentialsSet, "Credentials should be set.");
        }

        /// <summary>
        /// Tests that the login attempt is successfully initiated.
        /// </summary>
        [Test]
        public void GetIntoLogin_ShouldExecuteWithoutError()
        {
            // Act
            _formAuth.GetIntoLogin();

            // Assert
            Assert.IsTrue(_formAuth.IsLoggedIn, "Login attempt should be initiated.");
        }

        /// <summary>
        /// Tests that login verification succeeds when login is successful.
        /// </summary>
        [Test]
        public void VerifyingLoginSuccessorFail_ShouldReturnTrue_WhenLoginIsSuccessful()
        {
            // Arrange
            _formAuth.GetIntoLogin();  // Simulate a successful login

            // Act
            _formAuth.VerifyingLoginSuccessorFail();

            // Assert
            Assert.IsTrue(_formAuth.IsLoginVerified, "Login verification should be successful.");
        }

        /// <summary>
        /// Tests that the login status is verified as successful when login succeeds.
        /// </summary>
        [Test]
        public void VerifyingLogin_ShouldReturnTrue_WhenLoginIsSuccessful()
        {
            // Arrange
            _formAuth.GetIntoLogin();  // Simulate a successful login

            // Act
            _formAuth.VerifyingLogin();

            // Assert
            Assert.IsTrue(_formAuth.IsLoginVerified, "Login should be verified as successful.");
        }

        /// <summary>
        /// Tests that the login status is verified as failed when login does not succeed.
        /// </summary>
        [Test]
        public void VerifyingLogin_ShouldReturnFalse_WhenLoginFailed()
        {
            // Arrange
            _formAuth.IsLoggedIn = false;  // Simulate a failed login

            // Act
            _formAuth.VerifyingLogin();

            // Assert
            Assert.IsFalse(_formAuth.IsLoginVerified, "Login should be verified as failed.");
        }
    }
}
