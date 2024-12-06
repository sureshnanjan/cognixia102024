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

using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HerokuAppOperations;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for verifying hover-related actions on individual elements using the HoverActions class.
    /// </summary>
    [TestFixture]
    public class HoverActionsTests
    {
        private IWebDriver _driver;
        private HoverActions _hoverActions;

        /// <summary>
        /// Initializes the test environment by setting up the WebDriver and navigating to the base URL.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");
            _hoverActions = new HoverActions(_driver);
        }

        /// <summary>
        /// Cleans up the test environment by quitting the WebDriver instance.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        /// <summary>
        /// Verifies that hovering over the first figure reveals its associated content.
        /// </summary>
        [Test]
        public void HoverOverFirstFigureAndValidateContent()
        {
            var firstFigure = _driver.FindElements(By.CssSelector(".figure"))[0];
            _hoverActions.HoverOverElement(firstFigure);

            Assert.IsTrue(_hoverActions.ValidateContentAppears(firstFigure),
                "Content for the first figure should be visible after hover.");
        }

        /// <summary>
        /// Verifies that hovering over the second figure reveals its associated content.
        /// </summary>
        [Test]
        public void HoverOverSecondFigureAndValidateContent()
        {
            var secondFigure = _driver.FindElements(By.CssSelector(".figure"))[1];
            _hoverActions.HoverOverElement(secondFigure);

            Assert.IsTrue(_hoverActions.ValidateContentAppears(secondFigure),
                "Content for the second figure should be visible after hover.");
        }

        /// <summary>
        /// Verifies that hovering over the third figure reveals its associated content.
        /// </summary>
        [Test]
        public void HoverOverThirdFigureAndValidateContent()
        {
            var thirdFigure = _driver.FindElements(By.CssSelector(".figure"))[2];
            _hoverActions.HoverOverElement(thirdFigure);

            Assert.IsTrue(_hoverActions.ValidateContentAppears(thirdFigure),
                "Content for the third figure should be visible after hover.");
        }

        /// <summary>
        /// Tests hovering over the first figure, clicking its link, and verifying navigation to the correct profile URL.
        /// </summary>
        [Test]
        public void HoverOverFirstFigureAndClickLink()
        {
            var firstFigure = _driver.FindElements(By.CssSelector(".figure"))[0];
            _hoverActions.HoverOverElement(firstFigure);

            var link = firstFigure.FindElement(By.CssSelector(".figcaption a"));
            _hoverActions.ClickOnRevealedLink(firstFigure);

            Assert.IsTrue(_driver.Url.Contains("users/1"),
                "Should navigate to the first user profile URL.");
        }

        /// <summary>
        /// Tests hovering over the second figure, clicking its link, and verifying navigation to the correct profile URL.
        /// </summary>
        [Test]
        public void HoverOverSecondFigureAndClickLink()
        {
            var secondFigure = _driver.FindElements(By.CssSelector(".figure"))[1];
            _hoverActions.HoverOverElement(secondFigure);

            var link = secondFigure.FindElement(By.CssSelector(".figcaption a"));
            _hoverActions.ClickOnRevealedLink(secondFigure);

            Assert.IsTrue(_driver.Url.Contains("users/2"),
                "Should navigate to the second user profile URL.");
        }

        /// <summary>
        /// Tests hovering over the third figure, clicking its link, and verifying navigation to the correct profile URL.
        /// </summary>
        [Test]
        public void HoverOverThirdFigureAndClickLink()
        {
            var thirdFigure = _driver.FindElements(By.CssSelector(".figure"))[2];
            _hoverActions.HoverOverElement(thirdFigure);

            var link = thirdFigure.FindElement(By.CssSelector(".figcaption a"));
            _hoverActions.ClickOnRevealedLink(thirdFigure);

            Assert.IsTrue(_driver.Url.Contains("users/3"),
                "Should navigate to the third user profile URL.");
        }
    }
}