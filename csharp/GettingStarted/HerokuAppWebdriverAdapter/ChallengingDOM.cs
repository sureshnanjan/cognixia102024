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
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace HerokuAppWebdriverAdapter
{
    public class ChallengingDOM : IChallengingDOM
    {
        public IWebDriver driver;
        public string url = "https://the-internet.herokuapp.com/challenging_dom";

        // Constructor to initialize the WebDriver
        public void ChallengingDom()
        {
            driver = new ChromeDriver();  // You can also use other drivers like EdgeDriver
        }

        // Method to get the title of the page
        public string GetPageTitle()
        {
            driver.Navigate().GoToUrl(url);
            return driver.Title;
        }

        // Method to get the count of rows in the table
        public int GetTableRowCount()
        {
            driver.Navigate().GoToUrl(url);
            // Use XPath to select all rows of the table excluding the header
            var rows = driver.FindElements(By.XPath("//table[@id='table1']/tbody/tr"));
            return rows.Count;
        }

        // Method to click the Edit button in a specific row (based on index)
        public void ClickEditButton(int rowIndex)
        {
            driver.Navigate().GoToUrl(url);
            // Construct XPath for the edit button for a specific row
            var editButton = driver.FindElement(By.XPath($"//table[@id='table1']/tbody/tr[{rowIndex}]/td[last()]/button[text()='edit']"));
            editButton.Click();
            Console.WriteLine($"Edit button clicked for row {rowIndex}");
        }

        // Method to click the Delete button in a specific row (based on index)
        public void ClickDeleteButton(int rowIndex)
        {
            driver.Navigate().GoToUrl(url);
            // Construct XPath for the delete button for a specific row
            var deleteButton = driver.FindElement(By.XPath($"//table[@id='table1']/tbody/tr[{rowIndex}]/td[last()]/button[text()='delete']"));
            deleteButton.Click();
            Console.WriteLine($"Delete button clicked for row {rowIndex}");
        }

        // Cleanup method to quit the driver
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}