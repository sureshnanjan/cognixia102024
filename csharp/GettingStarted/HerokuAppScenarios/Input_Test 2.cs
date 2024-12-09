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
using HerokuAppWebdriverAdapter;
using HerokuAppOperations;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class to validate the functionality of input fields on a webpage.
    /// It includes tests for setting, retrieving, and modifying the input field's value.
    /// </summary>
    [TestFixture]
    public class InputFieldTests
    {
        private IWebDriver driver;  // WebDriver to interact with the browser
        private InputField inputField;  // Page object representing the input field

        /// <summary>
        /// Setup method to initialize the WebDriver and the InputField page object.
        /// This runs before each test method.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize the ChromeDriver (browser) and create the InputField page object
            driver = new ChromeDriver();
            inputField = new InputField(driver);
        }

        /// <summary>
        /// Test to validate setting and retrieving the value of an input field.
        /// </summary>
        [Test]
        public void ValidateInputField_SetAndRetrieveValue()
        {
            // Set a known value in the input field
            string expectedValue = "12345";
            inputField.SetInputValue(expectedValue);

            // Get the current value from the input field
            string actualValue = inputField.GetInputValue();

            // Validate that the actual value matches the expected value
            Assert.AreEqual(expectedValue, actualValue, "Input value does not match the expected value.");
        }

        /// <summary>
        /// Test to validate incrementing the value of the input field using the arrow key.
        /// </summary>
        [Test]
        public void ValidateIncrementUsingArrowKey()
        {
            // Set the initial value of the input field to "0"
            inputField.SetInputValue("0");

            // Increment the value 5 times using the up arrow key
            inputField.IncrementValueUsingArrowKey(5);

            // Get the current value and validate it has been incremented correctly
            string actualValue = inputField.GetInputValue();
            Assert.AreEqual("5", actualValue, "The value after incrementing 5 times is incorrect.");
        }

        /// <summary>
        /// Test to validate decrementing the value of the input field using the arrow key.
        /// </summary>
        [Test]
        public void ValidateDecrementUsingArrowKey()
        {
            // Set the initial value of the input field to "10"
            inputField.SetInputValue("10");

            // Decrement the value 3 times using the down arrow key
            inputField.DecrementValueUsingArrowKey(3);

            // Get the current value and validate it has been decremented correctly
            string actualValue = inputField.GetInputValue();
            Assert.AreEqual("7", actualValue, "The value after decrementing 3 times is incorrect.");
        }

        /// <summary>
        /// TearDown method to clean up after each test.
        /// Closes the WebDriver and terminates the browser session.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();// Close the browser
        }
    }
}
