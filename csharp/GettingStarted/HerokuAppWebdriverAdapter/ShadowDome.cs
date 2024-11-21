using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class ShadowDomOperations : IShadowDomOperations
    {
        // Method to get the shadow root from the shadow host
        public IWebElement GetShadowRoot(IWebDriver driver, By shadowHostLocator)
        {
            IWebElement shadowHost = driver.FindElement(shadowHostLocator);
            // Access the shadow root using JavaScript execution
            return (IWebElement)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].shadowRoot", shadowHost);
        }

        // Method to find an element inside the shadow DOM
        public IWebElement FindElementInShadowDom(IWebDriver driver, By shadowHostLocator, By shadowElementLocator)
        {
            IWebElement shadowRoot = GetShadowRoot(driver, shadowHostLocator);
            return shadowRoot.FindElement(shadowElementLocator);
        }

        // Method to perform a click inside the shadow DOM
        public void ClickElementInShadowDom(IWebDriver driver, By shadowHostLocator, By shadowElementLocator)
        {
            IWebElement shadowRoot = GetShadowRoot(driver, shadowHostLocator);
            IWebElement shadowElement = shadowRoot.FindElement(shadowElementLocator);
            shadowElement.Click();
        }
    }
}
