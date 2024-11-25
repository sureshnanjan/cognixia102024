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
    public class HoverActions : HerokuAppCommon, IHoverAction
    {
        private readonly IWebDriver _driver;

        public HoverActions(IWebDriver driver)
        {
            _driver = driver;
        }

        // Hover over the specified element (image in this case)
        public void hoverOverElement(IWebElement element)
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(element).Perform();  // Perform hover action
            Console.WriteLine("Hovered over the element.");
        }

        // Validate that the content appears after hovering (check if user name or link becomes visible)
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

        // Click on the revealed link (after hover)
        public void clickOnRevealedLink(IWebElement link)
        {
            link.Click();  // Click on the revealed link
            Console.WriteLine("Clicked on the revealed link.");
        }
    }
}
