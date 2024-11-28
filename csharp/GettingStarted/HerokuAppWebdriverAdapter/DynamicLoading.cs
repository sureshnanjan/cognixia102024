﻿// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class DynamicLoading  // Make sure this is the correct class name
    {
        private IWebDriver driver;
        private By startButton;
        private By loadedElement;
        private By pageTitle;
        private By opt1button;

        public DynamicLoading(IWebDriver driver)
        {
            this.driver = driver;
            this.startButton = By.XPath("//*[@id=\"start\"]/button");
            this.loadedElement = By.Id("loaded");
            this.pageTitle = By.TagName("h3");
            this.opt1button = By.XPath("//*[@id=\"content\"]/div/a[1]");
        }

        public string GetTitle()
        {
            return driver.FindElement(pageTitle).Text;
        }

        public void StartLoading()
        {
            driver.FindElement(opt1button).Click();
            //System.Threading.Thread.Sleep(3000);
            driver.FindElement(startButton).Click();
        }

        public bool IsElementVisibleAfterLoading()
        {
            try
            {
                return driver.FindElement(loadedElement).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
