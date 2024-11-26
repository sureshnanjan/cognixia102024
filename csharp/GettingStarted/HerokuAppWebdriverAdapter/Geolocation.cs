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

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// A class that provides operations for interacting with the Geolocation page.
    /// This class uses Selenium WebDriver to simulate actions such as clicking a button to get location details 
    /// and displaying those details in maps.
    /// </summary>
    public class Geolocation : HerokuAppCommon, IGeolocation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Geolocation"/> class with the provided WebDriver.
        /// </summary>
        /// <param name="driver">The WebDriver instance used for browser interaction.</param>
        public Geolocation(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Clicks the "Where am I?" button to retrieve the user's current geolocation.
        /// This simulates a user clicking on a button on the page to get location details.
        /// </summary>
        public void OnclickWhereami()
        {
            // Find the button element by its tag name and click it to retrieve geolocation
            driver.FindElement(By.TagName("button")).Click();
        }

        /// <summary>
        /// Retrieves the latitude and longitude details from the page.
        /// This method interacts with the page elements that display the user's location.
        /// </summary>
        public void GetLocationDetails()
        {
            // Find the latitude value element by its ID and store it in a variable
            var lati = driver.FindElement(By.Id("lat-value"));

            // Find the longitude value element by its ID and store it in a variable
            var longi = driver.FindElement(By.Id("long-value"));

            // Optionally, you can log or return these values for further use
            Console.WriteLine("Latitude: " + lati.Text);
            Console.WriteLine("Longitude: " + longi.Text);
        }

        /// <summary>
        /// Clicks the "Show in Maps" link to display the user's geolocation on a map.
        /// This simulates a user clicking the link to view the location on a map interface.
        /// </summary>
        public void OnclickShowInMaps()
        {
            // Find the "Show in Maps" link by its ID and click it
            var map = driver.FindElement(By.Id("map-link"));
            map.Click();
        }
    }
}
