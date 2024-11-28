// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class HerokuAppCommon
    {
        protected string browser_name = "chrome";    
        protected string appurl;
        protected IWebDriver driver;
        public HerokuAppCommon()
        {
            // Refer the App Seetings and according tyo that handle the browser
            if (browser_name.StartsWith("chrome"))
            {
                this.driver = new ChromeDriver();
            }

            appurl = "https://the-internet.herokuapp.com/";
            this.driver.Navigate().GoToUrl(appurl);
            this.driver.Url = appurl;
        }
        

        public HerokuAppCommon(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}
