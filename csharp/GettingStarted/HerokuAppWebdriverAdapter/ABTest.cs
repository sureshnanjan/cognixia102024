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
