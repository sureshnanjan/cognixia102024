using HerokuAppOperations;
using OpenQA.Selenium;
using System;

namespace HerokuAppWebdriverAdapter
{
    public class CheckBox : HerokuAppCommon, ICheckBox
    {
        private By checkbox1;
        private By checkbox2;
        private IWebDriver driver;  // Assuming this is declared as part of your class

        // Constructor to initialize checkbox locators
        public CheckBox(IWebDriver arg) : base(arg)
        {
            this.driver = arg;  // Assign the WebDriver passed from the test
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

        // TearDown method to clean up resources and dispose of WebDriver
        [TearDown]
        public void TearDown()
        {
            // Dispose of the WebDriver to avoid memory leaks
            if (driver != null)
            {
                driver.Quit();  // Quit the WebDriver and close all browser windows
            }
        }
    }
}
