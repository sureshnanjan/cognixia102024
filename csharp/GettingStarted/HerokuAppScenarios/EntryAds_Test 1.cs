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
*/using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.BiDi.Modules.Log;
using HerokuAppWebdriverAdapter;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test suite for verifying the behavior of the Entry Advertisement modal.
    /// </summary>
    [TestFixture]
    public class EntryAdTests
    {
        private IWebDriver driver;
        private EntryAd entryAdPage;

        /// <summary>
        /// Setup method to initialize WebDriver and the EntryAd page object.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Instantiate the ChromeDriver and EntryAd page object.
            driver = new ChromeDriver();
            entryAdPage = new EntryAd(driver);
        }

        /// <summary>
        /// Test to validate that the modal is displayed when the page loads.
        /// </summary>
        [Test]
        public void ValidateModalIsDisplayedOnLoad()
        {
            // Check if the modal is displayed.
            bool isModalDisplayed = entryAdPage.IsModalDisplayed();
            // Assert that the modal is displayed.
            Assert.IsTrue(isModalDisplayed, "Modal is not displayed on page load.");
        }

        /// <summary>
        /// Test to validate that the modal body content matches the expected value.
        /// </summary>
        [Test]
        public void ValidateModalBodyContent()
        {
            // Expected body content of the modal.
            string expectedBodyContent = "It's commonly used to encourage a user to take an action (e.g., give their e-mail address to sign up for something or disable their ad blocker).";
            // Get the actual body content from the modal.
            string actualBodyContent = entryAdPage.GetModalBodyContent();
            // Log the debug information for expected and actual body content.
            Console.WriteLine($"Debug: Expected Body Content: '{expectedBodyContent}'");
            Console.WriteLine($"Debug: Actual Body Content: '{actualBodyContent}'");
            // Assert that the actual body content matches the expected value.
            Assert.AreEqual(expectedBodyContent, actualBodyContent, "The modal body content does not match the expected value.");
        }

        /// <summary>
        /// Test to validate that the modal closes when the CloseModal method is called.
        /// </summary>
        [Test]
        public void ValidateCloseModal()
        {
            // Close the modal.
            entryAdPage.CloseModal();
            // Assert that the modal is no longer displayed.
            Assert.IsFalse(entryAdPage.IsModalDisplayed(), "Modal did not close as expected.");
        }

        /// <summary>
        /// Cleanup method to quit the WebDriver after each test is executed.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Quit the WebDriver session after the test.
            driver.Quit();
            driver.Dispose();
        }
    }
}
