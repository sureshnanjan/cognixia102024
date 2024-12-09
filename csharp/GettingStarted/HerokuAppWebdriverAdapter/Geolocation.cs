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
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using HerokuAppOperations;
using System;

namespace HerokuAppOperations
{
    /// <summary>
    /// Implementation of geolocation interactions on the HerokuApp website.
    /// </summary>
    public class Geolocation : IGeolocation
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        /// <summary>
        /// Initializes a new instance of the <see cref="Geolocation"/> class.
        /// Sets up the WebDriver and WebDriverWait.
        /// </summary>
        public Geolocation()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// Navigates to the Geolocation page.
        /// </summary>
        public void NavigateToGeolocationPage()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/geolocation");
        }

        /// <summary>
        /// Requests the user's location by clicking the "Where am I?" button.
        /// </summary>
        public void RequestLocation()
        {
            IWebElement locationButton = driver.FindElement(By.XPath("//button[text()='Where am I?']"));
            locationButton.Click();
        }

        /// <summary>
        /// Gets the latitude displayed on the page.
        /// </summary>
        /// <returns>The latitude as a string, or null if not found.</returns>
        public string GetLatitude()
        {
            try
            {
                IWebElement latitudeElement = wait.Until(d =>
                    d.FindElement(By.Id("lat-value")));
                return latitudeElement.Text;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the longitude displayed on the page.
        /// </summary>
        /// <returns>The longitude as a string, or null if not found.</returns>
        public string GetLongitude()
        {
            try
            {
                IWebElement longitudeElement = wait.Until(d =>
                    d.FindElement(By.Id("long-value")));
                return longitudeElement.Text;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }


        /// <summary>
        /// Clicks the "See it on Google" link to verify if it redirects correctly.
        /// </summary>
        public string ClickSeeItOnGoogle()
        {
            try
            {
                IWebElement googleLink = wait.Until(d => d.FindElement(By.LinkText("See it on Google")));
                string href = googleLink.GetAttribute("href");
                googleLink.Click();
                return href;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public string GetPageTitle()
        {
            return driver.FindElement(By.TagName("h3")).Text;
        }

        public string GetPageDescription()
        {
            return driver.FindElement(By.TagName("p")).Text;
        }

        /// <summary>
        /// Closes the browser and cleans up resources.
        /// </summary>
        public void Close()
        {
            driver.Quit();
        }
    }
}

