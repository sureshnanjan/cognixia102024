using HerokuAppWebdriverAdapter;
using NUnit.Framework;

namespace HerokuAppScenarios
{
    public class SlowResourcesTests
    {
        private SlowResources slowResourcesPage;

        [SetUp]
        public void Setup()
        {
            // Initialize the SlowResources page object
            slowResourcesPage = new SlowResources();
        }

        [Test]
        public void VerifyPageTitle()
        {
            // Act
            slowResourcesPage.NavigateToPage();  // No argument passed here
            string pageTitle = slowResourcesPage.GetPageTitle();

            // Assert
            string expectedTitle = "The Internet";
            Assert.AreEqual(expectedTitle, pageTitle, "The page title does not match the expected value.");
        }

        [Test]
        public void VerifyHeaderText()
        {
            // Act
            slowResourcesPage.NavigateToPage();  // No argument passed here
            string headerText = slowResourcesPage.GetHeaderText();

            // Assert
            string expectedHeader = "Slow Resources";
            Assert.AreEqual(expectedHeader, headerText, "The header text does not match the expected value.");
        }

        [Test]
        public void VerifyContentAfterLoading()
        {
            // Act
            slowResourcesPage.NavigateToPage();  // No argument passed here
            string contentText = slowResourcesPage.GetContentAfterLoading(30);  // Wait for content to load

            // Assert
            string expectedContent = "At times it can take a while for third-party site resources to load (e.g., tracking code javascript, social networking widgets, etc.). This example has a rogue GET request that takes 30 seconds to complete.";
            Assert.AreEqual(expectedContent, contentText, "The content text did not match the expected value.");
        }

        [TearDown]
        public void TearDown()
        {
            // Cleanup - close the browser after each test
            slowResourcesPage.CloseBrowser();  // No argument passed here
        }
    }
}

