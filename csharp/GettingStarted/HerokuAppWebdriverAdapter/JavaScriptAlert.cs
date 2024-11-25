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
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppScenarios
{
    // Class implementing JavaScript alert handling functionality
    public class JavaScriptAlert : HerokuAppCommon, IJavaScriptAlerts
    {
        // Constructor to initialize the driver
        public JavaScriptAlert(IWebDriver driver) : base(driver) { }

        // Method to click the button that triggers a JavaScript alert
        public void ClickforJsAlert()
        {
            IWebElement buton1 = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Alert']"));
            Thread.Sleep(2000); // Adding a delay to observe interaction (not recommended for production code)
            buton1.Click(); // Click the alert button
        }

        // Method to close the JavaScript alert by accepting it
        public void ClickforJsAlertClose()
        {
            IAlert alert = driver.SwitchTo().Alert(); // Switch focus to the alert
            Thread.Sleep(2000); // Adding a delay
            alert.Accept(); // Accept (close) the alert
        }

        // Method to click the button that triggers a JavaScript confirmation dialog
        public void ClickforJsConfirm()
        {
            IWebElement buton2 = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Confirm']"));
            Thread.Sleep(2000); // Adding a delay
            buton2.Click(); // Click the confirm button
        }

        // Method to close the JavaScript confirmation dialog by dismissing it
        public void ClickforJsConfirmClose()
        {
            IAlert alert = driver.SwitchTo().Alert(); // Switch focus to the alert
            Thread.Sleep(2000); // Adding a delay
            alert.Dismiss(); // Dismiss (close without confirming) the alert
        }

        // Method to click the button that triggers a JavaScript prompt
        public void ClickforJsPrompt()
        {
            IWebElement buton3 = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Prompt']"));
            Thread.Sleep(2000); // Adding a delay
            buton3.Click(); // Click the prompt button
        }

        // Method to close the JavaScript prompt with a specified input message
        public void ClickforJsPromptClose(string message)
        {
            IAlert alert = driver.SwitchTo().Alert(); // Switch focus to the alert
            Thread.Sleep(2000); // Adding a delay
            alert.SendKeys(message); // Send the specified message to the prompt input
            Thread.Sleep(2000); // Adding a delay
            alert.Accept(); // Accept (close) the prompt with the input
        }
    }
}