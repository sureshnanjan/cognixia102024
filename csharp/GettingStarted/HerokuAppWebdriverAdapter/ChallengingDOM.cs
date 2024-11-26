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

using HerokuAppOperations; // Importing the custom namespace that contains the IChallengingDOM interface
using OpenQA.Selenium.Edge; // Importing the Edge WebDriver class for Microsoft Edge browser (if you wish to use Edge instead of Chrome)
using OpenQA.Selenium.Support.UI; // Importing the WebDriver's support for waiting mechanisms (not used in the current code)
using OpenQA.Selenium; // Importing the main Selenium WebDriver classes, such as IWebDriver, By, and other utilities
using System; // Importing System namespace for fundamental types like Console, String, etc.
using System.Collections.Generic; // Importing collections like List, Dictionary, etc. (not used in the current code)
using System.Linq; // Importing LINQ utilities for querying collections (not used in the current code)
using System.Text; // Importing the Text namespace for string manipulation (not used in the current code)
using System.Threading.Tasks; // Importing support for asynchronous tasks (not used in the current code)
using OpenQA.Selenium.Chrome; // Importing the Chrome WebDriver class for using Google Chrome browser

// Defining a namespace for this class
namespace HerokuAppWebdriverAdapter
{
    // Class ChallengingDOM implements the IChallengingDOM interface, providing specific implementations for the methods
    public class ChallengingDOM : IChallengingDOM
    {
        // Declaring a private WebDriver object that will be used to interact with the browser
        public IWebDriver driver;

        // Declaring a string to hold the URL of the page we are testing
        public string url = "https://the-internet.herokuapp.com/challenging_dom";

        // Constructor for the ChallengingDOM class, initializing the WebDriver
        // This constructor is meant to set up the driver (which in this case uses ChromeDriver)
        public void ChallengingDom()
        {
            // Instantiating the ChromeDriver to control the Chrome browser
            driver = new ChromeDriver();  // ChromeDriver can be replaced with EdgeDriver if you want to use Edge browser
        }

        // Method to get the title of the page, returns the title of the current page as a string
        public string GetPageTitle()
        {
            // Navigates to the specified URL
            driver.Navigate().GoToUrl(url);

            // Returns the title of the page
            return driver.Title;
        }

        // Method to get the count of rows in the table on the page
        // It returns the number of table rows (excluding the header row)
        public int GetTableRowCount()
        {
            // Navigates to the specified URL
            driver.Navigate().GoToUrl(url);

            // Uses XPath to find all rows in the table (ignores the header row by targeting tbody/tr)
            var rows = driver.FindElements(By.XPath("//table[@id='table1']/tbody/tr"));

            // Returns the count of rows found in the table
            return rows.Count;
        }

        // Method to simulate clicking the Edit button for a specific row based on its index
        // The rowIndex parameter specifies which row’s Edit button to click
        public void ClickEditButton(int rowIndex)
        {
            // Navigates to the specified URL
            driver.Navigate().GoToUrl(url);

            // Constructs an XPath expression to locate the Edit button for the specified rowIndex
            // It selects the last column of the row and looks for the button with the text 'edit'
            var editButton = driver.FindElement(By.XPath($"//table[@id='table1']/tbody/tr[{rowIndex}]/td[last()]/button[text()='edit']"));

            // Clicks the Edit button
            editButton.Click();

            // Prints a message to the console indicating which row's Edit button was clicked
            Console.WriteLine($"Edit button clicked for row {rowIndex}");
        }

        // Method to simulate clicking the Delete button for a specific row based on its index
        // The rowIndex parameter specifies which row’s Delete button to click
        public void ClickDeleteButton(int rowIndex)
        {
            // Navigates to the specified URL
            driver.Navigate().GoToUrl(url);

            // Constructs an XPath expression to locate the Delete button for the specified rowIndex
            // It selects the last column of the row and looks for the button with the text 'delete'
            var deleteButton = driver.FindElement(By.XPath($"//table[@id='table1']/tbody/tr[{rowIndex}]/td[last()]/button[text()='delete']"));

            // Clicks the Delete button
            deleteButton.Click();

            // Prints a message to the console indicating which row's Delete button was clicked
            Console.WriteLine($"Delete button clicked for row {rowIndex}");
        }

        // Cleanup method to properly close and quit the WebDriver instance
        // This ensures that the WebDriver instance is terminated after use
        public void Cleanup()
        {
            // Closes the browser and ends the WebDriver session
            driver.Quit();
        }
    }
}
