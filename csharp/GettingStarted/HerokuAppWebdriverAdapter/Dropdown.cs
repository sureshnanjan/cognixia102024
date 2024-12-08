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
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Represents a Dropdown element on the webpage.
    /// Provides methods to interact with the dropdown, including selecting options, getting selected options, and retrieving all available options.
    /// </summary>
    public class Dropdown : IDropdown
    {
        private readonly By dropdownLocator = By.Id("dropdown");
        private SelectElement dropdown;
        private IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="Dropdown"/> class.
        /// Launches the ChromeDriver, navigates to the dropdown page, and initializes the dropdown element.
        /// </summary>
        public Dropdown()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
            dropdown = new SelectElement(driver.FindElement(dropdownLocator));
        }

        /// <summary>
        /// Selects an option from the dropdown by its visible text.
        /// If the option is not found, an exception message is logged to the console.
        /// </summary>
        /// <param name="optionText">The visible text of the option to select.</param>
        public void SelectOptionByText(string optionText)
        {
            try
            {
                dropdown.SelectByText(optionText);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine($"Option '{optionText}' not found in the dropdown.");
            }
        }

        /// <summary>
        /// Gets the currently selected option's visible text in the dropdown.
        /// Returns a message if no option is selected.
        /// </summary>
        /// <returns>The visible text of the selected option.</returns>
        public string GetSelectedOptionText()
        {
            try
            {
                return dropdown.SelectedOption.Text;
            }
            catch (NoSuchElementException)
            {
                return "No option is currently selected.";
            }
        }

        /// <summary>
        /// Retrieves all the options available in the dropdown.
        /// </summary>
        /// <returns>A list of strings containing the visible text of all options in the dropdown.</returns>
        public List<string> GetAllOptionsText()
        {
            var optionsList = new List<string>();
            try
            {
                foreach (var option in dropdown.Options)
                {
                    optionsList.Add(option.Text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving dropdown options: {ex.Message}");
            }
            return optionsList;
        }

        /// <summary>
        /// Disposes of the WebDriver and closes the browser.
        /// This is necessary to free up resources and ensure the driver is properly cleaned up.
        /// </summary>
        public void Dispose()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
