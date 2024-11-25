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
    // The HorizontalSlider class is responsible for interacting with horizontal sliders on the Heroku App page
    // It extends HerokuAppCommon and implements IHorizontalSlider interface
    public class HorizontalSlider : HerokuAppCommon, IHorizontalSlider
    {
        // Constructor: Initializes the driver and passes it to the base class HerokuAppCommon
        public HorizontalSlider(IWebDriver driver) : base(driver) { }

        // Method to drag the slider by a specific horizontal offset (in pixels)
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

        // Method to get the current value of the slider
        public string getSliderValue(IWebElement slider)
        {
            // Get the 'value' attribute of the slider which stores the current position/percentage value
            string value = slider.GetAttribute("value");

            // Log the current value of the slider to the console
            Console.WriteLine($"Current slider value: {value}");

            // Return the current value of the slider
            return value;
        }

        // Method to hover over the slider (move the mouse over the slider without interacting with it)
        public void hoverOverSlider(IWebElement slider)
        {
            // Create an instance of Actions class for performing the hover action
            Actions actions = new Actions(driver);

            // Move the mouse over the slider element (hover over it)
            actions.MoveToElement(slider).Perform();

            // Log the hover action to the console
            Console.WriteLine("Hovered over the slider.");
        }

        // Method to set the value of the slider by typing a value into the input field
        public void setSliderValue(IWebElement slider, string value)
        {
            // Clear the current value in the slider input field before setting a new value
            slider.Clear();

            // Send the new value to the slider input field (simulating user typing)
            slider.SendKeys(value);

            // Log the action of setting the new value to the console
            Console.WriteLine($"Slider value set to {value}.");
        }

        // Method to validate that the slider's range matches the expected min and max values
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
