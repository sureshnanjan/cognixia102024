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

using HerokuAppWebdriverAdapter;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test suite for validating redirection to different status code pages
    /// using the HerokuApp sample application.
    /// </summary>
    [TestFixture]
    public class RedirectTests
    {
        private IWebDriver driver;
        private RedirectPage redirectPage;

        /// <summary>
        /// Sets up the test environment by initializing the WebDriver 
        /// and navigating to the base URL of the HerokuApp.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            redirectPage = new RedirectPage(driver);
        }

        /// <summary>
        /// Cleans up the test environment by quitting the WebDriver instance.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        /// <summary>
        /// Test to verify redirection to a page with a 200 status code.
        /// </summary>
        [Test]
        public void RedirectTo200StatusCode()
        {
            redirectPage.ClickRedirectLink();
            redirectPage.ClickRedirectButton();
            redirectPage.NavigateTo200StatusCode();
            redirectPage.ClickHereLinkFor200();
        }


        /// <summary>
        /// Test to verify redirection to a page with a 301 status code.
        /// </summary>
        [Test]
        public void RedirectTo301StatusCode()
        {
            redirectPage.ClickRedirectLink();
            redirectPage.ClickRedirectButton();
            redirectPage.NavigateTo301StatusCode();
            redirectPage.ClickHereLinkFor301();
        }


        /// <summary>
        /// Test to verify redirection to a page with a 404 status code.
        /// </summary>
        [Test]
        public void RedirectTo404StatusCode()
        {
            redirectPage.ClickRedirectLink();
            redirectPage.ClickRedirectButton();
            redirectPage.NavigateTo404StatusCode();
            redirectPage.ClickHereLinkFor404();
        }


        /// <summary>
        /// Test to verify redirection to a page with a 500 status code.
        /// </summary>
        [Test]
        public void RedirectTo500StatusCode()
        {
            redirectPage.ClickRedirectLink();
            redirectPage.ClickRedirectButton();
            redirectPage.NavigateTo500StatusCode();
            redirectPage.ClickHereLinkFor500();
        }


    }

}