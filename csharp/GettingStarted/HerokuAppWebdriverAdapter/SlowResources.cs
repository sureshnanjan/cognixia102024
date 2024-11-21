using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace HerokuAppWebdriverAdapter
{
    public class SlowResources : HerokuAppCommon, ISlowResources
    {
        private By header = By.TagName("h3");
        private By content = By.TagName("p");

        public SlowResources(IWebDriver driver) : base(driver)
        {
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
    }
}
