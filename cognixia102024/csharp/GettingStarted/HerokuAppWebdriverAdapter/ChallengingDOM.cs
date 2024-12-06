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
using OpenQA.Selenium.Chrome;
//using System.Windows.Forms; // Importing the Chrome WebDriver class for using Google Chrome browser

// Defining a namespace for this class
namespace HerokuAppWebdriverAdapter
{

    public class ChallengingDOM : HerokuAppCommon,IChallengingDOM
    {
        //public IWebDriver driver;
        public string url = "https://the-internet.herokuapp.com/challenging_dom";

        // Constructor to initialize the WebDriver
        public ChallengingDOM(IWebDriver driver) : base(driver) { }
        public ChallengingDOM() : base() { }


        //Class ChallengingDOM implements the IChallengingDOM interface, providing specific implementations for the methods



        // Method to get the title of the page, returns the title of the current page as a string
        public string GetPageTitle()
        {
            // Navigates to the specified URL
            driver.Navigate().GoToUrl(url);

            // Returns the title of the page
            //return driver.Title;
            IWebElement elem = driver.FindElement(By.XPath("//h3[normalize-space()='Challenging DOM']"));
            return elem.Text;
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
        public bool ClickEditButton(int rowIndex)
        {
            // Navigates to the specified URL
            driver.Navigate().GoToUrl(url);

            // Construct XPath for the edit button for a specific row
            //var editButton = driver.FindElement(By.XPath($"//table[@id='table1']/tbody/tr[{rowIndex}]/td[last()]/button[text()='edit']"));
            var editButton = driver.FindElement(By.XPath($"\r\n//body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/table[1]/tbody[1]/tr[{rowIndex}]/td[7]/a[1]"));
            // Clicks the Edit button
            editButton.Click();
            Console.WriteLine($"Edit button clicked for row {rowIndex}");
            return driver.Url.Contains("edit");
            // Prints a message to the console indicating which row's Edit button was clicked
        }

        // Method to simulate clicking the Delete button for a specific row based on its index
        // The rowIndex parameter specifies which row’s Delete button to click
        public bool ClickDeleteButton(int rowIndex)
        {
            // Navigates to the specified URL
            driver.Navigate().GoToUrl(url);

            // Construct XPath for the delete button for a specific row
            //var deleteButton = driver.FindElement(By.XPath($"//table[@id='table1']/tbody/tr[{rowIndex}]/td[last()]/button[text()='delete']"));
            var deleteButton = driver.FindElement(By.XPath($"\r\n//body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/table[1]/tbody[1]/tr[{rowIndex}]/td[7]/a[2]"));


            // Clicks the Delete button

            deleteButton.Click();

            // Prints a message to the console indicating which row's Delete button was clicked
            Console.WriteLine($"Delete button clicked for row {rowIndex}");
            return driver.Url.Contains("delete");

        }
        public bool ClickFirstButton()
        {
            driver.Navigate().GoToUrl(url);
            IReadOnlyCollection<IWebElement> links = driver.FindElements(By.CssSelector("a.button"));

            //IReadOnlyCollection<IWebElement> links = driver.FindElements(By.ClassName("button"));
            IWebElement prev = driver.FindElement(By.XPath("//a[@id='45cbbf40-9203-013d-7f68-22bb049c88e5']"));
            Console.WriteLine(links);
            //int cnt = 0;
            //foreach (IWebElement element in links)
            //{
            //Console.WriteLine(element.Text);
            //cnt++;
            //}
            //Console.WriteLine(cnt);
            String prevText = links.ElementAt(0).Text;
            IWebElement screenPrev = driver.FindElement(By.XPath("//canvas[@id='canvas']"));
            String prevScreenText = screenPrev.Text;
            links.ElementAt(0).Click();
            IReadOnlyCollection<IWebElement> links2 = driver.FindElements(By.ClassName("button"));
            String currText = links2.ElementAt(0).Text;
            String currScreenText = driver.FindElement(By.XPath("//canvas[@id='canvas']")).Text;
            return (!(prevText.Equals(currText))) && (!(prevScreenText.Equals(currScreenText)));
            //return true;
        }

        public bool ClickSecondButton()
        {
            IReadOnlyCollection<IWebElement> links = driver.FindElements(By.ClassName("button"));
            //IWebElement prev = driver.FindElement(By.XPath("//a[@id='45cbbf40-9203-013d-7f68-22bb049c88e5']"));
            String prevText = links.ElementAt(1).Text;
            IWebElement screenPrev = driver.FindElement(By.XPath("//canvas[@id='canvas']"));
            String prevScreenText = screenPrev.Text;
            links.ElementAt(1).Click();
            IReadOnlyCollection<IWebElement> links2 = driver.FindElements(By.ClassName("button"));
            String currText = links2.ElementAt(1).Text;
            String currScreenText = driver.FindElement(By.XPath("//canvas[@id='canvas']")).Text;
            return (!(prevText.Equals(currText))) && (!(prevScreenText.Equals(currScreenText)));
            //IWebElement prev = driver.FindElement(By.XPath("//a[@id='878e9f10-9207-013d-8289-22bb049c88e5']"));
            //String prevText = prev.Text;
            //IWebElement screenPrev = driver.FindElement(By.XPath("//canvas[@id='canvas']"));
            //String prevScreenText = screenPrev.Text;
            //prev.Click();
            //String currText = driver.FindElement(By.XPath("//a[@id='878e9f10-9207-013d-8289-22bb049c88e5']")).Text;
            //String currScreenText = driver.FindElement(By.XPath("//canvas[@id='canvas']")).Text;
            //return (!(prevText.Equals(currText))) && (!(prevScreenText.Equals(currScreenText)));

        }
        public bool ClickThirdButton()
        {
            IReadOnlyCollection<IWebElement> links = driver.FindElements(By.ClassName("button"));
            //IWebElement prev = driver.FindElement(By.XPath("//a[@id='45cbbf40-9203-013d-7f68-22bb049c88e5']"));
            String prevText = links.ElementAt(2).Text;
            IWebElement screenPrev = driver.FindElement(By.XPath("//canvas[@id='canvas']"));
            String prevScreenText = screenPrev.Text;
            links.ElementAt(2).Click();
            IReadOnlyCollection<IWebElement> links2 = driver.FindElements(By.ClassName("button"));
            String currText = links2.ElementAt(2).Text;
            String currScreenText = driver.FindElement(By.XPath("//canvas[@id='canvas']")).Text;
            return (!(prevText.Equals(currText))) && (!(prevScreenText.Equals(currScreenText)));
            //IWebElement prev = driver.FindElement(By.XPath("//a[@id='878eaef0-9207-013d-828a-22bb049c88e5']"));
            //String prevText = prev.Text;
            //IWebElement screenPrev = driver.FindElement(By.XPath("//canvas[@id='canvas']"));
            //String prevScreenText = screenPrev.Text;
            //prev.Click();
            //String currText = driver.FindElement(By.XPath("//a[@id='878eaef0-9207-013d-828a-22bb049c88e5']")).Text;
            //String currScreenText = driver.FindElement(By.XPath("//canvas[@id='canvas']")).Text;
            //return (!(prevText.Equals(currText))) && (!(prevScreenText.Equals(currScreenText)));
        }

        public void Cleanup()
        {
            // Closes the browser and ends the WebDriver session
            driver.Quit();
        }
    }
}
