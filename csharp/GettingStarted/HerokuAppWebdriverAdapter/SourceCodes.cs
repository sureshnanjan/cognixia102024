using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class StatusCodesPage : HerokuAppCommon, IStatusCodes
    {
        private readonly By pageHeader = By.TagName("h3");
        private readonly By statusCodeText = By.TagName("p");

        public StatusCodesPage(IWebDriver driver) : base(driver) { }

        public void NavigateToStatusCode(string code)
        {
            driver.Navigate().GoToUrl($"https://the-internet.herokuapp.com/status_codes/{code}");
        }

        public string GetPageHeader()
        {
            return driver.FindElement(pageHeader).Text;
        }

        public string GetStatusCodeText()
        {
            return driver.FindElement(statusCodeText).Text;
        }
    }
}

