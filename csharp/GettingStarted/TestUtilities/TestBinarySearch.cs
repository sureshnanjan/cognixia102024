using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUtilities
{
    [TestClass]
    public class TestBinarySearch
    {
        [TestMethod]
        public void TestIntegerIsReturned()
        {
            // Arrange
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 10;

            // Act
            BinarySearcher searcher = new BinarySearcher(input, keyToSearch);
            int result = searcher.DoSearch();

            // Assert
            Assert.IsInstanceOfType(result, typeof(int), "Expected an integer result.");
        }

        [TestMethod]
        public void TestItemFound()
        {
            // Arrange
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 10;
            int expected = 0;

            // Act
            BinarySearcher searcher = new BinarySearcher(input, keyToSearch);
            int result = searcher.DoSearch();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestItemNotFound()
        {
            // Arrange
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 8;
            int expected = ~0; // Negative complement of the insertion index (0)

            // Act
            BinarySearcher searcher = new BinarySearcher(input, keyToSearch);
            int result = searcher.DoSearch();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestUnsortedArray()
        {
            // Arrange: Unsorted array
            int[] input = { 15, 12, 13, 10 };
            int keyToSearch = 10;

            // Assert: Ensure InvalidOperationException is thrown
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                // Act
                BinarySearcher searcher = new BinarySearcher(input, keyToSearch);
            });
        }

        [TestMethod]
        public void RankExceptionThrownCorrectly()
        {
            // Arrange: Multi-dimensional array (2D array)
            int[,] input = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int keyToSearch = 3;

            // Assert: Ensure RankException is thrown
            Assert.ThrowsException<RankException>(() =>
            {
                // Act: Directly passing a multi-dimensional array to BinarySearcher constructor
                BinarySearcher searcher = new BinarySearcher(input, keyToSearch);  // Will throw RankException
            });
        }

        [TestMethod]
        public void ArgumentExceptionThrown()
        {
            // Arrange: Empty array
            int[] input = Array.Empty<int>();
            int keyToSearch = 10;

            // Assert: Ensure ArgumentException is thrown
            Assert.ThrowsException<ArgumentException>(() =>
            {
                // Act
                BinarySearcher searcher = new BinarySearcher(input, keyToSearch);
            });
        }
    }
}
