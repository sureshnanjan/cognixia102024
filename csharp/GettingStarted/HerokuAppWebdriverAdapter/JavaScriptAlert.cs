using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppScenarios
{
    public class JavaScriptAlert : HerokuAppCommon, IJavaScriptAlerts
    {
        public JavaScriptAlert(IWebDriver driver) : base(driver){ }
        public void ClickforJsAlert()
        {
            IWebElement buton1 = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Alert']"));
            Thread.Sleep(2000);
            buton1.Click();
        }

        public void ClickforJsAlertClose()
        {
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            alert.Accept();
        }

        public void ClickforJsConfirm()
        {
            IWebElement buton2 = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Confirm']"));
            Thread.Sleep(2000);
            buton2.Click();
        }

        public void ClickforJsConfirmClose()
        {
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            alert.Dismiss();
        }

        public void ClickforJsPrompt()
        {
            IWebElement buton3 = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Prompt']"));
            Thread.Sleep(2000);
            buton3.Click();
        }

        public void ClickforJsPromptClose(string message)
        {
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            alert.SendKeys(message);
            Thread.Sleep(2000);
            alert.Accept();
        }
    }
}
