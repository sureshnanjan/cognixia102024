using System;
using HerokuAppWebdriverAdapter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class HoverActionsTests
    {
        private ChromeDriver _driver; // Use concrete type for performance
        private HoverActions _hoverActions;

        [SetUp]
        public void Setup()
        {
            try
            {
                // Initialize WebDriver in Setup (avoid constructor injection)
                _driver = new ChromeDriver(); // Ensure correct driver path if not in PATH
                _hoverActions = new HoverActions(_driver);

                // Navigate to the page
                _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");
            }
            catch (WebDriverException ex)
            {
                Console.WriteLine($"Error initializing WebDriver: {ex.Message}");
                Assert.Fail("Failed to initialize WebDriver.");
            }
        }

        [Test]
        public void HoverOverFirstImageAndValidateContent()
        {
            try
            {
                // Locate the first image
                var firstImage = _driver.FindElement(By.XPath("(//div[@class='figure'])[1]"));

                // Hover over the first image
                _hoverActions.hoverOverElement(firstImage);

                // Validate that the content appears after hover
                bool contentVisible = _hoverActions.validateContentAppears(firstImage);
                Assert.IsTrue(contentVisible, "Content should be visible after hover.");

                // Click on the revealed "View Profile" link
                var viewProfileLink = firstImage.FindElement(By.XPath(".//a[text()='View profile']"));
                _hoverActions.clickOnRevealedLink(viewProfileLink);

                // Validate navigation (example: check URL contains "users/1")
                Assert.IsTrue(_driver.Url.Contains("users/1"), "Should navigate to the correct profile URL.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed: {ex.Message}");
                Assert.Fail("Test failed due to an exception.");
            }
        }

        [Test]
        public void HoverOverSecondImageAndValidateContent()
        {
            try
            {
                // Locate the second image
                var secondImage = _driver.FindElement(By.XPath("(//div[@class='figure'])[2]"));

                // Hover over the second image
                _hoverActions.hoverOverElement(secondImage);

                // Validate that the content appears after hover
                bool contentVisible = _hoverActions.validateContentAppears(secondImage);
                Assert.IsTrue(contentVisible, "Content should be visible after hover.");

                // Click on the revealed "View Profile" link
                var viewProfileLink = secondImage.FindElement(By.XPath(".//a[text()='View profile']"));
                _hoverActions.clickOnRevealedLink(viewProfileLink);

                // Validate navigation (example: check URL contains "users/2")
                Assert.IsTrue(_driver.Url.Contains("users/2"), "Should navigate to the correct profile URL.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed: {ex.Message}");
                Assert.Fail("Test failed due to an exception.");
            }
        }

        [Test]
        public void HoverOverThirdImageAndValidateContent()
        {
            try
            {
                // Locate the third image
                var thirdImage = _driver.FindElement(By.XPath("(//div[@class='figure'])[3]"));

                // Hover over the third image
                _hoverActions.hoverOverElement(thirdImage);

                // Validate that the content appears after hover
                bool contentVisible = _hoverActions.validateContentAppears(thirdImage);
                Assert.IsTrue(contentVisible, "Content should be visible after hover.");

                // Click on the revealed "View Profile" link
                var viewProfileLink = thirdImage.FindElement(By.XPath(".//a[text()='View profile']"));
                _hoverActions.clickOnRevealedLink(viewProfileLink);

                // Validate navigation (example: check URL contains "users/3")
                Assert.IsTrue(_driver.Url.Contains("users/3"), "Should navigate to the correct profile URL.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed: {ex.Message}");
                Assert.Fail("Test failed due to an exception.");
            }
        }

        [TearDown]
        public void TearDown()
        {
            // Ensure proper cleanup after each test
            _driver?.Quit(); // Use null-conditional to ensure no error if _driver was not initialized
            _driver.Dispose();  // Ensures proper cleanup
        }
    }
}
