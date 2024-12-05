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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppScenarios
{

    [TestFixture] // Marks the class as containing test methods for NUnit
    public class checkbox2
    {
        CheckBox ch; // Declare CheckBox object to interact with the checkbox page

        [SetUp] // Initializes before each test is run
        public void setup()
        {
            ch = new CheckBox(); // Instantiate the CheckBox class to perform actions on the checkboxes
        }

        [Test] // Marks this method as a test
        public void getTitle()
        {
            // Expected title of the checkbox page
            String Expected = "Checkboxes";

            // Actual title fetched from the page using the CheckBox object
            String actual = ch.getTitle();

            // Assert that the actual title matches the expected title
            Assert.AreEqual(Expected, actual);
        }

        [Test] // Marks this method as a test
        public void GetCheckboxOneDefaultStatus()
        {
            // Arrange: Expected status for checkbox 1 (unchecked by default)
            bool expectedStatus = false;

            // Validate the initial status of Checkbox 1 (expected to be unchecked)
            bool actualStatus = ch.getCheckboxOneDefaultStatus();

            // Assert that the status is False (checkbox 1 is unchecked by default)
            Assert.IsFalse(actualStatus, "Checkbox 1 is expected to be unchecked by default.");
        }

        [Test] // Marks this method as a test
        public void GetCheckboxTwoDefaultStatus()
        {
            // Arrange: Expected status for checkbox 2 (checked by default)
            bool expectedStatus = true;

            // Validate the initial status of Checkbox 2 (expected to be checked)
            bool actualStatus = ch.getCheckboxTwoDefaultStatus();

            // Assert that the status is True (checkbox 2 is checked by default)
            Assert.IsTrue(actualStatus, "Checkbox 2 is expected to be checked by default.");
        }

        [Test]
        public void ClickCheckboxOneTest()
        {
            // Store initial state of Checkbox 1
            bool initialStatus = ch.getCheckboxOneDefaultStatus();

            // Click the first checkbox
            ch.ClickCheckboxOne();

            // Assert that the state of the checkbox has changed
            bool newStatus = ch.getCheckboxOneDefaultStatus();
            Assert.AreNotEqual(initialStatus, newStatus, "The state of Checkbox 1 should change after toggling.");
        }

        // Test case for clicking the second checkbox
        [Test]
        public void ClickCheckboxTwoTest()
        {
            // Store initial state of Checkbox 2
            bool initialStatus = ch.getCheckboxTwoDefaultStatus();

            // Click the second checkbox
            ch.ClickCheckboxTwo();

            // Assert that the state of the checkbox has changed
            bool newStatus = ch.getCheckboxTwoDefaultStatus();
            Assert.AreNotEqual(initialStatus, newStatus, "The state of Checkbox 2 should change after toggling.");
        }

        


    }
}
