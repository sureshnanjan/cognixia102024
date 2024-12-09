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
using HerokuAppWebdriverAdapter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppWebdriverTests
{
    /// <summary>
    /// Test suite for validating broken images on the Heroku app page.
    /// </summary>
    [TestFixture]
    public class BrokenImagesTests
    {
        //private IWebDriver driver;
        IBrokenImages brokenImages = (IBrokenImages)new BrokenImages();

        /// <summary>
        /// Setup method that is run before each test.
        /// Initializes the WebDriver and the BrokenImages page object.
        /// </summary>
        [SetUp]
        public void Setup() 
        {
            // Initialize the ChromeDriver for interacting with the browser.
            //driver = new ChromeDriver();
            // Create an instance of BrokenImages to interact with the Broken Images page.
            //brokenImages = new BrokenImages(driver);
            
    }

        /// <summary>
        /// Test to validate the total number of images present on the page.
        /// </summary>
        [Test]
        public void ValidateTotalImageCount()
        {
            int expectedminnumofimages = 0;
            // Get the total number of images on the page.
            int totalImages = brokenImages.GetTotalImageCount();

            // Assert that the number of images is greater than zero, ensuring images exist on the page.
            Assert.Greater(totalImages, expectedminnumofimages, "No images found on the page.");
            // Log the total number of images for debugging purposes.
            Console.WriteLine($"Total images on the page: {totalImages}");
        }

        /// <summary>
        /// Test to validate the number of broken images on the page.
        /// </summary>
        [Test]
        public void ValidateBrokenImagesCount()
        {
            // Get the total number of broken images on the page.
            int brokenImagesCount = brokenImages.GetBrokenImageCount();
            int Expectedcount = 3;

            // Assert that the number of broken images is as expected (e.g., 3 in this case).
            Assert.AreEqual(Expectedcount, brokenImagesCount, "The number of broken images is incorrect.");
            // Log the count of broken images for verification.
            Console.WriteLine($"Number of broken images: {brokenImagesCount}");
        }



        [Test]
        public void TestPageTitle()
        {
            // Arrange: Expected title for the Broken Images page.
            string expectedTitle = "Broken Images";

            // Act: Get the actual title.
            string actualTitle = brokenImages.GetPageTitle();

            Console.WriteLine(actualTitle);

            // Assert: Verify that the title matches the expected title.
            Assert.AreEqual(expectedTitle, actualTitle, "Page title does not match.");
        }


        /// <summary>
        /// TearDown method that is run after each test.
        /// Closes the browser and cleans up resources.
        /// </summary>
        /// 

        [TearDown]
        public void TearDown()
        {


            brokenImages.QuitDriver();

        }

    }
}