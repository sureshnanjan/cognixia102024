using NUnit.Framework;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;

namespace HerokuAppScenarios
{
    public class SlowResourcesTests
    {
        private ISlowResources slowResourcesPage;

        [SetUp]
        public void Setup()
        {
            // Arrange: Initialize the SlowResources page object
            slowResourcesPage = new SlowResources();
        }

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

        [TearDown]
        public void TearDown()
        {
            // Clean up: Close the browser after tests
            slowResourcesPage.CloseBrowser();
        }
    }
}
