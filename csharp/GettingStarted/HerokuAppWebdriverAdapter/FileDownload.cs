using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class FileDownload : HerokuAppCommon, IFileDownload
    {
        public FileDownload(IWebDriver driver) :base(driver){ }
        public void Download()
        {
            IWebElement FileElement = driver.FindElement(By.XPath("//a[contains(text(),'Дз занятие 20.pdf')]"));
            Thread.Sleep(3000);
            FileElement.Click();
        }
    }
}
