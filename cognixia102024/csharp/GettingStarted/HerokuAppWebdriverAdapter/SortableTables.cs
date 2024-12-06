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

using HerokuAppWebdriverAdapter; // Importing the HerokuAppWebdriverAdapter namespace for common web driver functionalities.
using OpenQA.Selenium; // Importing the Selenium WebDriver namespace for browser automation.
using OpenQA.Selenium.Interactions; // Importing the Selenium Interactions namespace for advanced user interactions.
using System; // Importing the System namespace for basic functionalities like string manipulation and console output.

namespace HerokuAppOperations
{
    /// <summary>
    /// Implementation of ISortableTables interface for interacting with a sortable table on a webpage.
    /// </summary>
    public class SortableTables : HerokuAppCommon, ISortableTables
    {
        /// <summary>
        /// Constructor that initializes the SortableTables class with a given WebDriver instance.
        /// Navigates to the sortable tables page on the Heroku app.
        /// </summary>
        /// <param name="driver">The WebDriver instance to use for browser automation.</param>
        public SortableTables(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            Thread.Sleep(3000); // Wait for 3 seconds to ensure the page loads completely.
        }

        /// <summary>
        /// Default constructor that initializes the SortableTables class with the default WebDriver instance.
        /// Navigates to the sortable tables page on the Heroku app.
        /// </summary>
        public SortableTables()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            Thread.Sleep(3000); // Wait for 3 seconds to ensure the page loads completely.
        }

        /// <summary>
        /// Gets the number of columns in the sortable table.
        /// </summary>
        /// <returns>The number of columns in the table.</returns>
        public int GetColumnCount()
        {
            return 6; // Returns the fixed number of columns in the table.
        }

        /// <summary>
        /// Gets the number of rows in the sortable table.
        /// </summary>
        /// <returns>The number of rows in the table.</returns>
        public int GetRowCount()
        {
            return 5; // Returns the fixed number of rows in the table.
        }

        /// <summary>
        /// Gets the data from a specific cell in the sortable table.
        /// </summary>
        /// <param name="rowIndex">The row index of the cell.</param>
        /// <param name="columnIndex">The column index of the cell.</param>
        /// <returns>The text content of the specified cell.</returns>
        public string GetRowData(int rowIndex, int columnIndex)
        {
            String path = $"//body[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[{rowIndex}]/td[{columnIndex}]";
            IWebElement val = driver.FindElement(By.XPath(path));
            return val.Text; // Returns the text content of the specified cell.
        }

        /// <summary>
        /// Sorts the table by a specified column and checks if the sort was successful.
        /// </summary>
        /// <param name="Column">The name of the column to sort by.</param>
        /// <returns>True if the sort was successful, otherwise false.</returns>
        public bool SortByColumn(String Column)
        {
            try
            {
                // Get the text of a specific cell before sorting.
                String Text1 = GetRowData(3, 3);
                String path = $"//span[text()='{Column}']";
                IWebElement spanElement = driver.FindElement(By.XPath(path));
                spanElement.Click(); // Click the column header to sort the table.

                // Get the text of the same cell after sorting.
                String Text2 = GetRowData(3, 3);
                return (!Text1.Equals(Text2)); // Return true if the cell content has changed, indicating a successful sort.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // Print the exception message to the console.
                return false; // Return false if an exception occurs.
            }
        }
        public void Quit()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }

    }
}