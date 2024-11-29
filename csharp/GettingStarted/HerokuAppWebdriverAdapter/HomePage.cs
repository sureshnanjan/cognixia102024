using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace HerokuAppWebdriverAdapter
{
    public class HomePage : IHomePage
    {
        private readonly IWebDriver _driver; // WebDriver instance for browser interactions
        private readonly WebDriverWait _wait; // WebDriverWait instance for explicit waits

        // Constructor to initialize the WebDriver and WebDriverWait
        public HomePage(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver)); // Ensure WebDriver is not null
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); // Explicit wait for synchronizing interactions
        }

        // Combines <h1> and <h2> text to form the page title
        public string GetTitle()
        {
            try
            {
                // Locate and extract text of <h1> and <h2> elements
                string h1Text = _driver.FindElement(By.CssSelector("h1")).Text;
                string h2Text = _driver.FindElement(By.CssSelector("h2")).Text;

                return $"{h1Text} - {h2Text}"; // Combine h1 and h2 text
            }
            catch (NoSuchElementException ex)
            {
                throw new Exception("Failed to retrieve the title: Ensure the h1 or h2 elements are present on the page.", ex);
            }
        }

        // Retrieves a list of available example names
        public string[] GetAvailableExamples()
        {
            try
            {
                // Find all links within the example section and extract their text
                var exampleElements = _wait.Until(driver => driver.FindElements(By.CssSelector("#content a")));
                return exampleElements.Select(e => e.Text.Trim()).Where(text => !string.IsNullOrEmpty(text)).ToArray();
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new Exception("Failed to retrieve available examples: Ensure the #content section contains links.", ex);
            }
        }

        // Retrieves the URL of an example link by its index
        public string GetExampleLinkUrl(int index)
        {
            try
            {
                // Wait for example links to be present on the page
                var exampleLinks = _wait.Until(driver => driver.FindElements(By.CssSelector("#content a")));

                // Validate index before accessing elements
                if (index < 0 || index >= exampleLinks.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index),
                        $"Invalid index {index}. Valid range: 0 to {exampleLinks.Count - 1}.");
                }

                return exampleLinks[index].GetAttribute("href"); // Retrieve href attribute
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new Exception("Failed to retrieve example link URLs: Ensure the links are present in #content section.", ex);
            }
        }

        // Placeholder method for future navigation link count functionality
        public int GetNavigationLinkCount()
        {
            throw new NotImplementedException("Method not yet implemented.");
        }
    }
}
