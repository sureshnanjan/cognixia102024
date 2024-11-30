// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppTests
{
    [TestFixture]
    public class DynamicLoadingTests
    {
        private IWebDriver _driver;
        private DynamicLoadingPage _dynamicLoadingPage;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _dynamicLoadingPage = new DynamicLoadingPage(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }
        [Test]
        public void VerifyHeaderAndParagraphsOnDynamicLoadingPage()
        {
            _dynamicLoadingPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading");

            // Verify <h3> text
            string headerText = _dynamicLoadingPage.GetHeaderText();
            Assert.AreEqual("Dynamically Loaded Page Elements", headerText);

            // Verify first <p> text
            string firstParagraph = _dynamicLoadingPage.GetFirstParagraphText();
            Assert.IsTrue(firstParagraph.Contains("It's common to see an action get triggered that returns a result dynamically. "));

            // Verify second <p> text
            string secondParagraph = _dynamicLoadingPage.GetSecondParagraphText();
            Assert.IsTrue(secondParagraph.Contains("There are two examples. One in which an element already exists on the page but it is not displayed."));
        }
        [Test]
        public void VerifyHeadersInExample1()
        {
            // Navigate to Example 1
            _dynamicLoadingPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading/1");

            // Verify <h3> text
            string headerText = _dynamicLoadingPage.GetHeaderText();
            Assert.AreEqual("Dynamically Loaded Page Elements", headerText);

            // Verify <h4> text
            string subParagraph = _dynamicLoadingPage.GetSubHeaderText();
            Assert.IsTrue(subParagraph.Contains("Example 1: Element on page that is hidden"));
        }
        [Test]
        public void VerifyHeadersInExample2()
        {
            // Navigate to Example 2
            _dynamicLoadingPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading/2");

            // Verify <h3> text
            string headerText = _dynamicLoadingPage.GetHeaderText();
            Assert.AreEqual("Dynamically Loaded Page Elements", headerText);

            // Verify <h4> text
            string subParagraph = _dynamicLoadingPage.GetSubHeaderText();
            Assert.IsTrue(subParagraph.Contains("Example 2: Element rendered after the fact"));
        }


        [Test]
        public void TestDynamicLoadingPage()
        {
            _dynamicLoadingPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading/1");

            // Verify Start button is displayed
            Assert.IsTrue(_dynamicLoadingPage.IsElementDisplayed("#start button"));

            // Click Start button
            _dynamicLoadingPage.ClickStartButton();

            // Verify loading indicator is displayed
            Assert.IsTrue(_dynamicLoadingPage.IsLoadingIndicatorDisplayed());

            // Wait for loading to complete
            _dynamicLoadingPage.WaitForLoadingToComplete();

            // Verify dynamically loaded text is displayed
            Assert.IsTrue(_dynamicLoadingPage.IsDynamicallyLoadedElementDisplayed());

            // Validate the text of the dynamically loaded element
            string loadedText = _dynamicLoadingPage.GetLoadedElementText();
            Assert.AreEqual("Hello World!", loadedText);
        }

        [Test]
        public void TestLoadingIndicatorVisibility()
        {
            _dynamicLoadingPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading/1");

            // Click Start button
            _dynamicLoadingPage.ClickStartButton();

            // Verify loading indicator is displayed
            Assert.IsTrue(_dynamicLoadingPage.IsLoadingIndicatorDisplayed());

            // Wait for loading to complete
            _dynamicLoadingPage.WaitForLoadingToComplete();

            // Verify loading indicator is no longer displayed
            Assert.IsFalse(_dynamicLoadingPage.IsLoadingIndicatorDisplayed());
        }
        [Test]
        public void VerifyDynamicLoadingExample2()
        {
            // Navigate to Example 2
            _dynamicLoadingPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading/2");

            // Click the Start button
            _dynamicLoadingPage.ClickStartButton();

            // Verify the Loading message is displayed
            Assert.IsTrue(_dynamicLoadingPage.IsLoadingIndicatorDisplayed(), "Loading message is not displayed!");

            // Wait for the Loading message to disappear
            _dynamicLoadingPage.WaitForLoadingToComplete();

            // Verify the hidden element is now visible
            Assert.IsTrue(_dynamicLoadingPage.IsHiddenElementVisible(), "Hidden element is not visible after loading completed!");
        }
        [Test]
        public void VerifyLoadingMessageInExample2()
        {
            // Navigate to Example 2
            _dynamicLoadingPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading/2");

            // Click the Start button
            _dynamicLoadingPage.ClickStartButton();

            // Verify the Loading message is displayed
            Assert.IsTrue(_dynamicLoadingPage.IsLoadingIndicatorDisplayed2(), "Loading message is not displayed!");

            // Wait for the Loading message to disappear
            _dynamicLoadingPage.WaitForLoadingToComplete2();

            // Verify that the Loading message is no longer displayed
            Assert.IsFalse(_dynamicLoadingPage.IsLoadingIndicatorDisplayed2(), "Loading message did not disappear!");
        }
        [Test]
        public void VerifyHyperlinksOnDynamicLoadingPage()
        {
            // Navigate to the Dynamic Loading page
            _dynamicLoadingPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading");

            // Verify the number of hyperlinks
            int hyperlinkCount = _dynamicLoadingPage.GetHyperlinkCount();
            Assert.AreEqual(2, hyperlinkCount, "The number of hyperlinks is incorrect!");

            // Verify the text of hyperlinks
            IList<string> hyperlinkTexts = _dynamicLoadingPage.GetHyperlinkTexts();
            CollectionAssert.AreEquivalent(new List<string>
    {
        "Example 1: Element on page that is hidden",
        "Example 2: Element rendered after the fact"
    }, hyperlinkTexts, "The hyperlink texts are incorrect!");

            // Verify the URLs of hyperlinks
            IList<string> hyperlinkUrls = _dynamicLoadingPage.GetHyperlinkUrls();
            CollectionAssert.AreEquivalent(new List<string>
    {
        "https://the-internet.herokuapp.com/dynamic_loading/1",
        "https://the-internet.herokuapp.com/dynamic_loading/2"
    }, hyperlinkUrls, "The hyperlink URLs are incorrect!");
        }


    }

}

