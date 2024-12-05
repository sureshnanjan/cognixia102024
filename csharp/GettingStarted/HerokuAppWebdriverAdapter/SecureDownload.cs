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
using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Page object model for interacting with the "Download Secure" page on the HerokuApp website.
    /// This class provides methods for retrieving the page title, checking the visibility of the download link,
    /// and clicking the download link.
    /// </summary>
    public class DownloadSecurePage : HerokuAppCommon, IDownloadSecurePage
    {
        private By downloadLink; // Locator for the download link element

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadSecurePage"/> class.
        /// Sets up the WebDriver and defines the download link locator.
        /// </summary>
        /// <param name="driver">The WebDriver instance used to interact with the browser.</param>
        public DownloadSecurePage(IWebDriver driver) : base(driver)
        {
            // XPath for the download link (this is just an example, make sure to use the actual link text or XPath)
            downloadLink = By.LinkText("some-file.txt");
        }

        /// <summary>
        /// Gets the title of the "Download Secure" page.
        /// </summary>
        /// <returns>The title text of the page.</returns>
        public string GetPageTitle()
        {
            // Locate the heading element and return its text value.
            IWebElement headingElement = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/h3"));
            return headingElement.Text;
        }

        /// <summary>
        /// Checks if the download link is visible on the page.
        /// </summary>
        /// <returns>True if the download link is visible; otherwise, false.</returns>
        public bool IsDownloadLinkVisible()
        {
            try
            {
                // Attempt to locate the download link and check if it's displayed
                IWebElement linkElement = driver.FindElement(downloadLink);
                return linkElement.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the link is not found, return false
                return false;
            }
        }

        /// <summary>
        /// Clicks the download link to initiate the file download.
        /// </summary>
        public void ClickDownloadLink()
        {
            // Locate the download link and click it to start the download process.
            IWebElement linkElement = driver.FindElement(downloadLink);
            linkElement.Click();
        }
    }
}


