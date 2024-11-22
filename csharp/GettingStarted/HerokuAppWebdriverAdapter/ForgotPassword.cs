using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class ForgotPassword : HerokuAppCommon, IForgotPassword
    {
       
        public ForgotPassword(IWebDriver driver) : base(driver)
        {

        }
        public void VerifyingButton()
        {
            driver.FindElement(By.LinkText("Forgot Password"));
        }
        public void EnteringMail()
        {
            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("user@example.com");
         } 
        public void ClickingRetrievPassword()
        {
            driver.FindElement(By.Id("resetPasswordButton")).Click();
        }
    }
}
