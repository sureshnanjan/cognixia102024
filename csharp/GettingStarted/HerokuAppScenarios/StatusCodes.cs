using HerokuAppWebdriverAdapter;
using NUnit.Framework;
using HerokuAppOperations;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class StatusCodesTests
    {
        private IStatusCodes statusCodesPage;

        // Initialize WebDriver and StatusCodes page object
        [SetUp]
        public void Setup()
        {
            // Initialize the StatusCodes page object
            statusCodesPage = new StatusCodes();  // This will initialize the WebDriver inside StatusCodes
        }

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

        // Parameterized Test for verifying Status Code Text (Actual content in <p> tag)
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
        [TestCase("")]
        [TestCase("abc")]
        [TestCase("999")]
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
