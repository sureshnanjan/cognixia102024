﻿using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class ABTestingPage : IABTesting
    {
        public IWebDriver driver;

        // Constructor that accepts the WebDriver instance
        public ABTestingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Since there are no "optIn" or "optOut" buttons, we will focus on getting the content.
        public string GetPageContent()
        {
            // Locate the element that contains the A/B test content
            var exampleTextElement = driver.FindElement(By.CssSelector(".example"));

            // Return the content as a string
            return exampleTextElement.Text;
        }

        // Implement OptInABTest method (if applicable for future use)
        public void OptInABTest()
        {
            // You can implement logic here if your page has such functionality.
        }

        // Implement OptOutABTest method (if applicable for future use)
        public void OptOutABTest()
        {
            // You can implement logic here if your page has such functionality.
        }
    }
}
