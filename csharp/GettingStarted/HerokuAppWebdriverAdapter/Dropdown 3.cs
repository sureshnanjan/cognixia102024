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
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppWebdriverAdapter;
using HerokuAppOperations;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Provides functionality for interacting with dropdown elements in Selenium.
    /// </summary>
    public class Dropdown : HerokuAppCommon, IDropdown
    {
        // Locator to identify the dropdown element on the page.
        private readonly By dropdownLocator = By.Id("dropdown");

        // The SelectElement is used to interact with dropdowns in Selenium.
        private readonly SelectElement dropdown;

        /// <summary>
        /// Constructor initializes the dropdown element and navigates to the page.
        /// </summary>
        /// <param name="driver">The WebDriver instance used to interact with the page.</param>
        public Dropdown(IWebDriver driver) : base(driver)
        {
            // Navigate to the target page with the dropdown.
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");

            try
            {
                // Locate the dropdown element and initialize the SelectElement.
                dropdown = new SelectElement(driver.FindElement(dropdownLocator));
            }
            catch (NoSuchElementException)
            {
                // Handle case where dropdown element is not found on the page.
                Console.WriteLine("Dropdown element not found.");
            }
        }

        /// <summary>
        /// Selects an option from the dropdown by its visible text.
        /// </summary>
        /// <param name="optionText">The visible text of the option to select.</param>
        public void SelectOptionByText(string optionText)
        {
            try
            {
                // Select the option from the dropdown by its visible text.
                dropdown.SelectByText(optionText);
            }
            catch (NoSuchElementException)
            {
                // Handle case where the specified option is not found in the dropdown.
                Console.WriteLine($"Option '{optionText}' not found in the dropdown.");
            }
        }

        /// <summary>
        /// Retrieves the text of the currently selected option in the dropdown.
        /// </summary>
        /// <returns>The text of the selected option, or a message if no option is selected.</returns>
        public string GetSelectedOptionText()
        {
            try
            {
                // Return the text of the currently selected option.
                return dropdown.SelectedOption.Text;
            }
            catch (NoSuchElementException)
            {
                // Handle case where no option is currently selected.
                return "No option is currently selected.";
            }
        }

        /// <summary>
        /// Retrieves all the options available in the dropdown as a list of strings.
        /// </summary>
        /// <returns>A list of strings containing the text of all dropdown options.</returns>
        public List<string> GetAllOptionsText()
        {
            var optionsList = new List<string>();
            try
            {
                // Iterate through all the options in the dropdown and add their text to the list.
                foreach (var option in dropdown.Options)
                {
                    optionsList.Add(option.Text);
                }
            }
            catch (Exception ex)
            {
                // Handle any exception that occurs while retrieving dropdown options.
                Console.WriteLine($"Error retrieving dropdown options: {ex.Message}");
            }
            return optionsList;
        }
    }
}
