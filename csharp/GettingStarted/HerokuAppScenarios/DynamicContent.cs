using System;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class DynamicContentTest
    {
        private IWebDriver driver;
        private IDynamicContent dynamicContent;

        [SetUp]
        public void SetUp()
        {
            // Initialize WebDriver (Chrome in this case)
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_content");

            // Initialize the dynamic content page object
            dynamicContent = new DynamicContent(driver);
        }

        [TearDown]
        public void TearDown()
        {
            // Dispose of WebDriver instance to prevent memory leaks or stale connections
            if (driver != null)
            {
                driver.Quit();  // Quit the WebDriver to clean up after test
                driver = null;  // Set driver to null to ensure it's not used again
            }
        }

        [Test]
        public void TestDynamicContent()
        {
            // Retrieve the title and content text using methods from the DynamicContent class
            string pageTitle = dynamicContent.GetTitle();
            string contentText = dynamicContent.GetContentText();

            // Perform some assertions to validate the content
            Assert.IsNotEmpty(pageTitle, "Title should not be empty.");
            Assert.IsNotEmpty(contentText, "Content text should not be empty.");
        }
    }
}
