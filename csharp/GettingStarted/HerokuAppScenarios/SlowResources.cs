using HerokuAppOperations;
using NUnit.Framework;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for validating the behavior of the HerokuApp SlowResources page.
    /// The tests cover page navigation, title validation, header validation, and content validation for slow resources.
    /// </summary>
    public class SlowResourcesTests
    {
        /// <summary>
        /// Instance of the SlowResources page object used in the tests.
        /// </summary>
        private ISlowResources slowResourcesPage;

        /// <summary>
        /// Setup method executed before each test.
        /// Initializes the SlowResources page object for each test.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize the SlowResources page object
            slowResourcesPage = new SlowResources();
        }

        /// <summary>
        /// Test method to verify that the page navigation works correctly.
        /// Ensures that the page is navigated to the slow resources page.
        /// </summary>
        [Test]
        public void Test_NavigateToPage()
        {
            // Act: Navigate to the Slow Resources page
            slowResourcesPage.NavigateToPage();

            // Assert: Verify that the current URL is the correct one for the Slow Resources page
            Assert.AreEqual("https://the-internet.herokuapp.com/slow", slowResourcesPage.GetCurrentUrl(), "The URL is not correct.");
        }

        /// <summary>
        /// Test method to verify that the page title is correct when the page is loaded.
        /// Ensures that the page title is "The Internet".
        /// </summary>
        [Test]
        public void Test_PageTitle()
        {
            // Act: Navigate to the Slow Resources page
            slowResourcesPage.NavigateToPage();

            // Act: Get and print the page title
            string pageTitle = slowResourcesPage.GetPageTitle();
            Console.WriteLine($"Page Title: {pageTitle}");

            // Assert: Verify the page title
            Assert.AreEqual("The Internet", pageTitle, "Page title does not match.");
        }

        /// <summary>
        /// Test method to verify that the header on the Slow Resources page is correct.
        /// Ensures that the header text is as expected.
        /// </summary>
        [Test]
        public void Test_HeaderText()
        {
            // Act: Navigate to the Slow Resources page
            slowResourcesPage.NavigateToPage();

            // Act: Get the header text
            string headerText = slowResourcesPage.GetHeaderText();
            Console.WriteLine($"Header Text: {headerText}");

            // Assert: Verify the header text
            Assert.AreEqual("This page has a resource that is very slow to load", headerText, "Header text does not match.");
        }

        /// <summary>
        /// Test method to verify that the page content loads correctly after waiting for it.
        /// Ensures that the content text is present after waiting up to 40 seconds.
        /// </summary>
        [Test]
        public void Test_ContentAfterLoading()
        {
            // Act: Navigate to the Slow Resources page
            slowResourcesPage.NavigateToPage();

            // Act: Get content after waiting for it to load (up to 40 seconds)
            string contentText = slowResourcesPage.GetContentAfterLoading(40);

            // Assert: Verify that the content contains expected text
            Assert.IsTrue(contentText.Contains("Some slow content"), "Content did not load properly.");
        }

        /// <summary>
        /// Test method to verify the network response for slow external resources.
        /// Ensures that the response code for a slow resource is 503.
        /// </summary>
        [Test]
        public void Test_SlowExternalResourceResponse()
        {
            // Act: Monitor the network response for slow GET requests
            var response = slowResourcesPage.GetNetworkResponse("https://the-internet.herokuapp.com/slow_external");

            // Assert: Verify that the network response is as expected
            Assert.IsNotNull(response, "No network response detected.");
            Assert.AreEqual(503, response.StatusCode, "Status code of slow resource is not 503.");
            Console.WriteLine($"Slow resource response time: {response.ResponseTime} seconds.");
        }

        /// <summary>
        /// TearDown method executed after each test.
        /// Cleans up by closing the browser once the test is completed.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Clean up: Close the browser after tests
            slowResourcesPage.CloseBrowser();
        }
    }
}
