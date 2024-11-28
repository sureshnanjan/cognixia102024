// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class KeyPresses : HerokuAppCommon, IKeyPresses
    {
        private By inputField;
        private By resultField;

        public KeyPresses(IWebDriver arg) : base(arg)
        {
            this.inputField = By.Id("target");
            this.resultField = By.Id("result");
        }

        public string GetTitle()
        {
            return this.driver.Title;
        }

        public void PressKey(string key)
        {
            this.driver.FindElement(inputField).SendKeys(key);
        }

        public string GetKeyPressed()
        {
            return this.driver.FindElement(resultField).Text;
        }
    }
}
