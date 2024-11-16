using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUtilities
{
    [TestClass]
    public class TestBinarySearch
    {
        [TestMethod]
        public void TestItemFound()
        {
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 12;
            int expected = 1;

            BinarySearcher searcher = new BinarySearcher(input, keyToSearch);
            int result = searcher.DoSearch();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestItemNotFound()
        {
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 8;
            int expected = ~0;

            BinarySearcher searcher = new BinarySearcher(input, keyToSearch);
            int result = searcher.DoSearch();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullArrayThrowsException()
        {
            int[] input = null;
            int keyToSearch = 10;

            BinarySearcher searcher = new BinarySearcher(input, keyToSearch);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestUnsortedArrayThrowsException()
        {
            int[] input = { 15, 10, 20, 12 };
            int keyToSearch = 10;

            BinarySearcher searcher = new BinarySearcher(input, keyToSearch);
        }
    }
}
