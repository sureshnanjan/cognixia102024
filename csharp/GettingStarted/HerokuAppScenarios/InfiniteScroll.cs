using HerokuAppOperations;

namespace HerokuAppScenarios
{
    /// <summary>
    /// NUnit tests for IInfiniteScroll
    /// </summary>
    [TestFixture]
    public class InfiniteScrollTests
    {
        private IInfiniteScroll _infiniteScroll;

        [Test]
        public void NavigateToInfiniteScrollPage_ShouldMarkPageAsLoaded()
        {
            // Act
            _infiniteScroll.NavigateToInfiniteScrollPage();

            // Assert
            Assert.IsTrue(_infiniteScroll.IsPageLoaded(), "The page should be marked as loaded after navigation.");
        }

        [Test]
        public void ScrollDownToLoadMore_ShouldIncreaseNumberOfItems()
        {
            // Arrange
            _infiniteScroll.NavigateToInfiniteScrollPage();
            int initialCount = _infiniteScroll.GetNumberOfItems("dummySelector");

            // Act
            _infiniteScroll.ScrollDownToLoadMore();
            int updatedCount = _infiniteScroll.GetNumberOfItems("dummySelector");

            // Assert
            Assert.AreEqual(initialCount + 10, updatedCount, "Scrolling down should load more items.");
        }

        [Test]
        public void IsNewContentLoaded_ShouldReturnTrueAfterScroll()
        {
            // Arrange
            _infiniteScroll.NavigateToInfiniteScrollPage();

            // Act
            _infiniteScroll.ScrollDownToLoadMore();
            bool isContentLoaded = _infiniteScroll.IsNewContentLoaded("dummySelector");

            // Assert
            Assert.IsTrue(isContentLoaded, "New content should be marked as loaded after scrolling.");
        }

        [Test]
        public void ScrollUntilEnd_ShouldStopAfterMaxScrolls()
        {
            // Arrange
            _infiniteScroll.NavigateToInfiniteScrollPage();
            int maxScrolls = 5;

            // Act
            _infiniteScroll.ScrollUntilEnd("dummySelector", maxScrolls);
            int itemCount = _infiniteScroll.GetNumberOfItems("dummySelector");

            // Assert
            Assert.AreEqual(20 + (maxScrolls * 10), itemCount, "The total number of items should reflect the maximum number of scrolls.");
        }
    }
}