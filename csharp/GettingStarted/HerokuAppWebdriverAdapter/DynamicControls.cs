using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class DynamicControls : HerokuAppCommon, IDynamicControls
    {
        private By checkbox;
        private By enableDisableButton;
        private By inputField;
        private By message;

        public DynamicControls(IWebDriver arg) : base(arg)
        {
            this.checkbox = By.Id("checkbox");
            this.enableDisableButton = By.XPath("//button[text()='Enable']");  // Initially Enable button
            this.inputField = By.Id("input");
            this.message = By.Id("message");
        }

        public string GetTitle()
        {
            return this.driver.Title;
        }

        public bool IsCheckboxDisplayed()
        {
            return this.driver.FindElement(checkbox).Displayed;
        }

        public bool IsInputFieldEnabled()
        {
            return this.driver.FindElement(inputField).Enabled;
        }

        public void ClickEnableDisableButton()
        {
            this.driver.FindElement(enableDisableButton).Click();
        }

        public string GetMessage()
        {
            return this.driver.FindElement(message).Text;
        }

        public bool IsCheckboxChecked()
        {
            return this.driver.FindElement(checkbox).Selected;
        }

        public void EnableCheckbox()
        {
            throw new NotImplementedException();
        }

        public void DisableCheckbox()
        {
            throw new NotImplementedException();
        }

        public bool IsCheckboxEnabled()
        {
            throw new NotImplementedException();
        }
    }
}
