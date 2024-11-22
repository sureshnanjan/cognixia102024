using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class Dropdown : HerokuAppCommon, IDropdown
    {
        private By dropdownMenu;
        private By selectedOption;

        public Dropdown(IWebDriver arg) : base(arg)
        {
            this.dropdownMenu = By.Id("dropdown");
        }

        public string GetTitle()
        {
            return this.driver.Title;
        }

        public void SelectDropdownOption(string option)
        {
            var dropdown = this.driver.FindElement(dropdownMenu);
            var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(dropdown);
            selectElement.SelectByText(option);
        }

        public string GetSelectedOption()
        {
            var dropdown = this.driver.FindElement(dropdownMenu);
            var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(dropdown);
            return selectElement.SelectedOption.Text;
        }
    }
}
