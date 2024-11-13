using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestUtilities
{
    [TestClass]
    public class TestBinarySearch
    {
        [TestMethod]
        public void TestIntegerIsReturned() { }

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
        public void TestItemNotFound1()
        {
            // Test case for when the search key is less than elements in the array.
            // The expected result is a negative complement of the index of the first larger element.
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 8;
            int expected = ~0;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            int result = myb.doSearch();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestItemNotFound2()
        {
            // Test case for when the search key is greater than all elements in the array.
            // Expected result: negative complement of (index of the last element + 1).
            int[] input2 = { 10, 12, 13, 15 };
            int keyToSearch2 = 16;
            int expected2 = ~(input2.Length);
            BinarySearcher myb2 = new BinarySearcher(input2, keyToSearch2);
            int result2 = myb2.doSearch();
            Assert.AreEqual(expected2, result2);
        }

        [TestMethod]
        public void TestItemNotFound3()
        {
            // Test case for unsorted arrays, where the result may be incorrect or negative.
            int[] input3 = { 10, 13, 12, 15 };
            int keyToSearch3 = 15;
            int expected3 = ~(input3.Length + 1);
            BinarySearcher myb3 = new BinarySearcher(input3, keyToSearch3);
            int result3 = myb3.doSearch();
            Assert.IsTrue(result3 < 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionThrownCorrectly()
        {
            // Test case for handling null input arrays.
            int[] input = null;
            int keyToSearch = 8;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            int result = myb.doSearch();
        }

        [TestMethod]
        [ExpectedException(typeof(RankException))]
        public void RankExceptionThrownCorrectly()
        {
            // Test case for arrays with incorrect dimensions (multi-dimensional arrays).
            int[,] input = new int[1, 2];
            int keyToSearch = 8;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            int result = myb.doSearch();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionCorrectly()
        {
            // Test case for non-integer array types (string arrays).
            string[] input = new string[3];
            int keyToSearch = 8;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            int result = myb.doSearch();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidOperationExceptionCorrectly()
        {
            // Test case for an invalid operation where array is not of the expected type.
            string[] input = new string[3];
            int keyToSearch = 8;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            int result = myb.doSearch();
        }
    }
}