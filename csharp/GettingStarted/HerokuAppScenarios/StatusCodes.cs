using HerokuAppOperations;
using HerokuAppWebdriverAdapter;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for verifying the behavior of status codes on the HerokuApp StatusCodes page.
    /// The tests ensure that the page title, header, and status code text are correctly displayed for valid status codes (200, 404, 500).
    /// Additionally, the class verifies that an appropriate error message is shown for invalid status codes.
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
        /// Parameterized test to verify the page title (HTML <title> tag) for various status codes (200, 404, 500).
        /// It ensures that the page title matches the expected value for each status code.
        /// </summary>
        /// <param name="code">The HTTP status code (e.g., 200, 404, 500).</param>
        /// <param name="expectedTitle">The expected page title based on the status code.</param>
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

        /// <summary>
        /// Parameterized test to verify the page header (content inside <h3>) for various status codes (200, 404, 500).
        /// It ensures that the header matches the expected value for each status code.
        /// </summary>
        /// <param name="code">The HTTP status code (e.g., 200, 404, 500).</param>
        /// <param name="expectedHeader">The expected header content based on the status code.</param>
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

        /// <summary>
        /// Parameterized test to verify the status code text (content inside <p>) for various status codes (200, 404, 500).
        /// It ensures that the status code text matches the expected value for each status code.
        /// </summary>
        /// <param name="code">The HTTP status code (e.g., 200, 404, 500).</param>
        /// <param name="expectedText">The expected status code text based on the status code.</param>
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

        /// <summary>
        /// Test to verify that an appropriate error message is displayed when navigating to an invalid status code.
        /// The test ensures that the error message contains the word "Error" or "not found" for invalid status codes like empty strings, alphabetic codes, or unknown status codes (e.g., "999").
        /// </summary>
        /// <param name="code">The invalid HTTP status code (e.g., empty string, "abc", "999").</param>
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
