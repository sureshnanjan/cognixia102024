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

