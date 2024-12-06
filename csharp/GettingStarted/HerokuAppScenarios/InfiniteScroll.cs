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
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium.Support.UI;

namespace HerokuAppScenarios
{
    /// <summary>
    /// NUnit tests for the infinite scroll feature on the HerokuApp website.
    /// These tests verify functionality such as navigating to the infinite scroll page, 
    /// detecting content loading, and ensuring scrolling works as expected.
    /// </summary>
    [TestFixture]
    public class InfiniteScrollTests
    {

        private IWebDriver driver;
        private IInfiniteScroll infiniteScroll;

        /// <summary>
        /// Sets up the test environment by initializing the WebDriver 
        /// and navigating to the base URL of the HerokuApp.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            infiniteScroll = new InfiniteScroll(driver);
        }

        /// <summary>
        /// Cleans up the test environment by quitting the WebDriver instance.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        /// <summary>
        /// Verifies that navigating to the infinite scroll page marks the page as loaded.
        /// </summary>
        [Test]
        public void NavigateToInfiniteScrollPage_ShouldMarkPageAsLoaded()
        {
            // Act
            infiniteScroll.NavigateToInfiniteScrollPage();

            // Assert
            Assert.IsTrue(infiniteScroll.IsPageLoaded(), "The page should be marked as loaded after navigation.");
        }

        /// <summary>
        /// Verifies that scrolling down increases the number of loaded items.
        /// </summary>
        [Test]
        public void ScrollDownToLoadMore_ShouldIncreaseNumberOfItems()
        {
            // Arrange
            infiniteScroll.NavigateToInfiniteScrollPage();
            string itemSelector = ".jscroll-inner > div"; 
            int initialCount = infiniteScroll.GetNumberOfItems(itemSelector);
            Assert.Greater(initialCount, 0, "There should be some items loaded initially.");
            Console.WriteLine($"Initial item count: {initialCount}");

            // Act
            infiniteScroll.ScrollDownToLoadMore();

            // Wait for new items to load
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            bool isContentLoaded = wait.Until(d => infiniteScroll.GetNumberOfItems(itemSelector) > initialCount);
            int updatedCount = infiniteScroll.GetNumberOfItems(itemSelector);
            Console.WriteLine($"Updated item count: {updatedCount}");

            // Assert
            Assert.IsTrue(isContentLoaded, "New content should be loaded after scrolling.");
            Assert.Greater(updatedCount, initialCount, "Scrolling down should load more items.");
        }

        /// <summary>
        /// Verifies that new content is marked as loaded after scrolling.
        /// </summary>
        [Test]
        public void IsNewContentLoaded_ShouldReturnTrueAfterScroll()
        {
            // Arrange
            infiniteScroll.NavigateToInfiniteScrollPage();
            string itemSelector = ".jscroll-inner > div"; 

            // Act
            infiniteScroll.ScrollDownToLoadMore();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(d => infiniteScroll.IsNewContentLoaded(itemSelector));
            bool isContentLoaded = infiniteScroll.IsNewContentLoaded(itemSelector);

            // Assert
            Assert.IsTrue(isContentLoaded, "New content should be marked as loaded after scrolling.");
        }

        /// <summary>
        /// Verifies that scrolling stops after a specified maximum number of scrolls 
        /// and ensures that the total number of items does not exceed the expected range.
        /// </summary>
        [Test]
        public void ScrollUntilEnd_ShouldStopAfterMaxScrolls()
        {
            // Arrange
            infiniteScroll.NavigateToInfiniteScrollPage();
            string itemSelector = ".jscroll-inner > div"; 
            int maxScrolls = 5;

            // Act
            infiniteScroll.ScrollUntilEnd(itemSelector, maxScrolls);
            int itemCount = infiniteScroll.GetNumberOfItems(itemSelector);

            // Assert
            Assert.Greater(itemCount, 0, "The page should have at least some items after scrolling.");
            Assert.LessOrEqual(itemCount, maxScrolls * 10, "The total number of items should not exceed the maximum scroll attempts.");
        }
    }
}

