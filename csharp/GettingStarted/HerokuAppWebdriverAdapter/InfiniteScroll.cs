using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace HerokuAppWebdriverAdapter
{
    public class InfiniteScroll
    {

        /// <summary>
        /// Stub implementation of IInfiniteScroll for testing purposes.
        /// </summary>
        public class InfiniteScrollStub : HerokuAppCommon, IInfiniteScroll
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
    }
}
