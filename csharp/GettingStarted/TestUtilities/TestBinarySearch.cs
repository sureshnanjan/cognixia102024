/*
 
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
http://www.apache.org/licenses/LICENSE-2.0 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License. Done by Sameera
 
*/

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
        public void TestIntegerisReturned()
        {
            // This test would verify if the returned value is an integer.
            //AAA
            int[] input = { 10, 20, 30, 40 };
            int keyToSearch = 20;
            BinarySearcher myb = new BinarySearcher(input, keyToSearch);
            //Act
            int result = myb.doSearch();
            //Assert
            Assert.IsInstanceOfType(result, typeof(int));
        }
        [TestMethod]
        public void TestItemFound()
        {
            // AAA
            int[] input = { 10, 12, 13, 15 };
            int keytosearch = 10;
            int expected = 0;
            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            // Act
            int result = myb.doSearch();
            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestItemNotFound()
        {
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

        [TestMethod]
        public void TestItemNotFoundValueGreater()
        {
            //If value is not found and value is greater than all elements in array,
            //the negative number returned is the bitwise complement of (the index of the last element plus 1).
            // AAA
            int[] input = { 10, 12, 13, 15 };
            int keytosearch = 20;
            int expected = ~(input.Length);
            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestNonSortedArray()
        {
            //If this method is called with a non-sorted array,
            //the return value can be incorrect and a negative number could be returned,
            //even if value is present in array.
            // AAA
            int[] input = { 12, 10, 15, 11 };
            int keytosearch = 8;
            int expected = -1;
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
            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();

        }

        [TestMethod]
        [ExpectedException(typeof(RankException))]
        public void RankExceptionThrownCorrectly()
        {
            int[][] input = new int[][] { };
            int keytosearch = 8;
            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionThrownCorrectly()
        {
            int[] input = new int[] { 10, 12, 13, 15 };
            string keytosearch = "test";
            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]

        public void InvalidOperationThrownCorrectly()
        {
            object[] input = new object[] { new object(), new object() };
            object keytosearch = new object();
            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();

        }
    }
}
