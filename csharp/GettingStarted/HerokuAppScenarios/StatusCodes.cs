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
    [TestFixture]
    public class StatusCodesTests
    {
        private StatusCodes statusCodesPage;

        // Initialize WebDriver and StatusCodes page object

        // Parameterized Test for verifying Page Titles (HTML <title> tag)
        [TestCase("200", "The Internet")]  // Adjusted to match the actual page title
        [TestCase("404", "The Internet")]
        [TestCase("500", "The Internet")]
        public void VerifyPageTitleForStatusCode(string code, string expectedTitle)
        {
            // Act
            statusCodesPage.NavigateToStatusCode(code);
            string pageTitle = statusCodesPage.GetPageTitle();  // Using GetPageTitle to fetch HTML title

            // Assert
            Assert.AreEqual(expectedTitle, pageTitle, $"The page title for HTTP {code} does not match the expected value.");
        }


        // Parameterized Test for verifying Page Header (Actual content displayed in <h3>)
        [TestCase("200", "Status Codes")]  // Adjusted to match the actual header content on the page
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
        [TestCase("200", "This page returned a 200 status code.\r\n\r\nFor a definition and common list of HTTP status codes, go here")]
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

        // Cleanup after test execution
        [TearDown]
        public void TearDown()
        {
            // Cleanup - close the browser after each test
            statusCodesPage.CloseBrowser();  // Close the browser after test execution
        }
    }
}
