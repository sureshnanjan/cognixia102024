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
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;

namespace HerokuAppScenarios
{
    /// <summary>
    /// NUnit tests for Exit Intent Modal functionality.
    /// </summary>
    [TestFixture]
    public class ExitIntentModalTests
    {
        private IWebDriver _driver;
        private IExitIntent _exitIntent;

        [SetUp]
        public void SetUp()
        {
            // Initialize the WebDriver and the Exit Intent adapter.
            _driver = new ChromeDriver();
            _exitIntent = new ExitIntentWebdriverAdapter(_driver);

            // Navigate to the Exit Intent page.
            _exitIntent.NavigateToExitIntentPage();
        }

        [TearDown]
        public void TearDown()
        {
            // Dispose of WebDriver instance after tests.
            if (_driver != null) ;
            {
                _driver.Dispose();
            }

        }

            [Test]
            public void NavigateToExitIntentPage_ShouldMarkPageAsLoaded()
            {
                // Assert
                Assert.IsTrue(_exitIntent.IsPageLoaded(), "The Exit Intent page should be marked as loaded after navigation.");
            }

            [Test]
            public void TriggerExitIntent_ShouldDisplayModal()
            {
                // Act
                _exitIntent.TriggerExitIntent();

                // Assert
                Assert.IsTrue(_exitIntent.IsModalDisplayed(), "The modal should be displayed when exit intent is triggered.");
            }

            [Test]
            public void CloseModal_ShouldHideModal()
            {
                // Arrange
                _exitIntent.TriggerExitIntent();

                // Act
                _exitIntent.CloseModal();

                // Assert
                Assert.IsFalse(_exitIntent.IsModalDisplayed(), "The modal should be hidden after clicking the Close button.");
            }

            [Test]
            public void ModalContent_ShouldDisplayCorrectMessage()
            {
                // Arrange
                _exitIntent.TriggerExitIntent();

                // Act
                string modalMessage = _exitIntent.GetModalMessage();

                // Assert
                Assert.AreEqual("It's commonly used to encourage a user to take an action (e.g., give their e-mail address to sign up for something).", modalMessage, "The modal message should match the expected content.");
            }
    }
}

