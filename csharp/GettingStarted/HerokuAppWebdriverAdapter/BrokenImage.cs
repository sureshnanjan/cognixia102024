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
    /// <summary>
    /// Class for validating broken images on a webpage. Inherits common functionality from HerokuAppCommon.
    /// Implements the IBrokenImages interface.
    /// </summary>
    public class BrokenImages : HerokuAppCommon, IBrokenImage
    {
        // Locator for image elements on the page.
        private readonly By imageLocator = By.XPath("//div[@id='content']//img");

        /// <summary>
        /// Initializes a new instance of the BrokenImages class and navigates to the Broken Images page.
        /// </summary>
        /// <param name="driver">The WebDriver instance to interact with the browser.</param>
        public BrokenImages(IWebDriver driver) : base(driver)
        {
            // Navigate to the Broken Images page on Heroku app.
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/broken_images");
        }
        public BrokenImages():base()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/broken_images");
        }

        /// <summary>
        /// Gets the total number of images on the page.
        /// </summary>
        /// <returns>The total count of image elements found on the page.</returns>
        public int GetTotalImageCount()
        {
            try
            {
                // Find all image elements on the page and return their count.
                var imageElements = driver.FindElements(imageLocator);
                return imageElements.Count;
            }
            catch (NoSuchElementException)
            {
                // Return 0 if no image elements are found on the page.
                Console.WriteLine("No images found.");
                return 0;
            }
        }

        /// <summary>
        /// Gets the number of broken images on the page.
        /// </summary>
       
        public int GetBrokenImageCount()
        {
            int brokenImageCount = 0;
            // Find all image elements on the page.
            var imageElements = driver.FindElements(imageLocator);

            foreach (var imageElement in imageElements)
            {
                // Check if each image is broken.
                if (!IsImageBroken(imageElement))
                {
                    brokenImageCount++;
                }
            }

            return brokenImageCount;
        }

        /// <summary>
        /// Checks if a specific image is broken based on its source URL.
        /// </summary>
       
        public bool IsImageBroken(string imageSrc)
        {
            try
            {
                // Find the image by its source URL.
                var image = driver.FindElement(By.XPath($"//img[@src='{imageSrc}']"));
                // Check if the image is broken by looking at its naturalWidth attribute.
                var isBroken = image.GetAttribute("naturalWidth") == "0"; // Broken image will have naturalWidth = 0
                return isBroken;
            }
            catch (NoSuchElementException)
            {
                // Log message if the image source is not found.
                Console.WriteLine($"Image with source {imageSrc} not found.");
                return false;
            }
        }

        /// <summary>
        /// Alternative method to check if an image is broken by inspecting the image element.
        /// This method would typically involve making an HTTP request to validate the image URL's status code.
        /// </summary>
       
        private bool IsImageBroken(IWebElement imageElement)
        {
            var imageUrl = imageElement.GetAttribute("src");
            // Logic to validate image URL (e.g., send HTTP request to check status code) should go here.
            return false; // Simplified assumption, actual implementation would require additional checks (like status codes).
        }
        public string GetPageTitle()
        {
            // Get the page title.
           string title = driver.FindElement(By.TagName("h3")).Text;
            return title ;
        }
    }
}
