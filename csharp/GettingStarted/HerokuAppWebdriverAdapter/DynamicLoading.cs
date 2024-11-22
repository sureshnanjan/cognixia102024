using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class DynamicLoading : HerokuAppCommon, IDynamicLoading
    {
        private By startButton;
        private By loadingText;
        private By loadedElement;

        public DynamicLoading(IWebDriver arg) : base(arg)
        {
            this.startButton = By.XPath("//button[text()='Start']");
            this.loadingText = By.Id("loading");
            this.loadedElement = By.Id("loaded");
        }

        public string GetTitle()
        {
            return this.driver.Title;
        }

        public void StartLoading()
        {
            this.driver.FindElement(startButton).Click();
        }

        public bool IsElementVisibleAfterLoading()
        {
            return this.driver.FindElement(loadedElement).Displayed;
        }
    

    }
}
