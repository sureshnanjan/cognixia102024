using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class CheckBox : HerokuAppCommon, ICheckBox
    {
        private By checkbox1;
        private By checkbox2;
        public CheckBox(IWebDriver arg): base(arg) {
            this.checkbox1 = By.XPath("//*[@id='checkboxes']/input[1]");
            this.checkbox2 = By.XPath("//*[@id='checkboxes']/input[2]");
        }
       
        public bool getCHekboxOneSatatus()
        {
            return this.driver.FindElement(checkbox1).Selected;
        }

        public bool getCHekboxTwoSatatus()
        {
            return this.driver.FindElement(checkbox2).Selected;
        }

        public string getTitle()
        {
            throw new NotImplementedException();
        }
    }
}
