<<<<<<< HEAD
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
=======
﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using TestUtilities;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
>>>>>>> 745a973d7373daac7354d7cc7bbd831089d30d2d

namespace TestUtilities
{
    [TestClass]
    public class TestBinarySearch
    {
        [TestMethod]
        public void TestIntegerIsReturned()
        {
<<<<<<< HEAD
            // Arrange
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 10;

=======
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 10;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            int result = myb.doSearch();
            Assert.IsInstanceOfType(result, typeof(int), "Expected an integer result");
        }

        [TestMethod]
        public void TestItemFound()
        {
            // AAA
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 10;
            int expected = 0;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
>>>>>>> 745a973d7373daac7354d7cc7bbd831089d30d2d
            // Act
            BinarySearcher searcher = new BinarySearcher(input, keyToSearch);
            int result = searcher.DoSearch();

            // Assert
            Assert.IsInstanceOfType(result, typeof(int), "Expected an integer result.");
        }

        [TestMethod]
<<<<<<< HEAD
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
=======
        public void TestItemNotFound()
        {
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 8;
            int expected = ~0;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            int result = myb.doSearch();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestItemNotFoundGreater()
        {
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 18;
            int expected = ~4;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            int result = myb.doSearch();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestUnsortedArray()
        {
            int[] input = { 15, 13, 12, 10, 20, 18 };
            int keyToSearch = 18;
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                BinarySearcher myb = new BinarySearcher(input, keyToSearch);
                myb.doSearch();
            });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionThrownCorrectly()
        {
            int[] input = null;
            int keyToSearch = 8;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            myb.doSearch();
>>>>>>> 745a973d7373daac7354d7cc7bbd831089d30d2d
        }

        [TestMethod]
        public void RankExceptionThrownCorrectly()
        {
<<<<<<< HEAD
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
=======
            int[][] input = new int[][] { };
            int keyToSearch = 8;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            myb.doSearch();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionThrown()
        {
            int[] input = { 15, 13, 12, 10, 20, 18 };
            string keyToSearch = "18";
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            myb.doSearch();
>>>>>>> 745a973d7373daac7354d7cc7bbd831089d30d2d
        }
    }
}
