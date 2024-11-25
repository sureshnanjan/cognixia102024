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
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    // Class for validating broken images on a webpage
    public class BrokenImage : IBrokenImage
    {
        private readonly IWebDriver _driver; // WebDriver instance for interacting with the browser

        // Constructor initializes the WebDriver (ChromeDriver in this case)
        public BrokenImage()
        {
            _driver = new ChromeDriver(); // Instantiating a Chrome browser driver
        }

        // Method to validate all images on a webpage and return the count of broken images
        public int ValidateImages(string url)
        {
            _driver.Navigate().GoToUrl(url); // Navigate to the specified URL

            // Find all image elements on the page
            IReadOnlyCollection<IWebElement> images = _driver.FindElements(By.TagName("img"));
            int brokenImageCount = 0; // Counter for broken images

            foreach (var image in images) // Iterate through each image element
            {
                string imageUrl = image.GetAttribute("src"); // Get the source URL of the image
                // Check if the image URL is valid and increment the broken image count if not
                if (!string.IsNullOrEmpty(imageUrl) && !IsImageValid(imageUrl))
                {
                    brokenImageCount++;
                }
            }

            return brokenImageCount; // Return the total count of broken images
        }

        // Helper method to validate if the image URL returns a valid response
        private bool IsImageValid(string imageUrl)
        {
            // Create an HTTP request for the image URL
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(imageUrl);
            request.Method = "HEAD"; // Only request the headers to verify the image

            // Get the response and check if the status code is OK
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                return (response.StatusCode == HttpStatusCode.OK); // Returns true if the status code is 200 OK
            }
        }
    }
}
