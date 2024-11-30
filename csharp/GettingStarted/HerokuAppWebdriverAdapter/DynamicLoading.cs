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
    public class DynamicLoadingPage : IDynamicLoadingPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        private readonly By _hiddenElement = By.Id("finish"); // Locator for hidden element
        private readonly By _loadingIndicator2 = By.Id("loading"); // Locator for the Loading message


        // Locators
        private readonly By _startButton = By.CssSelector("#start button");
        private readonly By _loadingIndicator = By.Id("loading");
        private readonly By _loadedText = By.Id("finish");
        // Locators
        private readonly By _header = By.TagName("h3");
        private readonly By _paragraphs = By.TagName("p");
        private readonly By _subHeader = By.TagName("h4");
        public DynamicLoadingPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
        public string GetHeaderText()
        {
            return _driver.FindElement(_header).Text;
        }
        public string GetSubHeaderText()
        {
            return _driver.FindElement(_subHeader).Text;
        }
        public string GetFirstParagraphText()
        {
            var paragraphs = _driver.FindElements(_paragraphs);
            return paragraphs.Count > 0 ? paragraphs[0].Text : string.Empty;
        }

        public string GetSecondParagraphText()
        {
            var paragraphs = _driver.FindElements(_paragraphs);
            return paragraphs.Count > 1 ? paragraphs[1].Text : string.Empty;
        }

        public void NavigateToPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ClickStartButton()
        {
            _driver.FindElement(_startButton).Click();
        }

        public bool IsLoadingIndicatorDisplayed()
        {
            return _driver.FindElement(_loadingIndicator).Displayed;
        }

        public void WaitForLoadingToComplete()
        {
            _wait.Until(d => !_driver.FindElement(_loadingIndicator).Displayed);
        }

        public bool IsDynamicallyLoadedElementDisplayed()
        {
            return _driver.FindElement(_loadedText).Displayed;
        }

        public string GetLoadedElementText()
        {
            return _driver.FindElement(_loadedText).Text;
        }

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
        public bool IsHiddenElementVisible()
        {
            return _driver.FindElement(_hiddenElement).Displayed;
        }

        public bool IsLoadingIndicatorDisplayed2()
        {
            return _driver.FindElement(_loadingIndicator).Displayed;
        }
        public void WaitForLoadingToComplete2()
        {
            _wait.Until(driver => !driver.FindElement(_loadingIndicator).Displayed);
        }

        // Locator for hyperlinks
        private readonly By _hyperlinks = By.CssSelector("#content a");

        public int GetHyperlinkCount()
        {
            return _driver.FindElements(_hyperlinks).Count;
        }

        public IList<string> GetHyperlinkTexts()
        {
            return _driver.FindElements(_hyperlinks).Select(link => link.Text).ToList();
        }

        public IList<string> GetHyperlinkUrls()
        {
            return _driver.FindElements(_hyperlinks).Select(link => link.GetAttribute("href")).ToList();
        }
    }
}
