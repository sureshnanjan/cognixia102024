
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace HerokuAppWebdriverAdapter
{
    public class SlowResources : HerokuAppCommon, ISlowResources
    {
        private readonly By header = By.TagName("h3");
        private readonly By content = By.TagName("p");
        private IWebDriver driver;

        public SlowResources()
        {
            // Initialize WebDriver
            driver = new ChromeDriver();
        }
        //public SlowResources(IWebDriver driver) : base(driver) { }

        public void NavigateToPage()
        {
            // Navigate to the Slow Resources page
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/slow");
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public string GetHeaderText()
        {
            return driver.FindElement(header).Text;
        }

        public string GetContentAfterLoading(int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(d => d.FindElement(content).Displayed);
            return driver.FindElement(content).Text;
        }

        public void CloseBrowser()
        {
            // Close the browser and quit WebDriver
            driver.Quit();
        }
    }
}




