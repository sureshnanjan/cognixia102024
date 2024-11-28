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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IHorizontalSlider
    {
        /// <summary>
        /// Drags the slider by a specific offset (in pixels).
        /// </summary>
        /// <param name="slider">The slider element to be dragged.</param>
        /// <param name="xOffset">The horizontal offset (in pixels) by which to move the slider.</param>
        void dragSlider(IWebElement slider, int xOffset);

        /// <summary>
        /// Sets the value of the slider directly by sending the specified value through the SendKeys method.
        /// </summary>
        /// <param name="slider">The slider element to be set.</param>
        /// <param name="value">The value to set on the slider.</param>
        void setSliderValue(IWebElement slider, string value);

        /// <summary>
        /// Gets the current value of the slider.
        /// </summary>
        /// <param name="slider">The slider element to retrieve the value from.</param>
        /// <returns>The current value of the slider as a string.</returns>
        string getSliderValue(IWebElement slider);

        /// <summary>
        /// Validates the minimum and maximum values of the slider.
        /// </summary>
        /// <param name="slider">The slider element to validate.</param>
        /// <param name="expectedMinValue">The expected minimum value of the slider.</param>
        /// <param name="expectedMaxValue">The expected maximum value of the slider.</param>
        void validateSliderRange(IWebElement slider, string expectedMinValue, string expectedMaxValue);

        /// <summary>
        /// Performs a mouse hover action on the slider element.
        /// </summary>
        /// <param name="slider">The slider element to hover over.</param>
        void hoverOverSlider(IWebElement slider);
    }
}
