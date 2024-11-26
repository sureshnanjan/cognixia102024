﻿///*
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
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HerokuAppScenarios
//{
//    [TestFixture]
//    public class NotificationMessage
//    {
//        [Test]
//        public void NotificationDisplaysCorrectMessage()
//        {
//            // Initialize the ChromeDriver instance
//            ChromeDriver instance = new ChromeDriver();
//            IWebDriver iinst = instance;

//            // Create the page object for HomePage and navigate to Notification Message page
//            IHomePage page = new HomePage();
//            var notificationPage = page.NavigateToNotificationMessage();

//            // Click the link to trigger a notification message
//            notificationPage.ClickNotificationLink();

//            // Retrieve the displayed notification message
//            string notificationMessage = notificationPage.GetNotificationMessage();

//            // Expected messages
//            string[] expectedMessages = {
//                "Action successful",
//                "Action unsuccessful, please try again"
//            };

//            // Assert that the notification message is one of the expected values
//            Assert.IsTrue(Array.Exists(expectedMessages, message => message.Equals(notificationMessage)),
//                $"Unexpected notification message: {notificationMessage}");
//        }
//    }
//}
