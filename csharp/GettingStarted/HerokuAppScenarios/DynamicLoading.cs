// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppScenarios;

/// <summary>
/// Test suite to validate the functionality of the Dynamic Loading page from the Heroku App:
/// https://the-internet.herokuapp.com/dynamic_loading.
/// It includes tests for headers, loading indicators, dynamic content, and hyperlinks.
/// </summary>
[TestFixture]
public class DynamicLoadingTests
{
    private IWebDriver _driver;
    private DynamicLoadingPage _dynamicContentPage;

    /// <summary>
    /// Setup method executed before each test to initialize the WebDriver and page object model.
    /// </summary>
    [SetUp]
    public void Setup()
    {
        _driver = new ChromeDriver();
        _dynamicContentPage = new DynamicLoadingPage(_driver);
    }

    /// <summary>
    /// TearDown method executed after each test to close the browser and dispose of resources.
    /// </summary>
    [TearDown]
    public void TearDown()
    {
        _driver.Quit();
        _driver.Dispose();
    }

    /// <summary>
    /// Verifies the header and paragraph texts on the main Dynamic Loading page.
    /// </summary>
    [Test]
    public void VerifyHeaderAndParagraphsOnDynamicLoadingPage()
    {
        _dynamicContentPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading");

        // Verify <h3> text
        string headerText = _dynamicContentPage.GetHeaderText();
        Assert.AreEqual("Dynamically Loaded Page Elements", headerText);

        // Verify first <p> text
        string firstParagraph = _dynamicContentPage.GetFirstParagraphText();
        Assert.IsTrue(firstParagraph.Contains("It's common to see an action get triggered that returns a result dynamically."));

        // Verify second <p> text
        string secondParagraph = _dynamicContentPage.GetSecondParagraphText();
        Assert.IsTrue(secondParagraph.Contains("There are two examples. One in which an element already exists on the page but it is not displayed."));
    }

    /// <summary>
    /// Verifies the headers on Example 1 of the Dynamic Loading page.
    /// </summary>
    [Test]
    public void VerifyHeadersInExample1()
    {
        _dynamicContentPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading/1");

        // Verify <h3> text
        string headerText = _dynamicContentPage.GetHeaderText();
        Assert.AreEqual("Dynamically Loaded Page Elements", headerText);

        // Verify <h4> text
        string subParagraph = _dynamicContentPage.GetSubHeaderText();
        Assert.IsTrue(subParagraph.Contains("Example 1: Element on page that is hidden"));
    }

    /// <summary>
    /// Verifies the headers on Example 2 of the Dynamic Loading page.
    /// </summary>
    [Test]
    public void VerifyHeadersInExample2()
    {
        _dynamicContentPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading/2");

        // Verify <h3> text
        string headerText = _dynamicContentPage.GetHeaderText();
        Assert.AreEqual("Dynamically Loaded Page Elements", headerText);

        // Verify <h4> text
        string subParagraph = _dynamicContentPage.GetSubHeaderText();
        Assert.IsTrue(subParagraph.Contains("Example 2: Element rendered after the fact"));
    }

    /// <summary>
    /// Tests the dynamic loading functionality on Example 1.
    /// Verifies loading indicators and dynamically loaded content.
    /// </summary>
    [Test]
    public void TestDynamicLoadingPage()
    {
        _dynamicContentPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading/1");

        // Verify Start button is displayed
        Assert.IsTrue(_dynamicContentPage.IsElementDisplayed("#start button"));

        // Click Start button
        _dynamicContentPage.ClickStartButton();

        // Verify loading indicator is displayed
        Assert.IsTrue(_dynamicContentPage.IsLoadingIndicatorDisplayed());

        // Wait for loading to complete
        _dynamicContentPage.WaitForLoadingToComplete();

        // Verify dynamically loaded text is displayed
        Assert.IsTrue(_dynamicContentPage.IsDynamicallyLoadedElementDisplayed());

        // Validate the text of the dynamically loaded element
        string loadedText = _dynamicContentPage.GetLoadedElementText();
        Assert.AreEqual("Hello World!", loadedText);
    }

    /// <summary>
    /// Validates the visibility of the loading indicator before and after loading.
    /// </summary>
    [Test]
    public void TestLoadingIndicatorVisibility()
    {
        _dynamicContentPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading/1");

        // Click Start button
        _dynamicContentPage.ClickStartButton();

        // Verify loading indicator is displayed
        Assert.IsTrue(_dynamicContentPage.IsLoadingIndicatorDisplayed());

        // Wait for loading to complete
        _dynamicContentPage.WaitForLoadingToComplete();

        // Verify loading indicator is no longer displayed
        Assert.IsFalse(_dynamicContentPage.IsLoadingIndicatorDisplayed());
    }

    /// <summary>
    /// Validates the functionality of dynamic loading on Example 2.
    /// Verifies the visibility of hidden elements after loading completes.
    /// </summary>
    [Test]
    public void VerifyDynamicLoadingExample2()
    {
        _dynamicContentPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading/2");

        // Click the Start button
        _dynamicContentPage.ClickStartButton();

        // Verify loading indicator is displayed
        Assert.IsTrue(_dynamicContentPage.IsLoadingIndicatorDisplayed(), "Loading message is not displayed!");

        // Wait for loading to complete
        _dynamicContentPage.WaitForLoadingToComplete();

        // Verify the hidden element is now visible
        Assert.IsTrue(_dynamicContentPage.IsHiddenElementVisible(), "Hidden element is not visible after loading completed!");
    }

    /// <summary>
    /// Verifies the hyperlinks on the main Dynamic Loading page.
    /// Validates hyperlink texts and their corresponding URLs.
    /// </summary>
    [Test]
    public void VerifyHyperlinksOnDynamicLoadingPage()
    {
        _dynamicContentPage.NavigateToPage("https://the-internet.herokuapp.com/dynamic_loading");

        // Verify the number of hyperlinks
        int hyperlinkCount = _dynamicContentPage.GetHyperlinkCount();
        Assert.AreEqual(2, hyperlinkCount, "The number of hyperlinks is incorrect!");

        // Verify the text of hyperlinks
        IList<string> hyperlinkTexts = _dynamicContentPage.GetHyperlinkTexts();
        CollectionAssert.AreEquivalent(new List<string>
        {
            "Example 1: Element on page that is hidden",
            "Example 2: Element rendered after the fact"
        }, hyperlinkTexts, "The hyperlink texts are incorrect!");

        // Verify the URLs of hyperlinks
        IList<string> hyperlinkUrls = _dynamicContentPage.GetHyperlinkUrls();
        CollectionAssert.AreEquivalent(new List<string>
        {
            "https://the-internet.herokuapp.com/dynamic_loading/1",
            "https://the-internet.herokuapp.com/dynamic_loading/2"
        }, hyperlinkUrls, "The hyperlink URLs are incorrect!");
    }
}
