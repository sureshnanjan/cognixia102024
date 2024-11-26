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

using OpenQA.Selenium.Interactions;

using System;

using HerokuAppOperations;

namespace HerokuAppWebdriverAdapter

{

    /// <summary>

    /// The HorizontalSlider class is responsible for interacting with horizontal sliders on the Heroku App page.

    /// It extends the HerokuAppCommon class and implements the IHorizontalSlider interface.

    /// This class provides methods to perform actions like dragging the slider, setting its value,

    /// getting its value, hovering over the slider, and validating its range.

    /// </summary>

    public class HorizontalSlider : HerokuAppCommon, IHorizontalSlider

    {

        /// <summary>

        /// Initializes a new instance of the HorizontalSlider class, passing the WebDriver to the base class.

        /// </summary>

        /// <param name="driver">The WebDriver instance used to interact with the web page.</param>

        public HorizontalSlider(IWebDriver driver) : base(driver) { }

        /// <summary>

        /// Drags the slider by a specific horizontal offset (in pixels).

        /// </summary>

        /// <param name="slider">The slider element to be dragged.</param>

        /// <param name="xOffset">The horizontal offset (in pixels) by which to move the slider.</param>

        public void dragSlider(IWebElement slider, int xOffset)

        {

            // Create an instance of Actions class to perform complex user interactions

            Actions actions = new Actions(driver);

            // Perform the drag action: click and hold on the slider, move horizontally by xOffset, and release

            actions.ClickAndHold(slider)  // Click and hold on the slider element

                   .MoveByOffset(xOffset, 0)  // Move slider by the specified xOffset horizontally (no vertical movement)

                   .Release()  // Release the slider after dragging

                   .Perform();  // Execute the action sequence

            // Log the action to the console for debugging or reporting

            Console.WriteLine($"Slider dragged by {xOffset}px.");

        }

        /// <summary>

        /// Gets the current value of the slider.

        /// </summary>

        /// <param name="slider">The slider element to retrieve the value from.</param>

        /// <returns>The current value of the slider as a string.</returns>

        public string getSliderValue(IWebElement slider)

        {

            // Get the 'value' attribute of the slider which stores the current position/percentage value

            string value = slider.GetAttribute("value");

            // Log the current value of the slider to the console

            Console.WriteLine($"Current slider value: {value}");

            // Return the current value of the slider

            return value;

        }

        /// <summary>

        /// Hovers over the slider element (moves the mouse over the slider without interacting with it).

        /// </summary>

        /// <param name="slider">The slider element to hover over.</param>

        public void hoverOverSlider(IWebElement slider)

        {

            // Create an instance of Actions class for performing the hover action

            Actions actions = new Actions(driver);

            // Move the mouse over the slider element (hover over it)

            actions.MoveToElement(slider).Perform();

            // Log the hover action to the console

            Console.WriteLine("Hovered over the slider.");

        }

        /// <summary>

        /// Sets the value of the slider by typing a value into the input field associated with the slider.

        /// </summary>

        /// <param name="slider">The slider element where the value is to be set.</param>

        /// <param name="value">The value to set on the slider.</param>

        public void setSliderValue(IWebElement slider, string value)

        {

            // Clear the current value in the slider input field before setting a new value

            slider.Clear();

            // Send the new value to the slider input field (simulating user typing)

            slider.SendKeys(value);

            // Log the action of setting the new value to the console

            Console.WriteLine($"Slider value set to {value}.");

        }

        /// <summary>

        /// Validates that the slider's range matches the expected minimum and maximum values.

        /// </summary>

        /// <param name="slider">The slider element whose range is to be validated.</param>

        /// <param name="expectedMinValue">The expected minimum value of the slider.</param>

        /// <param name="expectedMaxValue">The expected maximum value of the slider.</param>

        public void validateSliderRange(IWebElement slider, string expectedMinValue, string expectedMaxValue)

        {

            // Get the 'min' and 'max' attributes of the slider which define its valid range

            string minValue = slider.GetAttribute("min");

            string maxValue = slider.GetAttribute("max");

            // Compare the actual 'min' and 'max' values with the expected values

            if (minValue == expectedMinValue && maxValue == expectedMaxValue)

            {

                // If the actual values match the expected values, log success

                Console.WriteLine($"Slider range is correct: Min = {minValue}, Max = {maxValue}");

            }

            else

            {

                // If the values do not match, log the discrepancy

                Console.WriteLine($"Slider range is incorrect! Expected: Min = {expectedMinValue}, Max = {expectedMaxValue}, " +

                                  $"Actual: Min = {minValue}, Max = {maxValue}");

            }

        }

    }

}

