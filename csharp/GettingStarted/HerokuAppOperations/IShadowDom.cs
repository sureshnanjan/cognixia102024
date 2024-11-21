using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IShadowDomOperations
    {
        // Method to get the shadow root element from a shadow host
        IWebElement GetShadowRoot(IWebDriver driver, By shadowHostLocator);

        // Method to interact with an element inside the shadow DOM
        IWebElement FindElementInShadowDom(IWebDriver driver, By shadowHostLocator, By shadowElementLocator);

        // Method to perform a click on an element inside the shadow DOM
       public  void ClickElementInShadowDom(IWebDriver driver, By shadowHostLocator, By shadowElementLocator);
    }
}
