// --------------------------------------------------------------------------------------------------------------------
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
    public class EntryAd : HerokuAppCommon, IEntryAd
    {
        private By adModal;
        private By closeButton;

        public EntryAd(IWebDriver arg) : base(arg)
        {
            this.adModal = By.Id("ad");
            this.closeButton = By.CssSelector("#ad .close");
        }

        public string GetTitle()
        {
            return this.driver.Title;
        }

        public bool IsAdDisplayed()
        {
            return this.driver.FindElement(adModal).Displayed;
        }

        public void CloseAd()
        {
            this.driver.FindElement(closeButton).Click();
        }
    

    }
}
