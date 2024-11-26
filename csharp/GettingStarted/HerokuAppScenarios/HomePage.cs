///*
//Licensed to the Software Freedom Conservancy (SFC) under one
//or more contributor license agreements. See the NOTICE file
//distributed with this work for additional information
//regarding copyright ownership. The SFC licenses this file
//to you under the Apache License, Version 2.0 (the
//"License"); you may not use this file except in compliance
//with the License. You may obtain a copy of the License at
 
//  http://www.apache.org/licenses/LICENSE-2.0
 
//Unless required by applicable law or agreed to in writing,
//software distributed under the License is distributed on an
//"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
//KIND, either express or implied. See the License for the
//specific language governing permissions and limitations
//under the License.
//*/using HerokuAppOperations;
//using HerokuAppWebdriverAdapter;
//namespace HerokuAppScenarios
//{
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
//        }

//        [Test]
//        public void HomePageTitleisCorrect()
//        {
//            // AUT Application Under Test
//            IHomePage page = new HomePage();
//            string expected = "Welcome to the-internet no";
//            string actual = page.getTitle();
//            Assert.That(Is.Equals(expected, actual));
//        }

//        [Test]
//        public void HomePageAvailableExamplesAreCorrect()
//        {
//            // AUT Application Under Test
//            IHomePage page = new HomePage();
//            int expected = 46;
//            int actual = page.getAvailableExamples().Length;
//            Assert.That(Is.Equals(expected, actual));
//        }

//        [Test]
//        public void HomeAccesingExamplesWork()
//        {
//            Assert.Pass();
//        }
//    }
//}