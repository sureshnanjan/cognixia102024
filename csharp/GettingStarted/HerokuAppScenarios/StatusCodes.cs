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
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using System.Net;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for verifying the behavior of status codes on the HerokuApp StatusCodes page.
    /// The tests ensure that the page title, header, status code text, and actual HTTP status code are correctly displayed for valid status codes (200, 301, 404, 500).
    /// </summary>
    [TestFixture]
    public class StatusCodesTests
    {
        /// <summary>
        /// Instance of the StatusCodes page object used in the tests.
        /// </summary>
        private IStatusCodes statusCodesPage;

        /// <summary>
        /// Setup method executed before each test.
        /// Initializes the StatusCodes page object for each test and sets up the WebDriver.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize the StatusCodes page object
            statusCodesPage = new StatusCodes();  // This will initialize the WebDriver inside StatusCodes
        }

        /// <summary>
        /// Parameterized test to verify the page title (HTML <title> tag) for various status codes (200, 301, 404, 500).
        /// It ensures that the page title matches the expected value for each status code.
        /// </summary>
        [TestCase("200", "The Internet", HttpStatusCode.OK)]
        [TestCase("301", "The Internet", HttpStatusCode.MovedPermanently)]
        [TestCase("404", "The Internet", HttpStatusCode.NotFound)]
        [TestCase("500", "The Internet", HttpStatusCode.InternalServerError)]
        public void VerifyPageTitleAndStatusCodeForStatusCode(string code, string expectedTitle, HttpStatusCode expectedStatusCode)
        {
            // Act
            statusCodesPage.NavigateToStatusCode(code);
            string pageTitle = statusCodesPage.GetPageTitle();  // Using GetPageTitle to fetch HTML title

            // Assert for Page Title
            Assert.AreEqual(expectedTitle, pageTitle, $"The page title for HTTP {code} does not match the expected value.");

            // Verify the actual HTTP status code returned by the page
            var actualStatusCode = (HttpStatusCode)(int)statusCodesPage.GetHttpStatusCode();  // Cast double to HttpStatusCode
            Assert.That(actualStatusCode, Is.EqualTo(expectedStatusCode), $"The actual HTTP status code for {code} does not match the expected value.");
        }

        /// <summary>
        /// Parameterized test to verify the page header (content inside <h3>) for various status codes (200, 301, 404, 500).
        /// It ensures that the header matches the expected value for each status code.
        /// </summary>
        [TestCase("200", "Status Codes")]
        [TestCase("301", "Status Codes")]
        [TestCase("404", "Status Codes")]
        [TestCase("500", "Status Codes")]
        public void VerifyPageHeaderForStatusCode(string code, string expectedHeader)
        {
            // Act
            statusCodesPage.NavigateToStatusCode(code);
            string pageHeader = statusCodesPage.GetPageHeader();  // Using GetPageHeader to fetch the <h3> content

            // Assert
            Assert.AreEqual(expectedHeader, pageHeader, $"The page header for HTTP {code} does not match the expected value.");
        }

        /// <summary>
        /// Parameterized test to verify the status code text (content inside <p>) for various status codes (200, 301, 404, 500).
        /// It ensures that the status code text matches the expected value for each status code.
        /// </summary>
        [TestCase("200", "This page returned a 200 status code.\r\n\r\nFor a definition and common list of HTTP status codes, go here")]
        [TestCase("301", "This page returned a 301 status code.\r\n\r\nFor a definition and common list of HTTP status codes, go here")]
        [TestCase("404", "This page returned a 404 status code.\r\n\r\nFor a definition and common list of HTTP status codes, go here")]
        [TestCase("500", "This page returned a 500 status code.\r\n\r\nFor a definition and common list of HTTP status codes, go here")]
        public void VerifyStatusCodeTextForStatusCode(string code, string expectedText)
        {
            // Act
            statusCodesPage.NavigateToStatusCode(code);
            string statusText = statusCodesPage.GetStatusCodeText();  // Using GetStatusCodeText to fetch the <p> content

            // Print out the actual status text for debugging
            Console.WriteLine("Actual Status Text: " + statusText);

            // Assert
            Assert.AreEqual(expectedText, statusText, $"The status code text for HTTP {code} does not match the expected value.");
        }

        /// <summary>
        /// Test to verify that an appropriate error message is displayed when navigating to an invalid status code.
        /// The test ensures that the error message contains the word "Error" or "not found" for invalid status codes like empty strings, alphabetic codes, or unknown status codes (e.g., "999").
        /// </summary>
        [TestCase("")]  // Invalid status code (empty string)
        [TestCase("abc")]  // Invalid status code (non-numeric code)
        [TestCase("999")]  // Invalid status code (unknown code)
        public void VerifyPageForInvalidStatusCode(string code)
        {
            // Act
            statusCodesPage.NavigateToStatusCode(code);
            string pageTitle = statusCodesPage.GetPageTitle();
            string errorMessage = statusCodesPage.GetErrorMessage();  // Fetch the error message specifically

            // Assert: Verify the page contains an error message, not just a default page
            Assert.IsTrue(errorMessage.Contains("Error") || errorMessage.Contains("not found"),
                          $"The page for invalid HTTP code {code} did not contain the expected error message: {errorMessage}");
        }
    }
}
