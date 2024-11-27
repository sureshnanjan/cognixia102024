using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium.Support.UI;  // Ensure this is the correct namespace for your adapter class.

namespace HerokuAppScenarios
{
    [TestFixture]
    public class DynamicLoadingTests  // Renamed the test class to avoid conflict with the page object class
    {
        private IWebDriver _driver;
        private DynamicLoading _dynamicLoading;  // This is the page object, imported from HerokuAppWebdriverAdapter

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading");
            _dynamicLoading = new DynamicLoading(_driver);  // Use the correct class name for the page object
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void Test_GetTitle()
        {
            // Get the page title
            string title = _dynamicLoading.GetTitle();
            // Assert that the title matches the expected value
            Assert.AreEqual("Dynamically Loaded Page Elements", title, "The page title should match 'Dynamically Loaded Page Elements'.");
        }

        [Test]
        public void Test_StartLoadingAndVerifyElement()
        {
            // Start the loading operation
            _dynamicLoading.StartLoading();
            Console.WriteLine("Started loading...");

            // Wait for the element to become visible
            try
            {
                // Use an explicit wait to verify the element is visible
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
                bool isElementVisible = wait.Until(d =>
                {
                    try
                    {
                        var element = d.FindElement(By.XPath("//*[@id=\"finish\"]/h4"));
                        return element.Displayed;
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                });

                // Assert visibility
                Assert.IsTrue(isElementVisible, "The element should be visible after loading.");
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Fail("The element did not become visible within the expected time.");
            }
        }

    }
}
