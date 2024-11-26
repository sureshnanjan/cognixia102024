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
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class AddRemove : IAddRemove
    {
        public IWebDriver driver;

        // Constructor to initialize WebDriver (e.g., ChromeDriver)
        public void AddRemoveElements()
        {
            // Initialize ChromeDriver (or any other browser driver, e.g., EdgeDriver)
            driver = new ChromeDriver();
        }

        // Method to get the title of the page
        public string getTitle()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
            return driver.Title;
        }

        // Method to add a new element by clicking the "Add Element" button
        public void AddElement()
        {
            IWebElement addButton = driver.FindElement(By.XPath("//button[text()='Add Element']"));
            addButton.Click();
        }

        // Method to delete an element by clicking the "Delete" button next to it
        public void DeleteElement()
        {
            var deleteButton = driver.FindElements(By.XPath("//button[text()='Delete']")).LastOrDefault();
            if (deleteButton != null)
            {
                deleteButton.Click();
            }
            else
            {
                Console.WriteLine("No elements to delete.");
            }
        }

        // Method to get the count of elements currently on the page
        public int GetCountofElements()
        {
            var addedElements = driver.FindElements(By.ClassName("added-manually"));
            return addedElements.Count;
        }

        // Cleanup: Close the browser after the test
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}

