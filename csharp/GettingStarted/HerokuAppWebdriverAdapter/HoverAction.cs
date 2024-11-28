
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private readonly IWebDriver _driver;

        /// <summary>
        /// Initializes a new instance of the HoverActions class.
        /// </summary>
        /// <param name="driver">The WebDriver instance used to interact with the web page.</param>
        public HoverActions(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Hovers over the specified element (such as an image or button).
        /// </summary>
        /// <param name="element">The element to hover over.</param>
        public void hoverOverElement(IWebElement element)
        {
            // Create an instance of Actions class to perform the hover action
            Actions actions = new Actions(_driver);
            actions.MoveToElement(element).Perform();  // Perform hover action
            Console.WriteLine("Hovered over the element.");
        }

        /// <summary>
        /// Validates that the content (such as a username or link) becomes visible after hovering over the specified element.
        /// </summary>
        /// <param name="element">The element over which the hover action is performed.</param>
        /// <returns>Returns true if the content appears after hover, otherwise false.</returns>
        public bool validateContentAppears(IWebElement element)
        {
            try
            {
                // Find the content (like username or link) after hovering
                IWebElement content = element.FindElement(By.XPath(".//div[@class='figcaption']//h5"));
                return content.Displayed; // Return true if content is visible after hover
            }
            catch (NoSuchElementException)
            {
                return false; // Return false if content doesn't appear
            }
        }

        /// <summary>
        /// Clicks on the revealed link or content that appears after hovering over the specified element.
        /// </summary>
        /// <param name="link">The revealed link or content to click.</param>
        public void clickOnRevealedLink(IWebElement link)
        {
            // Click on the revealed link or content
            link.Click();
            Console.WriteLine("Clicked on the revealed link.");
        }
    }
}

