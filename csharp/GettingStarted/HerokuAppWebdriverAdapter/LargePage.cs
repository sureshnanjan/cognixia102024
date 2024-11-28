// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using HerokuAppOperations;  // Import the HerokuAppOperations namespace for common operations related to HerokuApp.
using OpenQA.Selenium;  // Import Selenium WebDriver interface for automating browser interactions.
using System;  // Import System namespace for basic system functionality.
using System.Collections.Generic;  // Import collections to work with lists or dictionaries.
using System.Linq;  // Import LINQ for querying collections.
using System.Text;  // Import StringBuilder and other utilities for text manipulation.
using System.Threading.Tasks;  // Import Task for handling asynchronous operations.

namespace HerokuAppWebdriverAdapter
{
    // The LargePage class represents the page with a large DOM on the HerokuApp.
    // It inherits from HerokuAppCommon (which likely contains common logic for interacting with web pages).
    // It implements the ILargePage interface, which defines methods for retrieving the page's title and content.
    public class LargePage : HerokuAppCommon, ILargePage
    {
        // Locator for the page content element. This is used to find the content on the page using XPath.
        private readonly By pageContentLocator = By.XPath("//div[@id='content']/div");

        // Constructor to initialize the LargePage class with a WebDriver instance.
        // It also navigates to the "Large" page of the HerokuApp.
        public LargePage(IWebDriver driver) : base(driver)
        {
            // Navigating to the large page URL.
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/large");
        }

        // Method to retrieve the title of the page.
        // It finds the element with the <h3> tag, which contains the page title, and returns its text.
        public string GetTitle()
        {
            // Find the title element using the <h3> tag.
            IWebElement titleElement = driver.FindElement(By.TagName("h3"));
            // Return the text of the title element.
            return titleElement.Text;
        }

        // Method to retrieve the content of the page.
        // It uses the predefined locator for the page content and returns the text.
        public string GetPageContent()
        {
            try
            {
                // Find the content element using the locator.
                IWebElement contentElement = driver.FindElement(pageContentLocator);
                // Return the text content of the found element.
                return contentElement.Text;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, return an empty string to handle the exception gracefully.
                return string.Empty;
            }
        }
    }
}
