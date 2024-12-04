using HerokuAppOperations;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class for validating the behavior of slow resources on the HerokuApp SlowResources page.
    /// The tests ensure that the page loads correctly, the title and header are accurate, content is loaded after waiting, and slow external resources return the expected response.
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
            // Arrange: Initialize the SlowResources page object
            slowResourcesPage = new SlowResources();
        }

        /// <summary>
        /// Test method to validate the behavior of slow resource requests on the HerokuApp SlowResources page.
        /// It performs the following:
        /// - Verifies the page title is correct.
        /// - Verifies the header text is correct.
        /// - Waits for the content to load and validates that it contains expected text.
        /// - Checks the network response for slow external resources and validates the response status.
        /// </summary>
        [Test]
        public void Test_SlowResource_Request_Validation()
        {
            // Act: Navigate to the page
            slowResourcesPage.NavigateToPage();

            // Act: Get and print the page title
            string pageTitle = slowResourcesPage.GetPageTitle();
            Console.WriteLine($"Page Title: {pageTitle}");

            // Assert: Verify the page title
            Assert.AreEqual("The Internet", pageTitle, "Page title does not match.");

            // Act: Get the header text
            string headerText = slowResourcesPage.GetHeaderText();
            Console.WriteLine($"Header Text: {headerText}");

            // Assert: Verify the header text
            Assert.AreEqual("This page has a resource that is very slow to load", headerText, "Header text does not match.");

            // Act: Get content after waiting for it to load (up to 40 seconds)
            string contentText = slowResourcesPage.GetContentAfterLoading(40);

            // Assert: Verify that the content contains expected text
            Assert.IsTrue(contentText.Contains("Some slow content"), "Content did not load properly.");

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
