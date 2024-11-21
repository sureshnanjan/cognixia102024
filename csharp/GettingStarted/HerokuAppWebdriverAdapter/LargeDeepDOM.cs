using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class LargeDeepDOMOperations : ILargeDeepDOM
    {
        private IWebDriver driver;

        public LargeDeepDOMOperations(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenLargeDeepDOMPage()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/large");
        }

        public bool IsElementPresent(string elementSelector)
        {
            try
            {
                driver.FindElement(By.CssSelector(elementSelector));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public List<string> GetAllItemsInDeepDOM()
        {
            var items = new List<string>();
            var elements = driver.FindElements(By.CssSelector(".large-item-class"));
            foreach (var element in elements)
            {
                items.Add(element.Text);
            }
            return items;
        }

        public void ClickItemInDOM(string itemSelector)
        {
            var item = driver.FindElement(By.CssSelector(itemSelector));
            item.Click();
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public void ScrollThroughDOM(int scrollAmount)
        {
            var jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript($"window.scrollBy(0, {scrollAmount});");
        }

        public void WaitForDOMToLoad()
        {
            var jsExecutor = (IJavaScriptExecutor)driver;
            while ((bool)jsExecutor.ExecuteScript("return document.readyState === 'complete';") == false)
            {
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
