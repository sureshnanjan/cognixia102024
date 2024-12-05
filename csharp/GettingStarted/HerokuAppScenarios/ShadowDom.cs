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
using HerokuAppWebdriverAdapter;
using NUnit.Framework;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for verifying operations with Shadow DOM elements.
    /// </summary>
    [TestFixture]
    public class ShadowDomTests
    {
        private ShadowDom shadowDom; // Custom ShadowDom helper class to interact with Shadow DOM

        /// <summary>
        /// SetUp method that initializes the ShadowDom instance.
        /// This method is executed before each test.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize ShadowDom instance with the WebDriver.
            shadowDom = new ShadowDom(new OpenQA.Selenium.Chrome.ChromeDriver());
        }

        /// <summary>
        /// Test method that validates the text inside the Shadow DOM.
        /// </summary>
        [Test]
        public void ValidateShadowDomText()
        {
            // Arrange: No specific arrangement needed as ShadowDom handles navigation and element interaction.

            // Act: Retrieve the text content inside the Shadow DOM.
            string shadowText = shadowDom.GetShadowText();

            // Assert: Validate that the Shadow DOM text content is empty (adjust based on expected outcome).
            Assert.IsEmpty(shadowText, "Shadow DOM text content is empty.");
            Console.WriteLine($"Simple template: {shadowText}");
        }

        /// <summary>
        /// TearDown method that closes the WebDriver after each test.
        /// This method is executed after each test.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Clean up the WebDriver after test execution.
            shadowDom.CleanUp();
        }
    }
}
