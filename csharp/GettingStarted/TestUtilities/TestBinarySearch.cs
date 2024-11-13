using System;
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

namespace TestUtilities
{
    [TestClass]
    public class TestBinarySearch
    {
        [TestMethod]
        public void TestIntegerIsReturned()
        {
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
            // Act
            int result = myb.doSearch();
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
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
        }

        [TestMethod]
        [ExpectedException(typeof(RankException))]
        public void RankExceptionThrownCorrectly()
        {
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
        }
    }
}
