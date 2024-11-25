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
    // Class for handling A/B testing functionality, inherits common functionality from HerokuAppCommon
    public class ABTest : HerokuAppCommon, IABTesting
    {
        // Constructor to initialize the driver, passing it to the base class
        public ABTest(IWebDriver driver) : base(driver) { }

        // Method to get the description text from the A/B test page
        public string GetDiscription()
        {
            // Locate the description element using XPath
            IWebElement dis = driver.FindElement(By.XPath("//p[contains(text(),'Also known as split testing. This is a way in whic')]"));
            return dis.Text; // Return the text content of the element
        }

        // Method to get the title of the current page
        public string GetTitle()
        {
            return driver.Title; // Retrieve and return the title of the current page
        }

        // Method to opt-in to the A/B test by deleting the opt-out cookie
        public void OptInABTest()
        {
            // Delete the cookie that opts the user out of A/B testing
            driver.Manage().Cookies.DeleteCookie(new Cookie("optimizelyOptOut", "true"));
        }

        // Method to opt-out of the A/B test by adding the opt-out cookie
        public void OptOutABTest()
        {
            // Add a cookie that opts the user out of A/B testing
            driver.Manage().Cookies.AddCookie(new Cookie("optimizelyOptOut", "true"));
        }
    }
}