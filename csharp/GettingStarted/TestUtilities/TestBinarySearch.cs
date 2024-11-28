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
        public void TestItemFound()
        {
            // Arrange
            int[] input = { 1, 3, 5, 7, 9 };
            int keyToSearch = 5;
            int expectedIndex = 2; // Index of 5 in the array

            // Act
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            int result = myb.doSearch();

            // Assert
            Assert.AreEqual(expectedIndex, result);
        }


        [TestMethod]
        public void TestItemNotFound()
        {
            // Arrange
            int[] input = { 1, 3, 5, 7, 9 };
            int keyToSearch = 6; // Not in the array
            int expectedResult = ~3; // Complement of the index where 6 would be inserted

            // Act
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            int result = myb.doSearch();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionThrownCorrectly() {
            int[] input = null;
            int keytosearch = 8;
            int expected = ~0;
            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();

        }
        [TestMethod]
        [ExpectedException(typeof(RankException))]
        public void RankExceptionThrownCorrectly()
        {
            // Arrange: Pass a multi-dimensional array to cause a rank mismatch
            int[,] input = { { 1, 2, 3 }, { 4, 5, 6 } }; // Multi-dimensional array
            int keyToSearch = 8;

            // Act: Create BinarySearcher with invalid array
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            myb.doSearch(); // Should throw RankException
        }





    }
}
