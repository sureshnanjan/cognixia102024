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
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Handles file download operations in the Heroku app.
    /// </summary>
    public class FileDownload : HerokuAppCommon, IFileDownload
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDownload"/> class with the specified WebDriver.
        /// </summary>
        /// <param name="driver">The WebDriver instance used to interact with the browser.</param>
        public FileDownload(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Initiates the download of a specific file by clicking the file link on the webpage.
        /// </summary>
        public void Download()
        {
            // Locate the file download link using its text
            IWebElement FileElement = driver.FindElement(By.XPath("//a[contains(text(),'Дз занятие 20.pdf')]"));

            // Pause briefly to ensure readiness before clicking the link
            Thread.Sleep(3000);

            // Click the file element to trigger the download
            FileElement.Click();
        }
    }
}
