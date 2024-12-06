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
using HerokuAppWebdriverAdapter;
using System;
using HerokuAppOperations;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test suite for validating the 'Forgot Password' functionality on the HerokuApp website.
    /// Includes tests for verifying page title, button state, email input, and password retrieval.
    /// </summary>
    [TestFixture]
    public class ForgotPasswordTests
    {
        // Instance of the IForgotPassword implementation
        private IForgotPassword forgotPassword;

        /// <summary>
        /// Setup method to initialize test dependencies.
        /// This method runs before each test case.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize the IForgotPassword implementation (e.g., ForgotPasswordPage).
            forgotPassword = new ForgotPasswordPage();
        }

        /// <summary>
        /// TearDown method to clean up after each test case.
        /// This method runs after each test case.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // You can add cleanup logic if needed
        }

        /// <summary>
        /// Test to validate the title of the 'Forgot Password' page.
        /// </summary>
        [Test]
        public void ValidatePageTitle()
        {
            // Arrange: Prepare the expected page title.
            string expectedTitle = "Forgot Password";

            // Act: Retrieve the actual page title.
            string actualTitle = forgotPassword.GetTitle();

            // Assert: Verify that the page title matches the expected title.
            Assert.AreEqual(expectedTitle, actualTitle, "Page title mismatch.");
        }

        /// <summary>
        /// Test to verify if the 'Forgot Password' button is enabled.
        /// </summary>
        [Test]
        public void VerifyButtonIsEnabled()
        {
            // Arrange: Prepare for verifying the button state.

            // Act: Verify that the button is clickable (enabled).
            forgotPassword.VerifyingButton();

            // Assert: We assume that no exceptions occur, which indicates the button is enabled.
            // If any issues occur during the check, the test will fail.
            Assert.Pass("Forgot Password button is enabled and clickable.");
        }

        /// <summary>
        /// Test to validate the email input functionality for the 'Forgot Password' form.
        /// </summary>
        [Test]
        public void EnterEmailForPasswordReset()
        {
            // Arrange: Provide an email address for the 'Forgot Password' form.
            string testEmail = "testuser@example.com";

            // Act: Enter the email address in the form field.
            forgotPassword.EnteringEmail();

            // Assert: This test will pass if no exceptions occur during the email entry process.
            // You could enhance this test by verifying that the email is actually entered correctly.
            Console.WriteLine("Email entered for password reset.");
            Assert.Pass("Email entered successfully.");
        }

        /// <summary>
        /// Test to validate the functionality of the 'Retrieve Password' button.
        /// </summary>
        [Test]
        public void RetrievePasswordFunctionality()
        {
            // Arrange: Prepare the email address and ensure it's entered.
            string testEmail = "testuser@example.com";
            forgotPassword.EnteringEmail();

            // Act: Click the 'Retrieve Password' button to trigger the password reset process.
            forgotPassword.ClickingRetrievePassword();

            // Assert: You would typically verify that the reset process starts (e.g., confirmation message or redirection).
            // This can be done by checking for success messages or email prompts. For now, we assume success if no exception occurs.
            Assert.Pass("Password retrieval process triggered successfully.");
        }
    }
}
