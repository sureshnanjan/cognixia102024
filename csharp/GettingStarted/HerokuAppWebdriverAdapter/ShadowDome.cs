
/*
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
 
  http://www.apache.org/licenses/LICENSE-2.0
 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.
*/using HerokuAppOperations;
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
