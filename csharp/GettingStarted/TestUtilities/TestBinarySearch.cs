using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUtilities
{
    [TestClass]
    public class TestBinarySearch
    {
        [TestMethod]
        public void TestIntegerisReturned() { }
        [TestMethod]
        public void TestItemFound() {
            // AAA
            int[] input = { 10, 12, 13, 15 };
            int keytosearch = 10;
            int expected = 0;
            BinarySearcher myb = new BinarySearcher(input , keytosearch);
            // Act
            int result = myb.doSearch();
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestItemNotFound() {
            // If value is not found and
            // value is less than one or more elements in array,
            // the negative number returned is the bitwise complement of
            // the index of the first element that is larger than value.
            // AAA
            int[] input = { 10, 12, 13, 15 };
            int keytosearch = 8;
            int expected = ~0;
            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();
            Assert.AreEqual(expected, result);


        }
    }
}
