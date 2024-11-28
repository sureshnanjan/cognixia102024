// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace HerokuAppWebdriverAdapter
{
    public class HomePage : IHomePage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        // Constructor accepts WebDriver instance to interact with the page
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));  // Added WebDriverWait for synchronization
        }

        // Get the title of the Home Page, which should contain both <h1> and <h2>
        public string GetTitle()
        {
            string h1Text = _driver.FindElement(By.CssSelector("h1.heading")).Text;
            string h2Text = _driver.FindElement(By.CssSelector("h2")).Text;
            return $"{h1Text} - {h2Text}"; // Combine h1 and h2 text for validation
        }

        // Get a list of available examples on the Home Page
        public string[] GetAvailableExamples()
        {
            var exampleElements = _driver.FindElements(By.CssSelector(".example"));
            return exampleElements.Select(e => e.Text).ToArray();
        }

        // Get the URL of a specific example link by its index
        public string GetExampleLinkUrl(int index)
        {
            // Wait for the example links to be available
            var exampleLinks = _wait.Until(driver => driver.FindElements(By.CssSelector(".example a")));

            // Ensure the index is within the valid range
            if (index >= 0 && index < exampleLinks.Count)
            {
                // Return the link URL of the requested index
                return exampleLinks[index].GetAttribute("href");
            }
            else
            {
                // If index is out of range, log and throw an exception
                throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range. The valid range is 0 to {exampleLinks.Count - 1}.");
            }
        }
    }
}
