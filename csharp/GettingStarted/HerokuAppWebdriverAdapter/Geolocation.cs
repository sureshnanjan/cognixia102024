using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class Geolocation : HerokuAppCommon, IGeolocation
    {
        public Geolocation(IWebDriver driver) : base(driver) { }

        public void OnclickWhereami()
        {
            driver.FindElement(By.TagName("button")).Click();
        }
        public void GetLocationDetails()
        {
            var lati=driver.FindElement(By.Id("lat-value"));

            var longi= driver.FindElement(By.Id("long-value"));
        }
    }
}
