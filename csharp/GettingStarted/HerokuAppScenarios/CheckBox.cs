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
//*/using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using HerokuAppOperations;
//using HerokuAppWebdriverAdapter;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//namespace HerokuAppScenarios
//{
//    [TestFixture]
//    public class checkbox2
//    {
//        CheckBox ch;
//        [SetUp]
//        public void setup()
//        {
//            ch =new CheckBox();
//        }
//        [Test]
//        public void getTitle()
//        {
//            String Expected = "Checkboxes";
//            String actual = ch.getTitle();
//            Assert.AreEqual(Expected, actual);
//        }

//        [Test]
//        public void GetCheckboxOneStatus()
//        {
//            // Validate the initial status of Checkbox 1
//            bool status = ch.getCheckboxOneStatus();
//            Assert.IsFalse(status, "Checkbox 1 is expected to be unchecked by default.");
//        }

//        [Test]
//        public void GetCheckboxTwoStatus()
//        {
//            // Validate the initial status of Checkbox 2
//            bool status = ch.getCheckboxTwoStatus();
//            Assert.IsTrue(status, "Checkbox 2 is expected to be checked by default.");
//        }
//    }
//}
