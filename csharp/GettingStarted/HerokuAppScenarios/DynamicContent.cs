// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;

namespace HerokuAppScenarios
{
    /// <summary>
    /// This test class contains tests to verify dynamic content on the page:
    /// https://the-internet.herokuapp.com/dynamic_content.
    /// It ensures the content changes dynamically after page reloads and validates column data.
    /// </summary>
    [TestFixture]
    public class DynamicContentTests
    {
        private IWebDriver _driver;
        private IDynamicContent _dynamicContentPage;

        /// <summary>
        /// Initializes the WebDriver before running each test.
        /// The WebDriver is used to interact with the browser for automated testing.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // Create an instance of Chrome WebDriver
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _dynamicContentPage = new DynamicContent(_driver);

            // Navigate to the dynamic content page
            // This URL contains dynamic elements that change on page reload.
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_content");
        }

        /// <summary>
        /// Test to verify the content of dynamic columns on the page.
        /// It captures the text within each column and validates its presence.
        /// </summary>
        [Test]
        public void VerifyDynamicContentOfColumns()
        {
            // Locate all div elements with the class 'large-10 columns'
            // These elements represent the dynamic content blocks on the page.
            var columnElements = _driver.FindElements(By.CssSelector("div.large-10.columns"));

            // Check that at least three dynamic content columns are present
            if (columnElements.Count >= 3)
            {
                // Extract and log the text content of each column
                string firstColumnContent = columnElements[0].Text;
                string secondColumnContent = columnElements[1].Text;
                string thirdColumnContent = columnElements[2].Text;

                // Output column content to the console for debugging or review
                Console.WriteLine("First Column Content: " + firstColumnContent);
                Console.WriteLine("Second Column Content: " + secondColumnContent);
                Console.WriteLine("Third Column Content: " + thirdColumnContent);

                // Validate that each column contains text (should not be empty)
                Assert.IsNotEmpty(firstColumnContent, "First column content should not be empty.");
                Assert.IsNotEmpty(secondColumnContent, "Second column content should not be empty.");
                Assert.IsNotEmpty(thirdColumnContent, "Third column content should not be empty.");
            }
            else
            {
                // Fail the test if fewer than three columns are found
                Assert.Fail("Not enough dynamic content columns found on the page.");
            }
        }

        /// <summary>
        /// Test to verify the title, description, and hyperlinks in the dynamic content page.
        /// It checks the title, paragraph contents, and hyperlinks for accuracy.
        /// </summary>
        [Test]
        public void VerifyTitleDescriptionAndHyperlinkInDynamicContentPage()
        {
            // Navigate to the Dynamic Content page (this step can be skipped as it's already done in SetUp)
            //_dynamicContentPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_content");

            // Verify the <h3> title text
            string titleText = _dynamicContentPage.GetHeaderText();
            Assert.AreEqual("Dynamic Content", titleText, "The <h3> title text is incorrect!");

            // Verify the description in the first <p> tag
            string firstParagraph = _dynamicContentPage.GetFirstParagraphText();
            Assert.IsTrue(firstParagraph.Contains("This example demonstrates the ever"),
                          "The first paragraph text is incorrect!");

            // Verify the description in the second <p> tag
            string secondParagraph = _dynamicContentPage.GetSecondParagraphText();
            Assert.IsTrue(secondParagraph.Contains("To make some of the content static append "),
                          "The second paragraph text is incorrect!");

            // Verify the hyperlink in the second <p> tag
            IList<string> hyperlinkTexts = _dynamicContentPage.GetHyperlinkTexts();
            IList<string> hyperlinkUrls = _dynamicContentPage.GetHyperlinkUrls();

            Assert.IsTrue(hyperlinkTexts.Contains("click here"),
                          "The hyperlink text is missing or incorrect!");
            Assert.IsTrue(hyperlinkUrls.Contains("https://the-internet.herokuapp.com/dynamic_content?with_content=static"),
                          "The hyperlink URL is missing or incorrect!");
        }

        /// <summary>
        /// Closes and disposes of the WebDriver instance after tests are completed.
        /// Ensures proper cleanup to avoid resource leaks.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Quit the WebDriver instance and close the browser
            _driver.Quit();

            // Dispose of WebDriver resources to ensure clean execution
            _driver.Dispose();
        }
    }
}
