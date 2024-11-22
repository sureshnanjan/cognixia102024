using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class ABTest : HerokuAppCommon, IABTesting
    {
        public ABTest(IWebDriver driver): base(driver) { }

        public string GetDiscription()
        {
            IWebElement dis = driver.FindElement(By.XPath("//p[contains(text(),'Also known as split testing. This is a way in whic')]"));
            return dis.Text;
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public void OptInABTest()
        {
            driver.Manage().Cookies.DeleteCookie(new Cookie("optimizelyOptOut", "true"));
        }

        public void OptOutABTest()
        {
            driver.Manage().Cookies.AddCookie(new Cookie("optimizelyOptOut", "true"));
        }
    }
}
