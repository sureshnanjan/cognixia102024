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
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppWebdriverTests
{
    /// <summary>
    /// Test suite for validating the A/B Test functionality on the Heroku app.
    /// </summary>
    [TestFixture]
    public class ABTestTests
    {
        IABTest abTest;

        //    HomePage page = new HomePage();
        //    var abpage = page.navigateToExample("ABTesting");

        //    string[] expected = { "Variation 1", "Variation 2" };
        //}
        /// <summary>
        /// Setup method that is run before each test.
        /// Initializes the WebDriver and the ABTest page object.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize the ChromeDriver for interacting with the browser.
            //driver = new ChromeDriver();
            // Create an instance of ABTest to interact with the A/B Test page.
            abTest = (IABTest)new ABTest();
        }

        /// <summary>
        /// Test to validate that the A/B Test message is displayed correctly.
        /// </summary>
        [Test]
        public void ValidateABTestTitle()
        {
            string expectedText = "A/B Test Variation 1";

            // Get the A/B test message
            string abTestMessage = abTest.GetABTestMessage();

            // Assert that the message matches the expected value
            Assert.AreEqual(expectedText, abTestMessage, "The A/B Test message did not match the expected value.");

            // Log the A/B Test message
            Console.WriteLine($"A/B Test Message: {abTestMessage}");
        }

        /// <summary>
        /// Test to validate that the current URL is correct.
        /// </summary>
        [Test]
        public void ValidateCurrentUrl()
        {
            // Get the current URL from the browser.
            string currentUrl = abTest.GetCurrentUrl();

            // Define the expected URL for the A/B Test page.
            string expectedUrl = "https://the-internet.herokuapp.com/abtest";
            // Assert that the current URL matches the expected URL.
            Assert.AreEqual(expectedUrl, currentUrl, "The current URL does not match the expected URL.");
            // Log the current URL for debugging purposes.
            Console.WriteLine($"Current URL: {currentUrl}");
        }
        [TearDown]
        public void TearDown()
        {
            // Close the WebDriver after tests
            abTest.QuitDriver();
        }
        /// <summary>
        /// TearDown method that is run after each test.
        /// Closes the browser and cleans up resources.
        /// </summary>
        //[TearDown]
        //public void TearDown()
        //{
        //    // Close the browser and clean up WebDriver resources.
        //    driver.Quit();
        //}
    }
}