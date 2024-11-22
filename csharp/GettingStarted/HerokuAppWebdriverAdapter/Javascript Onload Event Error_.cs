using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class JsError : HerokuAppCommon, IJsError
    {
        private By errorMessage;

        public JsError(IWebDriver arg) : base(arg)
        {
            this.errorMessage = By.Id("error-message");
        }

        public string GetTitle()
        {
            return this.driver.Title;
        }

        public bool IsErrorMessageDisplayed()
        {
            return this.driver.FindElement(errorMessage).Displayed;
        }
    }
}
