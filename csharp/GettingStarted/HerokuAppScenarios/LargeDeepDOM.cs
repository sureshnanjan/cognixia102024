using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HerokuAppScenarios
{
    public class LargeDeepDOM
    {

        [SetUp]
        public void Setup()
        {
            // Initialize the ChromeDriver and navigate to the Large Deep DOM page
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/large");
        }

        [Test]
        public void TestPageTitle()
        {
            ChromeDriver driver = new ChromeDriver();
            // Verify that the title of the page is as expected
            Assert.AreEqual("Large Deep DOM", driver.Title, "The page title is incorrect.");
        }

        [Test]
        public void TestElementPresence()
        {
            // Verify that a specific element is present in the DOM
            bool isElementPresent = IsElementPresent("#large-element-5");
            Assert.IsTrue(isElementPresent, "The element with the selector '#large-element-5' should be present.");
        }

        [Test]
        public void TestScrollThroughDOM()
        {
            // Scroll down the DOM by a specified amount and ensure the page loads more content
            ScrollThroughDOM(300);  // Scroll down by 300px
            // You could add further verification to ensure new content has loaded, such as checking for a new element.
            bool isElementPresentAfterScroll = IsElementPresent("#large-element-300");
            Assert.IsTrue(isElementPresentAfterScroll, "The element should be present after scrolling.");
        }

        [Test]
        public void TestInteractWithItemInDOM()
        {
            // Click on an item in the deep DOM and verify the result
            ClickItemInDOM("#large-element-100");
            // Verify that after clicking the item, some expected change has occurred (e.g., a modal opens or new content is shown)
            bool isModalOpen = IsElementPresent("#modal-id");  // Assuming a modal appears after clicking the item
            Assert.IsTrue(isModalOpen, "The modal should open after clicking on an item.");
        }

        [Test]
        public void TestWaitForDOMToLoad()
        {
            // Wait for the DOM to be fully loaded before proceeding with the test
            WaitForDOMToLoad();
            // Verify that the DOM is now in a complete state (e.g., check if the body tag is available)
            Assert.IsTrue(IsElementPresent("body"), "The body element should be present after the DOM is fully loaded.");
        }

        [TearDown]
        public void TearDown()
        {
            // Close the browser after the test
            ChromeDriver driver = new ChromeDriver();
            driver.Quit();
        }

        #region Helper Methods
        private bool IsElementPresent(string elementSelector)
        {
            try
            {
                ChromeDriver driver = new ChromeDriver();
                driver.FindElement(By.CssSelector(elementSelector));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private void ScrollThroughDOM(int scrollAmount)
        {
            ChromeDriver driver = new ChromeDriver();
            var jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript($"window.scrollBy(0, {scrollAmount});");
        }

        private void ClickItemInDOM(string itemSelector)
        {
            ChromeDriver driver = new ChromeDriver();
            var item = driver.FindElement(By.CssSelector(itemSelector));
            item.Click();
        }

        private void WaitForDOMToLoad()
        {
            ChromeDriver driver = new ChromeDriver();
            var jsExecutor = (IJavaScriptExecutor)driver;
            while ((bool)jsExecutor.ExecuteScript("return document.readyState === 'complete';") == false)
            {
                System.Threading.Thread.Sleep(500);
            }
        }
        #endregion
    }
}
