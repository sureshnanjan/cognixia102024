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
using OpenQA.Selenium;

namespace HerokuAppOperations
{
    /// <summary>
    /// Defines a contract for horizontal slider operations in a Heroku app.
    /// </summary>
    public interface IHorizontalSlider
    {
        void dragSlider(IWebElement slider, int xOffset);
        void setSliderValue(IWebElement slider, string value);
        string getSliderValue(IWebElement slider);
        void validateSliderRange(IWebElement slider, string expectedMinValue, string expectedMaxValue);
        void hoverOverSlider(IWebElement slider);
    }

    /// <summary>
    /// Stub implementation of IHorizontalSlider for testing purposes.
    /// </summary>
    public class HorizontalSliderStub : IHorizontalSlider
    {
        public bool IsDragSliderCalled { get; private set; }
        public bool IsSetSliderValueCalled { get; private set; }
        public bool IsGetSliderValueCalled { get; private set; }
        public bool IsValidateSliderRangeCalled { get; private set; }
        public bool IsHoverOverSliderCalled { get; private set; }

        public string CurrentSliderValue { get; private set; } = "0";

        public void dragSlider(IWebElement slider, int xOffset)
        {
            IsDragSliderCalled = true;
            // Simulating slider dragging effect by updating the value (mocked)
            CurrentSliderValue = (int.Parse(CurrentSliderValue) + xOffset).ToString();
        }

        public void setSliderValue(IWebElement slider, string value)
        {
            IsSetSliderValueCalled = true;
            CurrentSliderValue = value;
        }

        public string getSliderValue(IWebElement slider)
        {
            IsGetSliderValueCalled = true;
            return CurrentSliderValue;
        }

        public void validateSliderRange(IWebElement slider, string expectedMinValue, string expectedMaxValue)
        {
            IsValidateSliderRangeCalled = true;
            // Stub logic: Assume range validation always passes
        }

        public void hoverOverSlider(IWebElement slider)
        {
            IsHoverOverSliderCalled = true;
        }
    }

    /// <summary>
    /// NUnit tests for the IHorizontalSlider interface using the HorizontalSliderStub.
    /// </summary>
    [TestFixture]
    public class HorizontalSliderTests
    {
        private HorizontalSliderStub _sliderStub;
        private IWebElement _dummySlider;

        [SetUp]
        public void SetUp()
        {
            _sliderStub = new HorizontalSliderStub();
            _dummySlider = null; // Using null for test purposes, as no real interaction is required.
        }

        [Test]
        public void DragSlider_ShouldUpdateSliderValueAndFlag()
        {
            // Arrange
            int xOffset = 10;

            // Act
            _sliderStub.dragSlider(_dummySlider, xOffset);

            // Assert
            Assert.IsTrue(_sliderStub.IsDragSliderCalled, "dragSlider should set IsDragSliderCalled to true.");
            Assert.AreEqual("10", _sliderStub.CurrentSliderValue, "dragSlider should update the CurrentSliderValue.");
        }

        [Test]
        public void SetSliderValue_ShouldUpdateSliderValueAndFlag()
        {
            // Arrange
            string newValue = "50";

            // Act
            _sliderStub.setSliderValue(_dummySlider, newValue);

            // Assert
            Assert.IsTrue(_sliderStub.IsSetSliderValueCalled, "setSliderValue should set IsSetSliderValueCalled to true.");
            Assert.AreEqual("50", _sliderStub.CurrentSliderValue, "setSliderValue should update the CurrentSliderValue.");
        }

        [Test]
        public void GetSliderValue_ShouldReturnCurrentSliderValueAndFlag()
        {
            // Act
            string sliderValue = _sliderStub.getSliderValue(_dummySlider);

            // Assert
            Assert.IsTrue(_sliderStub.IsGetSliderValueCalled, "getSliderValue should set IsGetSliderValueCalled to true.");
            Assert.AreEqual("0", sliderValue, "getSliderValue should return the CurrentSliderValue.");
        }

        [Test]
        public void ValidateSliderRange_ShouldSetFlag()
        {
            // Arrange
            string expectedMinValue = "0";
            string expectedMaxValue = "100";

            // Act
            _sliderStub.validateSliderRange(_dummySlider, expectedMinValue, expectedMaxValue);

            // Assert
            Assert.IsTrue(_sliderStub.IsValidateSliderRangeCalled, "validateSliderRange should set IsValidateSliderRangeCalled to true.");
        }

        [Test]
        public void HoverOverSlider_ShouldSetFlag()
        {
            // Act
            _sliderStub.hoverOverSlider(_dummySlider);

            // Assert
            Assert.IsTrue(_sliderStub.IsHoverOverSliderCalled, "hoverOverSlider should set IsHoverOverSliderCalled to true.");
        }
    }
}