using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class Typos : HerokuAppCommon, ITypos
    {
        private By header = By.TagName("h3");
        private By content = By.TagName("p");

        public Typos(IWebDriver driver) : base(driver)
        {
        }

        public string GetPageHeader()
        {
            return driver.FindElement(header).Text;
        }

        public string GetPageContent()
        {
            return driver.FindElement(content).Text;
        }

        public void RefreshPage()
        {
            driver.Navigate().Refresh();
        }
    }
}

