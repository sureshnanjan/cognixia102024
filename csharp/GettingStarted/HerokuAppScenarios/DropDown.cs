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
using NUnit.Framework;
using HerokuAppWebdriverAdapter;
using System;
using System.Collections.Generic;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test class that contains tests for interacting with dropdown elements on the HerokuApp page.
    /// These tests validate the dropdown options and selection functionality.
    /// </summary>
    [TestFixture]
    public class DropdownTests : HerokuAppCommon
    {
        private IDropdown dropdown;

        /// <summary>
        /// Setup method that runs before each test. Initializes the WebDriver and Dropdown instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Initialize the Dropdown class instance which interacts with the dropdown on the page.
            dropdown = new Dropdown();
        }

        /// <summary>
        /// Test to validate the dropdown options.
        /// It checks if there are any options and validates if specific options are present.
        /// </summary>
        [Test]
        public void ValidateDropdownOptions()
        {
            // Arrange: Get all the available options from the dropdown.
            List<string> options = dropdown.GetAllOptionsText();

            // Act: Check that there are options in the dropdown.
            // Assert that there are options available in the dropdown.
            Assert.IsNotEmpty(options, "The dropdown does not have any options.");

            // Act: Print the available options to the console.
            Console.WriteLine("Available Options: " + string.Join(", ", options));

            // Assert: Validate that expected options are present in the dropdown.
            Assert.Contains("Option 1", options, "Option 1 is not present in the dropdown.");
            Assert.Contains("Option 2", options, "Option 2 is not present in the dropdown.");
        }

        /// <summary>
        /// Test to validate selecting an option from the dropdown by visible text.
        /// It selects "Option 1" and "Option 2" and checks if the selected option matches.
        /// </summary>
        [Test]
        public void ValidateOptionSelectionByText()
        {
            // Arrange: No specific arrangement needed here as we will perform selection in the next steps.

            // Act: Select "Option 1" from the dropdown and validate the selection.
            dropdown.SelectOptionByText("Option 1");
            string selectedOption = dropdown.GetSelectedOptionText();

            // Assert: Verify that the selected option matches "Option 1".
            Assert.AreEqual("Option 1", selectedOption, "Failed to select 'Option 1'.");

            // Act: Select "Option 2" from the dropdown and validate the selection.
            dropdown.SelectOptionByText("Option 2");
            selectedOption = dropdown.GetSelectedOptionText();

            // Assert: Verify that the selected option matches "Option 2".
            Assert.AreEqual("Option 2", selectedOption, "Failed to select 'Option 2'.");
        }
        [Test]
        public void ValidateInitialDefaultSelection()
        {
            string defaultSelection = dropdown.GetSelectedOptionText();
            Assert.AreEqual("Please select an option", defaultSelection, "The default selection is incorrect.");
        }

        /// <summary>
        /// Teardown method that runs after each test to close the browser.
        /// Ensures that the dropdown and WebDriver resources are disposed of properly.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Dispose of the dropdown object to release resources after each test.
            dropdown.Dispose();
        }
    }
}
