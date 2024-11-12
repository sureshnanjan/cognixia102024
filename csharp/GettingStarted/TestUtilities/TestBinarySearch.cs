using System;
using System;
namespace TestUtilities
{
    [TestClass]
    public class TestBinarySearch
    {
        [TestMethod]
        public void TestItemFound()
        {
            // Arrange
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 10;
            int expected = 0;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);

            // Act
            int result = myb.doSearch();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestItemNotFound_LessThanAllElements()
        {
            // Arrange
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 8;
            int expected = ~0; // Expected complement index for insertion at position 0
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);

            // Act
            int result = myb.doSearch();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestItemNotFound_GreaterThanAllElements()
        {
            // Arrange
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 20;
            int expected = ~input.Length; // Expected complement index for insertion after the last element
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);

            // Act
            int result = myb.doSearch();

            // Assert
            Assert.AreEqual(expected, result);
        }

        

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionThrownCorrectly()
        {
            // Arrange
            int[] input = null;
            int keyToSearch = 8;

            // Act
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            myb.doSearch();
        }

        [TestMethod]
        [ExpectedException(typeof(RankException))]
        public void RankExceptionThrownCorrectly()
        {
            // Arrange
            int[][] input = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
            int keyToSearch = 8;

            // Act
            BinarySearcher myb = new BinarySearcher(input[0], keyToSearch); // Select one sub-array to use with BinarySearcher
            myb.doSearch();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidOperationExceptionThrownForNonComparableType()
        {
            // Arrange
            NonComparable[] input = { new NonComparable(), new NonComparable() };
            NonComparable keyToSearch = new NonComparable();

            // Act
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            myb.doSearch();
        }

        [TestMethod]
        public void TestStringArray_ItemFound()
        {
            // Arrange
            string[] input = { "apple", "banana", "cherry" };
            string keyToSearch = "banana";
            int expected = 1;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);

            // Act
            int result = myb.doSearch();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestStringArray_ItemNotFound()
        {
            // Arrange
            string[] input = { "apple", "banana", "cherry" };
            string keyToSearch = "date";
            int expected = ~3; // Expected index for insertion after the last element
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);

            // Act
            int result = myb.doSearch();

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Helper class to test non-comparable object behavior
        public class NonComparable
        {
            public int Value { get; set; }
        }
    }
}

