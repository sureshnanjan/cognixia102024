using System;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Implementation for interacting with the Typos page on the HerokuApp website.
    /// </summary>
    public class Typos : HerokuAppCommon, ITypos
    {
        // Locators for the header and content elements on the Typos page
        private By header = By.TagName("h3");
        private By content = By.TagName("p");

        /// <summary>
        /// Initializes a new instance of the <see cref="Typos"/> class.
        /// </summary>
        /// <param name="driver">The Selenium WebDriver used for interacting with the web page.</param>
        public Typos(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Retrieves the header text displayed on the Typos page.
        /// </summary>
        /// <returns>A string representing the header text of the page.</returns>
        public string GetPageHeader()
        {
            return driver.FindElement(header).Text;
        }

        /// <summary>
        /// Retrieves the main content text displayed on the Typos page.
        /// </summary>
        /// <returns>A string representing the main content text of the page.</returns>
        public string GetPageContent()
        {
            return driver.FindElement(content).Text;
        }

        /// <summary>
        /// Refreshes the Typos page to simulate a retry or load operation.
        /// </summary>
        public void RefreshPage()
        {
            driver.Navigate().Refresh();
        }
    }
}
