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
*/

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    // This interface defines the contract for operations involving Shadow DOM elements.
    // An interface in C# is a type that defines a set of methods and properties
    // that the implementing class must provide. It is used to achieve abstraction
    // and multiple inheritance in C#.
    public interface IShadowDomOperations
    {
        // Method to get the shadow root element from a shadow host.
        // This method should contain the logic to locate the shadow host element using the provided locator,
        // and then retrieve the shadow root element from it.
        IWebElement GetShadowRoot(IWebDriver driver, By shadowHostLocator);

        // Method to interact with an element inside the shadow DOM.
        // This method should contain the logic to locate an element within the shadow DOM
        // using the provided locators for the shadow host and the shadow element.
        IWebElement FindElementInShadowDom(IWebDriver driver, By shadowHostLocator, By shadowElementLocator);

        // Method to perform a click on an element inside the shadow DOM.
        // This method should contain the logic to locate an element within the shadow DOM
        // using the provided locators for the shadow host and the shadow element, and then perform a click action on it.
        public void ClickElementInShadowDom(IWebDriver driver, By shadowHostLocator, By shadowElementLocator);
    }
}