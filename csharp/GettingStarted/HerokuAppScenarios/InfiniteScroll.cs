using NUnit.Framework;

namespace HerokuAppOperations
{
    /// <summary>
    /// Stub implementation of IInfiniteScroll for testing purposes.
    /// </summary>
    public class InfiniteScrollStub : IInfiniteScroll
    {
        private int _numberOfItems;
        private int _newContentLoadedCalls;
        private bool _isPageLoaded;
        private readonly int _itemsPerScroll;

        public InfiniteScrollStub(int initialItems = 0, int itemsPerScroll = 10)
        {
            _numberOfItems = initialItems;
            _itemsPerScroll = itemsPerScroll;
            _isPageLoaded = false;
            _newContentLoadedCalls = 0;
        }

        public void NavigateToInfiniteScrollPage()
        {
            _isPageLoaded = true;
        }

        public bool IsPageLoaded()
        {
            return _isPageLoaded;
        }

        public void ScrollDownToLoadMore()
        {
            if (_isPageLoaded)
            {
                _numberOfItems += _itemsPerScroll;
                _newContentLoadedCalls++;
            }
        }

        public bool IsNewContentLoaded(string itemSelector)
        {
            // Assuming new content is loaded when ScrollDownToLoadMore is called
            return _newContentLoadedCalls > 0;
        }

        public int GetNumberOfItems(string itemSelector)
        {
            return _numberOfItems;
        }

        public void ScrollUntilEnd(string itemSelector, int maxScrolls = 10)
        {
            int scrollCount = 0;

            while (scrollCount < maxScrolls && _newContentLoadedCalls == scrollCount)
            {
                ScrollDownToLoadMore();
                scrollCount++;
            }
        }
    }

    /// <summary>
    /// NUnit tests for IInfiniteScroll using InfiniteScrollStub.
    /// </summary>
    [TestFixture]
    public class InfiniteScrollTests
    {
        private InfiniteScrollStub _scrollStub;

        [SetUp]
        public void SetUp()
        {
            _scrollStub = new InfiniteScrollStub(initialItems: 20, itemsPerScroll: 10);
        }

        [Test]
        public void NavigateToInfiniteScrollPage_ShouldMarkPageAsLoaded()
        {
            // Act
            _scrollStub.NavigateToInfiniteScrollPage();

            // Assert
            Assert.IsTrue(_scrollStub.IsPageLoaded(), "The page should be marked as loaded after navigation.");
        }

        [Test]
        public void ScrollDownToLoadMore_ShouldIncreaseNumberOfItems()
        {
            // Arrange
            _scrollStub.NavigateToInfiniteScrollPage();
            int initialCount = _scrollStub.GetNumberOfItems("dummySelector");

            // Act
            _scrollStub.ScrollDownToLoadMore();
            int updatedCount = _scrollStub.GetNumberOfItems("dummySelector");

            // Assert
            Assert.AreEqual(initialCount + 10, updatedCount, "Scrolling down should load more items.");
        }

        [Test]
        public void IsNewContentLoaded_ShouldReturnTrueAfterScroll()
        {
            // Arrange
            _scrollStub.NavigateToInfiniteScrollPage();

            // Act
            _scrollStub.ScrollDownToLoadMore();
            bool isContentLoaded = _scrollStub.IsNewContentLoaded("dummySelector");

            // Assert
            Assert.IsTrue(isContentLoaded, "New content should be marked as loaded after scrolling.");
        }

        [Test]
        public void ScrollUntilEnd_ShouldStopAfterMaxScrolls()
        {
            // Arrange
            _scrollStub.NavigateToInfiniteScrollPage();
            int maxScrolls = 5;

            // Act
            _scrollStub.ScrollUntilEnd("dummySelector", maxScrolls);
            int itemCount = _scrollStub.GetNumberOfItems("dummySelector");

            // Assert
            Assert.AreEqual(20 + (maxScrolls * 10), itemCount, "The total number of items should reflect the maximum number of scrolls.");
        }
    }
}
