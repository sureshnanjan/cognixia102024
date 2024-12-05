
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

using HerokuAppOperations;

namespace HerokuAppWebdriverAdapter
{

    /// <summary>
    /// Represents a page object model for interacting with the Redirect page
    /// on the HerokuApp website. Implements the IRedirectPage interface to provide
    /// methods for handling URL redirection and status code navigation.
    /// </summary>
    public class RedirectPage : HerokuAppCommon, IRedirectPage
    {
        // Locators for the Redirect page elements
        private readonly By redirectLink = By.LinkText("Redirect Link");
        private readonly By redirectButton = By.Id("redirect");
        private readonly By hereLink = By.LinkText("here");

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectPage"/> class.
        /// </summary>
        /// <param name="driver">The WebDriver instance used to interact with the page.</param>
        public RedirectPage(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Clicks on the "Redirect Link" to start the redirection process.
        /// </summary>
        public void ClickRedirectLink()
        {
            driver.FindElement(redirectLink).Click();
        }

        /// <summary>
        /// Clicks on the "Redirect" button to trigger a redirection to a status code page.
        /// </summary>
        public void ClickRedirectButton()
        {
            driver.FindElement(redirectButton).Click();
        }

        /// <summary>
        /// Navigates to the page displaying the 200 status code.
        /// </summary>
        public void NavigateTo200StatusCode()
        {
            driver.FindElement(By.LinkText("200")).Click();
        }

        /// <summary>
        /// Clicks on the "here" link on the 200 status code page to load additional content or navigate further.
        /// </summary>
        public void ClickHereLinkFor200()
        {
            driver.FindElement(hereLink).Click();
        }

        /// <summary>
        /// Navigates to the page displaying the 301 status code.
        /// </summary>
        public void NavigateTo301StatusCode()
        {
            driver.FindElement(By.LinkText("301")).Click();
        }

        /// <summary>
        /// Clicks on the "here" link on the 301 status code page to load additional content or navigate further.
        /// </summary>
        public void ClickHereLinkFor301()
        {
            driver.FindElement(hereLink).Click();
        }

        /// <summary>
        /// Navigates to the page displaying the 404 status code.
        /// </summary>
        public void NavigateTo404StatusCode()
        {
            driver.FindElement(By.LinkText("404")).Click();
        }

        /// <summary>
        /// Clicks on the "here" link on the 404 status code page to load additional content or navigate further.
        /// </summary>
        public void ClickHereLinkFor404()
        {
            driver.FindElement(hereLink).Click();
        }

        /// <summary>
        /// Navigates to the page displaying the 500 status code.
        /// </summary>
        public void NavigateTo500StatusCode()
        {
            driver.FindElement(By.LinkText("500")).Click();
        }

        /// <summary>
        /// Clicks on the "here" link on the 500 status code page to load additional content or navigate further.
        /// </summary>
        public void ClickHereLinkFor500()
        {
            driver.FindElement(hereLink).Click();
        }
    }
}