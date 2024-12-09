﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
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
            else if (browser_name.StartsWith("Edge"))
            {
                this.driver =new EdgeDriver();  
            }

            appurl = "https://the-internet.herokuapp.com/";
            this.driver.Navigate().GoToUrl(appurl);
            this.driver.Url = appurl;
        }
        

        public HerokuAppCommon(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebDriver GetDriver()
        {
            return driver;
        }


    }
}
