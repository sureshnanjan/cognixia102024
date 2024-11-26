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

namespace HerokuAppOperations
{
    /// <summary>
    /// Implementation of ISortableTables interface for interacting with a sortable table on a webpage.
    /// </summary>
    public class SortableTables : ISortableTables
    {
        private readonly IWebDriver _driver;
        private readonly By _tableLocator;

        // Constructor to initialize the IWebDriver and the table locator.
        public SortableTables(IWebDriver driver)
        {
            _driver = driver;
            _tableLocator = By.XPath("//table"); // Locator for the table, you can adjust this if there are multiple tables on the page.
        }

        /// <summary>
        /// Gets the data from a specific cell in the table.
        /// </summary>
        /// <param name="rowIndex">The zero-based index of the row.</param>
        /// <param name="columnIndex">The zero-based index of the column.</param>
        /// <returns>A string representing the data at the specified row and column.</returns>
        public string GetRowData(int rowIndex, int columnIndex)
        {
            try
            {
                // Find the table element
                IWebElement table = _driver.FindElement(_tableLocator);

                // Get all rows from the table
                var rows = table.FindElements(By.TagName("tr"));

                // Ensure the row exists
                if (rowIndex < 0 || rowIndex >= rows.Count)
                    throw new ArgumentOutOfRangeException(nameof(rowIndex), "Row index is out of range.");

                // Get the desired row and column
                var row = rows[rowIndex];
                var cells = row.FindElements(By.TagName("td"));

                // Ensure the column exists
                if (columnIndex < 0 || columnIndex >= cells.Count)
                    throw new ArgumentOutOfRangeException(nameof(columnIndex), "Column index is out of range.");

                return cells[columnIndex].Text;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error getting data from row {rowIndex}, column {columnIndex}: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets the total number of rows in the table.
        /// </summary>
        /// <returns>The number of rows in the table.</returns>
        public int GetRowCount()
        {
            try
            {
                IWebElement table = _driver.FindElement(_tableLocator);
                var rows = table.FindElements(By.TagName("tr"));
                return rows.Count - 1; // Assuming the first row is the header, so we subtract 1.
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error getting row count: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets the total number of columns in the table.
        /// </summary>
        /// <returns>The number of columns in the table.</returns>
        public int GetColumnCount()
        {
            try
            {
                IWebElement table = _driver.FindElement(_tableLocator);
                var headerRow = table.FindElements(By.TagName("tr"))[0]; // Assuming the first row is the header
                var columns = headerRow.FindElements(By.TagName("th"));
                return columns.Count;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error getting column count: {ex.Message}");
            }
        }

        /// <summary>
        /// Sorts the table by a specific column.
        /// </summary>
        /// <param name="columnIndex">The zero-based index of the column to sort by.</param>
        public void SortByColumn(int columnIndex)
        {
            try
            {
                IWebElement table = _driver.FindElement(_tableLocator);
                var headerRow = table.FindElements(By.TagName("tr"))[0]; // Assuming the first row is the header
                var columnHeader = headerRow.FindElements(By.TagName("th"))[columnIndex];

                // Perform the sorting action by clicking on the column header
                columnHeader.Click();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error sorting the table by column {columnIndex}: {ex.Message}");
            }
        }
    }
}
