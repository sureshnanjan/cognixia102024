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
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1;

namespace HerokuAppOperations
{
    /// <summary>
    /// Test suite for verifying the behavior of nested frames using Selenium WebDriver.
    /// </summary>
    [TestFixture]
    public class NestedFramesTests
    {
        private ChromeDriver driver; // WebDriver instance for browser automation.
        private NestedFrames nestedFrames; // Instance of the NestedFrames class to interact with the frames.

        /// <summary>
        /// Initializes the WebDriver and sets up the NestedFrames instance before each test.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(); // Initialize the Chrome WebDriver.
            nestedFrames = new NestedFrames(driver); // Create an instance of the NestedFrames class.
        }

        /// <summary>
        /// Validates that the top frame exists and retrieves the correct content.
        /// </summary>
        [Test]
        public void ValidateTopFrameExists()
        {
            // Get the text from the top frame.
            string topFrameContent = nestedFrames.GetTopFrameText();

            // Assert that the top frame content matches the expected value.
            Assert.AreEqual("Top Frame (No direct text to retrieve)", topFrameContent, "Top frame validation failed.");
        }

        /// <summary>
        /// Validates that the bottom frame contains content and prints it to the console.
        /// </summary>
        [Test]
        public void ValidateBottomFrameContent()
        {
            // Get the text from the bottom frame.
            string bottomFrameContent = nestedFrames.GetBottomFrameText();

            // Assert that the bottom frame content is not empty.
            Assert.IsNotEmpty(bottomFrameContent, "Bottom frame content is empty.");

            // Print the content of the bottom frame for debugging purposes.
            Console.WriteLine($"Bottom Frame Content: {bottomFrameContent}");
        }

        /// <summary>
        /// Validates that the left frame inside the top frame contains the expected content.
        /// </summary>
        [Test]
        public void ValidateLeftFrameContent()
        {
            // Get the text from the left frame.
            string leftFrameContent = nestedFrames.GetLeftFrameText();

            // Assert that the left frame content matches the expected value.
            Assert.AreEqual("LEFT", leftFrameContent, "Left frame content is incorrect.");
        }

        /// <summary>
        /// Validates that the middle frame inside the top frame contains the expected content.
        /// </summary>
        [Test]
        public void ValidateMiddleFrameContent()
        {
            // Get the text from the middle frame.
            string middleFrameContent = nestedFrames.GetMiddleFrameText();

            // Assert that the middle frame content matches the expected value.
            Assert.AreEqual("MIDDLE", middleFrameContent, "Middle frame content is incorrect.");
        }

        /// <summary>
        /// Validates that the right frame inside the top frame contains the expected content.
        /// </summary>
        [Test]
        public void ValidateRightFrameContent()
        {
            // Get the text from the right frame.
            string rightFrameContent = nestedFrames.GetRightFrameText();

            // Assert that the right frame content matches the expected value.
            Assert.AreEqual("RIGHT", rightFrameContent, "Right frame content is incorrect.");
        }

        /// <summary>
        /// Cleans up and closes the browser after each test.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Quit the WebDriver and close the browser.
            driver.Quit();
            driver.Dispose();
        }
    }
}
