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
