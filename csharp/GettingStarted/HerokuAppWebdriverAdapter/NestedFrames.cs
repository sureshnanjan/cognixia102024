﻿// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class NestedFrames : HerokuAppCommon, INestedFrames
    {
        public NestedFrames(IWebDriver driver) : base(driver)
        {
        }

        public string GetLeftFrameContent()
        {
            driver.SwitchTo().Frame("frame-top").SwitchTo().Frame("frame-left");
            return driver.FindElement(By.TagName("body")).Text;
        }

        public string GetMiddleFrameContent()
        {
            driver.SwitchTo().Frame("frame-top").SwitchTo().Frame("frame-middle");
            return driver.FindElement(By.TagName("body")).Text;
        }

        public string GetRightFrameContent()
        {
            driver.SwitchTo().Frame("frame-top").SwitchTo().Frame("frame-right");
            return driver.FindElement(By.TagName("body")).Text;
        }

        public string GetBottomFrameContent()
        {
            driver.SwitchTo().Frame("frame-bottom");
            return driver.FindElement(By.TagName("body")).Text;
        }

        public void SwitchToMainContent()
        {
            driver.SwitchTo().DefaultContent();
        }

        public bool IsFrameAvailable(string frameName)
        {
            try
            {
                driver.SwitchTo().Frame(frameName);
                driver.SwitchTo().DefaultContent(); // Switch back after checking
                return true;
            }
            catch (NoSuchFrameException)
            {
                return false;
            }
        }

        public void SwitchToFrame(string frameName)
        {
            driver.SwitchTo().Frame(frameName);
        }
    }
}
