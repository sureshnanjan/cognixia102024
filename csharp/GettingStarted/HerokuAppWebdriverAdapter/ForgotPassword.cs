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
using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// The ForgotPassword class implements the IForgotPassword interface and defines the actions
    /// required to interact with the 'Forgot Password' feature of the Heroku App.
    /// This class uses Selenium WebDriver to perform actions such as verifying the presence 
    /// of the button, entering the email, and clicking the 'Retrieve Password' button.
    /// </summary>
    public class ForgotPassword : HerokuAppCommon, IForgotPassword
    {
        /// <summary>
        /// Initializes a new instance of the ForgotPassword class with the specified WebDriver.
        /// </summary>
        /// <param name="driver">The WebDriver instance used to interact with the web page.</param>
        public ForgotPassword(IWebDriver driver) : base(driver)
        {

        }

        /// <summary>
        /// Verifies that the 'Forgot Password' button is present and clickable.
        /// This method locates the button using its link text to ensure that it is available for interaction.
        /// </summary>
        public void VerifyingButton()
        {
            driver.FindElement(By.LinkText("Forgot Password"));
        }

        /// <summary>
        /// Enters a predefined email address into the 'Email' input field on the 'Forgot Password' page.
        /// This method simulates typing the email into the email input field to request a password reset.
        /// </summary>
        public void EnteringEmail()
        {
            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("user@example.com");
        }

        /// <summary>
        /// Clicks the 'Reset Password' button to initiate the password retrieval process.
        /// This method simulates clicking the button that triggers sending a password reset email.
        /// </summary>
        public void ClickingRetrievPassword()
        {
            driver.FindElement(By.Id("resetPasswordButton")).Click();
        }
    }
}
