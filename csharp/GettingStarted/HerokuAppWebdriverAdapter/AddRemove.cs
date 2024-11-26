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

using HerokuAppOperations; // Importing the custom namespace that contains the IAddRemove interface.
using OpenQA.Selenium.Chrome; // Importing the ChromeDriver class to control the Chrome browser for Selenium tests.
using OpenQA.Selenium; // Importing the main Selenium WebDriver classes, such as IWebDriver, By, and other utilities.
using System; // Importing the System namespace for fundamental types like Console, String, etc.
using System.Collections.Generic; // Importing collections like List, Dictionary, etc. (not used in the current code)
using System.Linq; // Importing LINQ utilities for querying collections (used for LastOrDefault in the DeleteElement method)
using System.Text; // Importing the Text namespace for string manipulation (not used in the current code)
using System.Threading.Tasks; // Importing support for asynchronous tasks (not used in the current code)

namespace HerokuAppWebdriverAdapter
{
    // The AddRemove class implements the IAddRemove interface, providing specific implementations for adding and removing elements.
    public class AddRemove : IAddRemove
    {
        // Declaring a private WebDriver object that will be used to interact with the browser.
        public IWebDriver driver;

        // Constructor to initialize the WebDriver (e.g., ChromeDriver for Chrome browser)
        public void AddRemoveElements()
        {
            // Initializing ChromeDriver which will control the Chrome browser during tests.
            // You can replace ChromeDriver with EdgeDriver or another browser's driver if desired.
            driver = new ChromeDriver();
        }

        // Method to get the title of the page.
        // It navigates to the "Add/Remove Elements" page and returns the page's title.
        public string getTitle()
        {
            // Navigating to the "Add/Remove Elements" page.
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");

            // Returning the title of the current page.
            return driver.Title;
        }

        // Method to add a new element by clicking the "Add Element" button.
        // It finds the "Add Element" button by its XPath and clicks it to add a new element.
        public void AddElement()
        {
            // Finding the "Add Element" button on the page using XPath.
            IWebElement addButton = driver.FindElement(By.XPath("//button[text()='Add Element']"));

            // Clicking the "Add Element" button to add a new element on the page.
            addButton.Click();
        }

        // Method to delete an element by clicking the "Delete" button next to it.
        // It looks for the "Delete" button and clicks the last one (if there are multiple).
        public void DeleteElement()
        {
            // Finding all "Delete" buttons on the page (these buttons are next to each added element).
            // The LastOrDefault ensures we click the most recently added "Delete" button, or nothing if none exist.
            var deleteButton = driver.FindElements(By.XPath("//button[text()='Delete']")).LastOrDefault();

            // If the "Delete" button exists (i.e., if there are any added elements), it clicks the last one.
            if (deleteButton != null)
            {
                deleteButton.Click();
            }
            else
            {
                // If there are no elements to delete (no "Delete" button found), print a message.
                Console.WriteLine("No elements to delete.");
            }
        }

        // Method to get the count of elements currently on the page.
        // It finds all elements with the class name "added-manually", which are the elements that were added.
        public int GetCountofElements()
        {
            // Finding all elements with the class "added-manually" (these represent the elements that were added by clicking "Add Element").
            var addedElements = driver.FindElements(By.ClassName("added-manually"));

            // Returning the count of the added elements (i.e., how many have been added).
            return addedElements.Count;
        }

        // Cleanup: Close the browser after the test.
        // This ensures that the WebDriver session is properly ended and the browser is closed after test execution.
        public void Cleanup()
        {
            // Calling driver.Quit() to close the browser and end the WebDriver session.
            driver.Quit();
        }
    }
}


