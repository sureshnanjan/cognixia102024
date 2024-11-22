using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class Inputs : HerokuAppCommon, IInputs
    {
        public By _title;
        public Inputs(IWebDriver driver) : base(driver)
        {
            _title = By.TagName("h3");

        }
        public string GetPageTitle()
        {
            return driver.FindElement(_title).Text;
        }

        public void EnterValue(string value)
        {
            var inputField = driver.FindElement(By.TagName("input"));
            inputField.Clear();
            inputField.SendKeys(value);
        }

        public void ClearInputField()
        {
            var inputField = driver.FindElement(By.TagName("input"));
            inputField.Clear();
        }

        public string GetInputValue()
        {
            var inputField = driver.FindElement(By.TagName("input"));
            return inputField.GetAttribute("value");
        }

        public bool ValidateNumericInput(string input)
        {
            EnterValue(input);
            string actualValue = GetInputValue();
            return int.TryParse(actualValue, out _);
        }

        public bool IsPageLoaded()
        {
            try
            {
                driver.FindElement(By.TagName("input"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public string IncrementValue()
        {
            var inputField = driver.FindElement(By.TagName("input"));
            inputField.SendKeys(Keys.ArrowUp);
            return GetInputValue();
        }

        public string DecrementValue()
        {
            var inputField = driver.FindElement(By.TagName("input"));
            inputField.SendKeys(Keys.ArrowDown);
            return GetInputValue();
        }
    }
}
