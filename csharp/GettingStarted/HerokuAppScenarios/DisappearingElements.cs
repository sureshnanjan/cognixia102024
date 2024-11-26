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
//using HerokuAppOperations;
//using HerokuAppWebdriverAdapter;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//namespace HerokuAppScenarios
//{
//    [TestFixture]
//    public class DisappearingElements
//    {
//        [Test]
//        public void VerifyMenuItemsPresenceAndNavigation()
//        {
//            // Initialize WebDriver
//            ChromeDriver instance = new ChromeDriver();
//            IWebDriver driver = instance;

//            try
//            {
//                // Navigate to the home page
//                IHomePage page = new HomePage(driver);
//                var disappearingElementsPage = page.NavigateToDisappearingElements();

//                // Get the list of available menu items
//                var menuItems = disappearingElementsPage.GetMenuItems();

//                // Expected menu items
//                var expectedMenuItems = new List<string> { "Home", "About", "Contact Us", "Portfolio", "Gallery" };

//                // Verify all expected menu items are present
//                foreach (var menuItem in expectedMenuItems)
//                {
//                    if (menuItem == "Home")
//                    {
//                        // Click on "Home" and verify navigation to the home page
//                        disappearingElementsPage.ClickMenuItem(menuItem);
//                        string actualTitle = disappearingElementsPage.GetNavigationResult();
//                        Assert.AreEqual("The Internet", actualTitle, "Navigation to 'Home' failed.");
//                    }
//                    else
//                    {
//                        // Verify other menu items navigate to "Not Found" or equivalent page
//                        if (disappearingElementsPage.IsMenuItemPresent(menuItem))
//                        {
//                            disappearingElementsPage.ClickMenuItem(menuItem);
//                            string actualTitle = disappearingElementsPage.GetNavigationResult();
//                            Assert.AreEqual("Not Found", actualTitle, $"Navigation for '{menuItem}' did not show 'Not Found'.");
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Menu item '{menuItem}' is not present on the page.");
//                        }
//                    }
//                }
//            }
//            finally
//            {
//                // Close the browser
//                driver.Quit();
//            }
//        }
//    }
//}
