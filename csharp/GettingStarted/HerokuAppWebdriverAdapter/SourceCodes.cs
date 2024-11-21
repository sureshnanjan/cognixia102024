using System;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents the Status Codes page on the HerokuApp website.
    /// Provides functionality to interact with and verify the page.
    /// </summary>
    public class StatusCodes : HerokuAppCommon, IStatusCodes
    {
        // Locator for the page header
        private readonly By pageHeader = By.TagName("h3");

        // Locator for the text describing the HTTP status code
        private readonly By statusCodeText = By.TagName("p");

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCodesPage"/> class.
        /// </summary>
        /// <param name="driver">The Selenium WebDriver used to interact with the page.</param>
        public StatusCodes(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Navigates to the page for a specific HTTP status code.
        /// </summary>
        /// <param name="code">The HTTP status code to navigate to (e.g., "200", "404").</param>
        public void NavigateToStatusCode(string code)
        {
            driver.Navigate().GoToUrl($"https://the-internet.herokuapp.com/status_codes/{code}");
        }

        /// <summary>
        /// Retrieves the header text of the Status Codes page.
        /// </summary>
        /// <returns>A string representing the header text of the page.</returns>
        public string GetPageHeader()
        {
            return driver.FindElement(pageHeader).Text;
        }

        /// <summary>
        /// Retrieves the descriptive text of the HTTP status code from the page.
        /// </summary>
        /// <returns>A string representing the description of the HTTP status code.</returns>
        public string GetStatusCodeText()
        {
            return driver.FindElement(statusCodeText).Text;
        }
    }
}
