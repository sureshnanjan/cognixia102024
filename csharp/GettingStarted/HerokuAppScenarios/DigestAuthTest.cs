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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HerokuAppWebdriverAdapter;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test suite for validating Digest Authentication functionality on the HerokuApp website.
    /// Includes tests for successful and failed authentication attempts.
    /// </summary>
    [TestFixture]
    public class DigestAuthTests
    {
        // Instance of DigestAuth to perform authentication-related operations.
        DigestAuth digestAuth;

        /// <summary>
        /// Setup method to initialize test dependencies.
        /// This method runs before each test case.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize the DigestAuth instance.
            digestAuth = new DigestAuth();
        }

        /// <summary>
        /// Test to verify authentication with valid credentials.
        /// </summary>
        [Test]
        public void AuthenticateWithValidCredentials()
        {
            // Arrange: Provide valid credentials.
            string username = "admin";
            string password = "admin";

            // Act: Perform authentication using the valid credentials.
            digestAuth.Authenticate(username, password);

            // Assert: Verify that the success message is displayed as expected.
            string expectedMessage = "Congratulations! You must have the proper credentials.";
            string actualMessage = digestAuth.GetSuccessMessage();
            Assert.AreEqual(expectedMessage, actualMessage, "Authentication success message mismatch.");
        }

        /// <summary>
        /// Test to verify authentication with invalid credentials.
        /// </summary>
        [Test]
        public void AuthenticateWithInvalidCredentials()
        {
            // Arrange: Provide invalid credentials.
            string username = "invalid";
            string password = "invalid";

            // Act: Perform authentication using the invalid credentials.
            digestAuth.Authenticate(username, password);

            // Assert: Verify that no success message is displayed (authentication fails).
            string actualMessage = digestAuth.GetSuccessMessage();
            Assert.AreEqual("Success message not found.", actualMessage, "Unexpected success message displayed.");
        }
    }
}

