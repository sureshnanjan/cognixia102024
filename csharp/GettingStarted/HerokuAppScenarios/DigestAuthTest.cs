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
    /// Includes tests for authentication, page title, and description validation.
    /// </summary>
    [TestFixture]
    public class DigestAuthTests
    {
        // Instance of DigestAuth to perform authentication-related operations.
        private DigestAuth digestAuth;

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
        /// TearDown method to clean up after each test.
        /// This method runs after each test case.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Close the browser to clean up resources.
            digestAuth.Quit();
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

        /// <summary>
        /// Test to verify the page title after successful authentication.
        /// </summary>
        [Test]
        public void ValidatePageTitle()
        {
            // Arrange: Provide valid credentials.
            string username = "admin";
            string password = "admin";
            string expectedTitle = "Digest Auth";

            // Act: Perform authentication and retrieve the page title.
            digestAuth.Authenticate(username, password);
            string actualTitle = digestAuth.GetPageTitle();

            // Assert: Verify that the page title is as expected.
            Assert.AreEqual(expectedTitle, actualTitle, "Page title mismatch.");
        }

        /// <summary>
        /// Test to verify the page description after successful authentication.
        /// </summary>
        [Test]
        public void ValidatePageDescription()
        {
            // Arrange: Provide valid credentials.
            string username = "admin";
            string password = "admin";
            string expectedDescription = "Congratulations! You must have the proper credentials.";

            // Act: Perform authentication and retrieve the page description.
            digestAuth.Authenticate(username, password);
            string actualDescription = digestAuth.GetPageDescription();

            // Assert: Verify that the page description is as expected.
            Assert.AreEqual(expectedDescription, actualDescription, "Page description mismatch.");
        }
    }
}


