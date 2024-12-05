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
using OpenQA.Selenium.Support.UI;
using System;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents the CheckBox page and provides methods to interact with the checkboxes on the page.
    /// Extends the HerokuAppCommon class and implements the ICheckBox interface.
    /// </summary>
    public class CheckBox : HerokuAppCommon, ICheckBox
    {
        // Locators for the two checkboxes
        private By checkbox1;
        private By checkbox2;

        /// <summary>
        /// Initializes a new instance of the CheckBox class with a provided WebDriver.
        /// </summary>
        /// <param name="arg">WebDriver instance for browser interactions.</param>
        public CheckBox(IWebDriver arg) : base(arg)
        {
            // Locators for the checkboxes
            this.checkbox1 = By.XPath("//*[@id='checkboxes']/input[1]"); // Locator for the first checkbox
            this.checkbox2 = By.XPath("//*[@id='checkboxes']/input[2]"); // Locator for the second checkbox
        }

        /// <summary>
        /// Default constructor for the CheckBox class.
        /// Navigates directly to the checkboxes page upon initialization.
        /// </summary>
        public CheckBox() : base()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");

            // Ensure locators are initialized here as well
            this.checkbox1 = By.XPath("//*[@id='checkboxes']/input[1]");
            this.checkbox2 = By.XPath("//*[@id='checkboxes']/input[2]");
        }

        /// <summary>
        /// Gets the title of the Checkboxes page.
        /// </summary>
        /// <returns>The page heading as a string.</returns>
        public string getTitle()
        {
            IWebElement headingElement = driver.FindElement(By.XPath("//h3[normalize-space()='Checkboxes']"));
            return headingElement.Text;
        }

        /// <summary>
        /// Gets the status (checked/unchecked) of the first checkbox.
        /// </summary>
        /// <returns>True if the first checkbox is selected; otherwise, false.</returns>
        public bool getCheckboxOneDefaultStatus()
        {
            IWebElement checkboxElement = driver.FindElement(checkbox1); // Use the locator for checkbox 1
            return checkboxElement.Selected;
        }

        /// <summary>
        /// Gets the status (checked/unchecked) of the second checkbox.
        /// </summary>
        /// <returns>True if the second checkbox is selected; otherwise, false.</returns>
        public bool getCheckboxTwoDefaultStatus()
        {
            IWebElement checkboxElement = driver.FindElement(checkbox2); // Use the locator for checkbox 2
            return checkboxElement.Selected;
        }

        /// <summary>
        /// Toggles the state of the first checkbox.
        /// </summary>
        public void ClickCheckboxOne()
        {
            IWebElement checkboxElement = driver.FindElement(checkbox1); // Ensure checkbox1 is not null
            checkboxElement.Click(); // Toggle the checkbox
        }

        /// <summary>
        /// Toggles the state of the second checkbox.
        /// </summary>
        public void ClickCheckboxTwo()
        {
            IWebElement checkboxElement = driver.FindElement(checkbox2); // Ensure checkbox2 is not null
            checkboxElement.Click(); // Toggle the checkbox
        }
    }
}
