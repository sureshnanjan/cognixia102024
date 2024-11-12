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
            int[] input = { 10, 12, 13, 15 };
            int keyToSearch = 10;
            int expected = 0; 

            BinarySearcher myb = new(input, keyToSearch);

        
            int result = myb.doSearch();

           
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestItemNotFound()
        {
           
            int[] input = { 10, 12, 13, 15 };
            int keytosearch = 8;
            int expected = ~0;
            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestItemNotFoundAndGreater()
        {
           

            int[] input = { 10, 12, 13, 15 };  
            int keytosearch = 20;  
            int expected = ~4;     

            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestItemNotFoundUnsortedArray()
        {
           
            int[] input = { 13, 10, 15, 12 };  
            int keytosearch = 20;  
            int expected = ~4;      

            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();

            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionThrownCorrectly()
        {
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
            int[][] input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };
            int keyToSearch = 8;

          
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);

           
            myb.doSearch();

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionThrownForIncompatibleTypes()
        {
           
            object[] input = new object[] { 10, "string", 13, 15 }; 
            int keyToSearch = 10; 

            
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            int result = myb.doSearch();


        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidOperationExceptionThrownForMissingComparison()
        {
           
            
            object[] input = new object[] { new object(), new object() };
            // object keyToSearch = new object();  
            object keyToSearch = new object();


            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            int result = myb.doSearch();

        }

    }
}
