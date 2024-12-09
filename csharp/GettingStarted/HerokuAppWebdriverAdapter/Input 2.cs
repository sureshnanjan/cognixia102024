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
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Page object representing the input field on the webpage.
    /// Contains methods for interacting with the input field, including setting, getting, 
    /// and modifying the input value using arrow keys.
    /// </summary>
    public class InputField : HerokuAppCommon, IInputField
    {
        // Locator for the input field element
        private readonly By inputFieldLocator = By.TagName("input");

        /// <summary>
        /// Constructor to initialize the page object and navigate to the URL.
        /// </summary>
        /// <param name="driver">The WebDriver instance to interact with the browser.</param>
        public InputField(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/inputs");
        }

        /// <summary>
        /// Sets the specified value in the input field.
        /// </summary>
        /// <param name="value">The value to set in the input field.</param>
        public void SetInputValue(string value)
        {
            try
            {
                // Locate the input field and clear any existing value
                IWebElement inputField = driver.FindElement(inputFieldLocator);
                inputField.Clear();
                // Set the new value in the input field
                inputField.SendKeys(value);
            }
            catch (NoSuchElementException)
            {
                // Handle case where input field is not found
                Console.WriteLine("Input field not found.");
            }
        }

        /// <summary>
        /// Retrieves the current value of the input field.
        /// </summary>
        /// <returns>The current value of the input field.</returns>
        public string GetInputValue()
        {
            try
            {
                // Locate the input field and retrieve its value
                IWebElement inputField = driver.FindElement(inputFieldLocator);
                return inputField.GetAttribute("value");
            }
            catch (NoSuchElementException)
            {
                // Handle case where input field is not found
                Console.WriteLine("Input field not found.");
                return string.Empty;  // Return an empty string if the input field is not found
            }
        }

        /// <summary>
        /// Increments the value of the input field by simulating pressing the Up Arrow Key.
        /// </summary>
        /// <param name="times">The number of times to increment the value.</param>
        public void IncrementValueUsingArrowKey(int times)
        {
            try
            {
                // Locate the input field and click to focus on it
                IWebElement inputField = driver.FindElement(inputFieldLocator);
                inputField.Click();

                // Create a new Actions object to simulate key presses
                Actions actions = new Actions(driver);
                for (int i = 0; i < times; i++)
                {
                    // Simulate pressing the Up Arrow key multiple times
                    actions.SendKeys(Keys.ArrowUp).Perform();
                }
            }
            catch (NoSuchElementException)
            {
                // Handle case where input field is not found
                Console.WriteLine("Input field not found.");
            }
        }

        /// <summary>
        /// Decrements the value of the input field by simulating pressing the Down Arrow Key.
        /// </summary>
        /// <param name="times">The number of times to decrement the value.</param>
        public void DecrementValueUsingArrowKey(int times)
        {
            try
            {
                // Locate the input field and click to focus on it
                IWebElement inputField = driver.FindElement(inputFieldLocator);
                inputField.Click();

                // Create a new Actions object to simulate key presses
                Actions actions = new Actions(driver);
                for (int i = 0; i < times; i++)
                {
                    // Simulate pressing the Down Arrow key multiple times
                    actions.SendKeys(Keys.ArrowDown).Perform();
                }
            }
            catch (NoSuchElementException)
            {
                // Handle case where input field is not found
                Console.WriteLine("Input field not found.");
            }
        }
    }
}
