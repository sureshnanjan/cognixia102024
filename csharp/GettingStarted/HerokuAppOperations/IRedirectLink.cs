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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppOperations
{
    // This interface defines the contract for handling URL redirection and authentication.
    // An interface in C# is a type that defines a set of methods and properties
    // that the implementing class must provide. It is used to achieve abstraction
    // and multiple inheritance in C#.
    public interface IRedirectLink
    {
        // Method to navigate to a specified URL.
        // This method should contain the logic to navigate to a given URL using the provided WebDriver instance.
        public void NavigateToUrl(IWebDriver driver, string url);

        // Method to navigate to a URL with basic authentication.
        // This method should contain the logic to navigate to a given URL using the provided WebDriver instance,
        // and include basic authentication credentials (username and password).
        public void NavigateToUrlWithAuth(IWebDriver driver, string url, string username, string password);

        // Method to extract a URL from a link element.
        // This method should contain the logic to find a link element on the page using the provided locator,
        // and extract the URL from the href attribute of the link.
        public string ExtractUrlFromLink(IWebDriver driver, By locator);
    }
}