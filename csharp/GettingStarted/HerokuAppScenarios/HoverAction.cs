using NUnit.Framework;
using OpenQA.Selenium;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium.Chrome;

namespace HerokuAppScenarios
{
    // TestFixture attribute indicates that this class contains test cases for NUnit
    [TestFixture]
    public class HoverActions
    {
        private IWebDriver driver; // WebDriver for interacting with the browser
        private IHoverAction hoverActions; // Interface to handle hover actions

        // SetUp attribute ensures this method runs before each test case
        [SetUp]
        public void SetUp()
        {
            // Initialize WebDriver (Chrome in this case)
            driver = new ChromeDriver();

            // Maximize the browser window for better visibility
            driver.Manage().Window.Maximize();

            // Navigate to the "Hovers" page to perform hover actions
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");

            // Initialize the HoverActions class that will handle hover actions
            hoverActions = new HoverActions(driver);
        }

        // Test Case 1: Hover over the first image and validate the content (username) is revealed
        [Test]
        public void HoverOverFirstImageAndValidateContent()
        {
            // Locate the first image using its XPath and store it in an IWebElement
            IWebElement image1 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[1]/img"));

            // Hover over the first image using the hoverActions object
            hoverActions.hoverOverElement(image1);

            // Check if the content (e.g., username) appears after hovering
            bool isContentVisible = hoverActions.validateContentAppears(image1);

            // Assert that the content became visible after hovering over the first image
            Assert.IsTrue(isContentVisible, "Content did not appear after hovering over the image.");
        }

        // Test Case 2: Hover over the second image, click the revealed link and verify the URL
        [Test]
        public void HoverOverSecondImageAndClickRevealedLink()
        {
            // Locate the second image using its XPath and store it in an IWebElement
            IWebElement image2 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[2]/img"));

            // Hover over the second image using the hoverActions object
            hoverActions.hoverOverElement(image2);

            // Locate the link that becomes visible after hovering and store it in an IWebElement
            IWebElement link = driver.FindElement(By.XPath("//div[@class='figcaption'][2]//a"));

            // Click the revealed link using the hoverActions object
            hoverActions.clickOnRevealedLink(link);

            // Verify the URL after clicking the link. It should redirect to the second user’s profile page.
            Assert.AreEqual("https://the-internet.herokuapp.com/img/avatar-blank.jpg", driver.Url);
        }

        // Test Case 3: Hover over the third image and validate the content (username) is revealed
        [Test]
        public void HoverOverThirdImageAndValidateContent()
        {
            // Locate the third image using its XPath and store it in an IWebElement
            IWebElement image3 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[3]/img"));

            // Hover over the third image using the hoverActions object
            hoverActions.hoverOverElement(image3);

            // Check if the content (e.g., username) appears after hovering
            bool isContentVisible = hoverActions.validateContentAppears(image3);

            // Assert that the content became visible after hovering over the third image
            Assert.IsTrue(isContentVisible, "Content did not appear after hovering over the third image.");
        }

       
    }
}
