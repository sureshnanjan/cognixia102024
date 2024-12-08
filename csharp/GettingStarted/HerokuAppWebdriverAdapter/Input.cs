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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HerokuAppOperations;
using OpenQA.Selenium.Interactions;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents an input field on the web page.
    /// Provides methods to interact with the input field, including setting, retrieving, and modifying the input field's value.
    /// </summary>
    public class Input : HerokuAppCommon, IInput
    {
        private string inputPageUrl = "https://the-internet.herokuapp.com/inputs";

        /// <summary>
        /// Initializes a new instance of the <see cref="Input"/> class with a specified WebDriver.
        /// Navigates to the input page URL.
        /// </summary>
        /// <param name="driver">The WebDriver instance to be used for interacting with the page.</param>
        public Input(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl(inputPageUrl); // Navigates specifically to the Input page URL
        }

        /// <summary>
        /// Default constructor that initializes a new instance of the <see cref="Input"/> class.
        /// Uses the WebDriver from the base class and navigates to the input page URL.
        /// </summary>
        public Input() : base()
        {
            this.driver.Navigate().GoToUrl(inputPageUrl); // Navigates specifically to the Input page URL
        }

        /// <summary>
        /// Sets a specified value in the input field by locating the input element and sending the value.
        /// Clears the existing value before setting the new one.
        /// </summary>
        /// <param name="value">The value to set in the input field.</param>
        public void SetInputValue(string value)
        {
            try
            {
                // Locate the input field and clear any existing value
                IWebElement inputField = driver.FindElement(By.TagName("input"));
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
                IWebElement inputField = driver.FindElement(By.TagName("input"));
                return inputField.GetAttribute("value");
            }
            catch (NoSuchElementException)
            {
                // Handle case where input field is not found
                Console.WriteLine("Input field not found.");
                return string.Empty;
            }
        }

        /// <summary>
        /// Increments the value of the input field by simulating multiple presses of the Up Arrow key.
        /// </summary>
        /// <param name="times">The number of times to press the Up Arrow key.</param>
        public void IncrementValueUsingArrowKey(int times)
        {
            try
            {
                // Locate the input field and click to focus on it
                IWebElement inputField = driver.FindElement(By.TagName("input"));
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
        /// Decrements the value of the input field by simulating multiple presses of the Down Arrow key.
        /// </summary>
        /// <param name="times">The number of times to press the Down Arrow key.</param>
        public void DecrementValueUsingArrowKey(int times)
        {
            try
            {
                // Locate the input field and click to focus on it
                IWebElement inputField = driver.FindElement(By.TagName("input"));
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

        /// <summary>
        /// Quits the WebDriver session, closing the browser and cleaning up resources.
        /// </summary>
        public void Quit()
        {
            // Assuming this method closes the WebDriver
            driver.Quit();
        }
    }
}
