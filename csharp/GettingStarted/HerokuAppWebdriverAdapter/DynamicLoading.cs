// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents the Dynamic Loading page on the Heroku app.
    /// Provides methods to interact with the page's dynamic elements and validate their behavior.
    /// </summary>
    public class DynamicLoadingPage : IDynamicLoadingPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        // Locators
        private readonly By _startButton = By.CssSelector("#start button"); // Start button locator
        private readonly By _loadingIndicator = By.Id("loading");          // Loading indicator locator
        private readonly By _loadedText = By.Id("finish");                 // Locator for dynamically loaded text
        private readonly By _header = By.TagName("h3");                    // Main header locator
        private readonly By _subHeader = By.TagName("h4");                 // Sub-header locator
        private readonly By _paragraphs = By.TagName("p");                 // Paragraphs locator
        private readonly By _hiddenElement = By.Id("finish");             // Hidden element locator
        private readonly By _hyperlinks = By.CssSelector("#content a");    // Hyperlinks locator

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicLoadingPage"/> class.
        /// </summary>
        /// <param name="driver">The WebDriver instance used to interact with the web page.</param>
        public DynamicLoadingPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        // ----------------------------- Navigation -----------------------------

        /// <summary>
        /// Navigates to the specified URL.
        /// </summary>
        /// <param name="url">The URL of the page to navigate to.</param>
        public void NavigateToPage(string url) => _driver.Navigate().GoToUrl(url);

        // ----------------------------- Header and Text Retrieval -----------------------------

        /// <summary>
        /// Retrieves the text of the main header (<h3>) on the page.
        /// </summary>
        /// <returns>The text of the main header.</returns>
        public string GetHeaderText() => _driver.FindElement(_header).Text;

        /// <summary>
        /// Retrieves the text of the sub-header (<h4>) on the page.
        /// </summary>
        /// <returns>The text of the sub-header.</returns>
        public string GetSubHeaderText() => _driver.FindElement(_subHeader).Text;

        /// <summary>
        /// Retrieves the text of the first paragraph on the page.
        /// </summary>
        /// <returns>The text of the first paragraph, or an empty string if it doesn't exist.</returns>
        public string GetFirstParagraphText()
        {
            var paragraphs = _driver.FindElements(_paragraphs);
            return paragraphs.Count > 0 ? paragraphs[0].Text : string.Empty;
        }

        /// <summary>
        /// Retrieves the text of the second paragraph on the page.
        /// </summary>
        /// <returns>The text of the second paragraph, or an empty string if it doesn't exist.</returns>
        public string GetSecondParagraphText()
        {
            var paragraphs = _driver.FindElements(_paragraphs);
            return paragraphs.Count > 1 ? paragraphs[1].Text : string.Empty;
        }

        // ----------------------------- Start Button -----------------------------

        /// <summary>
        /// Clicks the Start button to begin the dynamic loading process.
        /// </summary>
        public void ClickStartButton() => _driver.FindElement(_startButton).Click();

        // ----------------------------- Loading Indicator -----------------------------

        /// <summary>
        /// Checks if the loading indicator is displayed.
        /// </summary>
        /// <returns>True if the loading indicator is displayed; otherwise, false.</returns>
        public bool IsLoadingIndicatorDisplayed() => _driver.FindElement(_loadingIndicator).Displayed;

        /// <summary>
        /// Waits until the loading indicator is no longer displayed.
        /// </summary>
        public void WaitForLoadingToComplete()
        {
            _wait.Until(d => !d.FindElement(_loadingIndicator).Displayed);
        }

        // ----------------------------- Dynamically Loaded Element -----------------------------

        /// <summary>
        /// Checks if the dynamically loaded element is displayed on the page.
        /// </summary>
        /// <returns>True if the element is displayed; otherwise, false.</returns>
        public bool IsDynamicallyLoadedElementDisplayed() => _driver.FindElement(_loadedText).Displayed;

        /// <summary>
        /// Retrieves the text of the dynamically loaded element.
        /// </summary>
        /// <returns>The text of the dynamically loaded element.</returns>
        public string GetLoadedElementText() => _driver.FindElement(_loadedText).Text;

        // ----------------------------- Hidden Element -----------------------------

        /// <summary>
        /// Checks if the hidden element is visible on the page.
        /// </summary>
        /// <returns>True if the hidden element is visible; otherwise, false.</returns>
        public bool IsHiddenElementVisible() => _driver.FindElement(_hiddenElement).Displayed;

        // ----------------------------- Hyperlinks -----------------------------

        /// <summary>
        /// Gets the total number of hyperlinks on the page.
        /// </summary>
        /// <returns>The count of hyperlinks on the page.</returns>
        public int GetHyperlinkCount() => _driver.FindElements(_hyperlinks).Count;

        /// <summary>
        /// Retrieves the text of all hyperlinks on the page.
        /// </summary>
        /// <returns>A list of hyperlink texts.</returns>
        public IList<string> GetHyperlinkTexts() =>
            _driver.FindElements(_hyperlinks).Select(link => link.Text).ToList();

        /// <summary>
        /// Retrieves the URLs of all hyperlinks on the page.
        /// </summary>
        /// <returns>A list of hyperlink URLs.</returns>
        public IList<string> GetHyperlinkUrls() =>
            _driver.FindElements(_hyperlinks).Select(link => link.GetAttribute("href")).ToList();

        // ----------------------------- Utility -----------------------------

        /// <summary>
        /// Checks if an element specified by a CSS selector is displayed.
        /// </summary>
        /// <param name="locator">The CSS selector of the element to check.</param>
        /// <returns>True if the element is displayed; otherwise, false.</returns>
        public bool IsElementDisplayed(string locator)
        {
            try
            {
                return _driver.FindElement(By.CssSelector(locator)).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        /// <summary>
        /// Alternate method to check if the loading indicator is displayed.
        /// </summary>
        /// <returns>True if the loading indicator is displayed; otherwise, false.</returns>
        public bool IsLoadingIndicatorDisplayed2() => _driver.FindElement(_loadingIndicator).Displayed;

        /// <summary>
        /// Alternate method to wait until the loading indicator is no longer displayed.
        /// </summary>
        public void WaitForLoadingToComplete2()
        {
            _wait.Until(driver => !driver.FindElement(_loadingIndicator).Displayed);
        }
    }
}
