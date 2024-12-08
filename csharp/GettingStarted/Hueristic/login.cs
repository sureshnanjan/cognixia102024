using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
namespace HuersticCheck
{
    [TestClass]
    public class login
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://petstore.octoperf.com/actions/Catalog.action");
            IWebElement element = driver.FindElement(By.XPath("//a[normalize-space()='Sign In']"));
            element.Click();
            //driver.
            Thread.Sleep(4000);
            driver.Navigate().Back();
            Thread.Sleep(4000);
            driver.Quit();
        }
    }
}