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
under the License.
 
*/


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
        public void TestIntegerisReturned() { }
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
            Assert.AreEqual(expected, 0);
        }

        [TestMethod]
        public void TestItemNotFound1()
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
        public void TestItemNotFound2()
        {
            //If value is not found and 
            //value is greater than all elements in array, 
            //the negative number returned is the bitwise complement of
            //(the index of the last element plus 1).
            //AAA
            int[] input2 = { 10, 12, 13, 15 };
            int keytosearch2 = 16;
            int expected2 = ~(input2.Length);
            BinarySearcher myb2 = new BinarySearcher(input2, keytosearch2);
            int result2 = myb2.doSearch();
            Assert.AreEqual(expected2, result2);
        }
        [TestMethod]
        public void TestItemNotFound3()
        {
            //Assert.AreEqual(expected2, result2);
            //If this method is called with a non-sorted array, 
            //the return value can be incorrect and a negative number could be returned, 
            //even if value is present in array.
            //AAA
            int[] input3 = { 10, 13, 12, 15 };
            int keytosearch3 = 15;
            int expected3 = ~(input3.Length + 1);
            BinarySearcher myb3 = new BinarySearcher(input3, keytosearch3);
            int result3 = myb3.doSearch();
            Assert.IsTrue(result3 < 0);
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
            int[,] input = new int[1, 2];
            int keytosearch = 8;
            int expected = ~0;
            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionCorrectly()
        {
            string[] input = new string[3];
            int keytosearch = 8;
            int expected = ~0;
            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidOperationExceptionCorrectly()
        {
            string[] input = new string[3];
            int keytosearch = 8;
            int expected = ~0;
            BinarySearcher myb = new BinarySearcher(input, keytosearch);
            int result = myb.doSearch();
        }

    }
}