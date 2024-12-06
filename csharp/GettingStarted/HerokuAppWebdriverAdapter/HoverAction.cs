
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
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// The HoverActions class is responsible for handling hover-related actions on elements, such as images or links.
    /// It implements the IHoverAction interface and provides methods to perform hover actions, validate visibility of content after hovering, 
    /// and click on revealed links or content.
    /// </summary>
    public class HoverActions : HerokuAppCommon, IHoverAction
    {
        // Locator for hoverable figure containers
        private readonly By figureLocator = By.CssSelector(".figure");
        private readonly By contentLocator = By.CssSelector(".figcaption h5");
        private readonly By linkLocator = By.CssSelector(".figcaption a");

        /// <summary>
        /// Initializes a new instance of the <see cref="HoverActions"/> class.
        /// </summary>
        /// <param name="driver">The WebDriver instance used to interact with the page.</param>
        public HoverActions(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Hovers over the specified element to reveal associated content.
        /// </summary>
        /// <param name="element">The WebElement to hover over.</param>
        public void HoverOverElement(IWebElement element)
        {
            // Perform hover action using Actions class
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Perform();
            Console.WriteLine("Hovered over the element.");
        }

        /// <summary>
        /// Validates that the content becomes visible after hovering over a figure element.
        /// </summary>
        /// <param name="element">The figure element to validate content for.</param>
        /// <returns>True if the content is visible; otherwise, false.</returns>
        public bool ValidateContentAppears(IWebElement element)
        {
            try
            {
                // Find the content within the hovered figure
                IWebElement content = element.FindElement(contentLocator);
                return content.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false; // Content is not visible
            }
        }

        /// <summary>
        /// Clicks on the revealed link within the hovered figure.
        /// </summary>
        /// <param name="element">The figure element containing the link.</param>
        public void ClickOnRevealedLink(IWebElement element)
        {
            try
            {
                // Locate and click the link
                IWebElement link = element.FindElement(linkLocator);
                link.Click();
                Console.WriteLine("Clicked on the revealed link.");
            }
            catch (NoSuchElementException)
            {
                throw new InvalidOperationException("Link not found within the hovered element.");
            }
        }
    }
}

