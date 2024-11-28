// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using HerokuAppOperations;
using OpenQA.Selenium;
using System;

namespace HerokuAppWebdriverAdapter
{
    public class CheckBox : HerokuAppCommon, ICheckBox
    {
        private By checkbox1;
        private By checkbox2;

        // Constructor to initialize checkbox locators
        public CheckBox(IWebDriver arg) : base(arg)
        {
            this.checkbox1 = By.XPath("//*[@id='checkboxes']/input[1]");
            this.checkbox2 = By.XPath("//*[@id='checkboxes']/input[2]");
        }

        // Method to get the status of checkbox 1
        public bool GetCheckboxOneStatus()
        {
            return this.driver.FindElement(checkbox1).Selected;
        }

        // Method to get the status of checkbox 2
        public bool GetCheckboxTwoStatus()
        {
            return this.driver.FindElement(checkbox2).Selected;
        }

        public bool getCHekboxOneSatatus()
        {
            throw new NotImplementedException();
        }

        public bool getCHekboxTwoSatatus()
        {
            throw new NotImplementedException();
        }

        // Optional method to get the page title (if required)
        public string GetTitle()
        {
            return this.driver.Title;  // Return the title of the current page
        }

        public string getTitle()
        {
            throw new NotImplementedException();
        }
    }
}
