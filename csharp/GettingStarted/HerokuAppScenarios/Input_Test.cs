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
using NUnit.Framework;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class to validate the functionality of input fields on a webpage.
    /// It includes tests for setting, retrieving, and modifying the input field's value.
    /// </summary>
    [TestFixture]
    public class InputFieldTests
    {
        private IInput input;

        /// <summary>
        /// Setup method to initialize the Input page object.
        /// This runs before each test method to set up the test environment.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Arrange: Initialize the Input class instance.
            input = new Input(); // Initialize Input class with default constructor
        }

        /// <summary>
        /// Test to validate setting and retrieving the value of an input field.
        /// </summary>
        [Test]
        public void ValidateInputField_SetAndRetrieveValue()
        {
            // Arrange: Define the expected value for the input field.
            string expectedValue = "12345";

            // Act: Set the value in the input field and retrieve it.
            input.SetInputValue(expectedValue);
            string actualValue = input.GetInputValue();

            // Assert: Verify that the actual value matches the expected value.
            Assert.AreEqual(expectedValue, actualValue, "Input value does not match the expected value.");
        }

        /// <summary>
        /// Test to validate incrementing the value of the input field using the up arrow key.
        /// </summary>
        [Test]
        public void ValidateIncrementUsingArrowKey()
        {
            // Arrange: Set the initial value of the input field to "0".
            input.SetInputValue("0");

            // Act: Increment the value 5 times using the up arrow key.
            input.IncrementValueUsingArrowKey(5);

            // Assert: Get the current value and verify it has been incremented correctly.
            string actualValue = input.GetInputValue();
            Assert.AreEqual("5", actualValue, "The value after incrementing 5 times is incorrect.");
        }

        /// <summary>
        /// Test to validate decrementing the value of the input field using the down arrow key.
        /// </summary>
        [Test]
        public void ValidateDecrementUsingArrowKey()
        {
            // Arrange: Set the initial value of the input field to "10".
            input.SetInputValue("10");

            // Act: Decrement the value 3 times using the down arrow key.
            input.DecrementValueUsingArrowKey(3);

            // Assert: Get the current value and verify it has been decremented correctly.
            string actualValue = input.GetInputValue();
            Assert.AreEqual("7", actualValue, "The value after decrementing 3 times is incorrect.");
        }

        /// <summary>
        /// TearDown method to clean up after each test.
        /// Closes the WebDriver and terminates the browser session.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Act: Cleanup and close the browser session.
            input.Quit(); // Assuming `Quit` is a method in `IInput` that closes the browser
        }
    }
}
