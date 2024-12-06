///*
//Licensed to the Software Freedom Conservancy (SFC) under one
//or more contributor license agreements. See the NOTICE file
//distributed with this work for additional information
//regarding copyright ownership. The SFC licenses this file
//to you under the Apache License, Version 2.0 (the
//"License"); you may not use this file except in compliance
//with the License. You may obtain a copy of the License at
//http://www.apache.org/licenses/LICENSE-2.0 
//Unless required by applicable law or agreed to in writing,
//software distributed under the License is distributed on an
//"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
//KIND, either express or implied. See the License for the
//specific language governing permissions and limitations
//under the License.
//*/
//using HerokuAppOperations;
//using NUnit.Framework;
//using System;
//using System.Diagnostics;  // For measuring time
//using System.Net.Http;    // For HttpResponseMessage
//using System.Net;         // For HttpStatusCode

//namespace HerokuAppScenarios
//{
//    public class SlowResourcesTests
//    {
//        private ISlowResources slowResourcesPage;

//        [SetUp]
//        public void Setup()
//        {
//            // Arrange: Initialize the SlowResources page object
//            slowResourcesPage = new SlowResources();
//        }

//        /// <summary>
//        /// Test method to verify that the page navigation works correctly.
//        /// Ensures that the page is navigated to the slow resources page.
//        /// </summary>
//        [Test]
//        public void Test_NavigateToPage()
//        {
//            // Arrange: Initialize expected URL
//            string expectedUrl = "https://the-internet.herokuapp.com/slow";

//            // Act: Navigate to the Slow Resources page
//            slowResourcesPage.NavigateToPage();
//            string actualUrl = slowResourcesPage.GetCurrentUrl(); // Fetch the current URL

//            // Assert: Verify that the current URL is the correct one for the Slow Resources page
//            Assert.AreEqual(expectedUrl, actualUrl, "The URL is not correct.");
//        }

//        /// <summary>
//        /// Test method to verify that the page title is correct when the page is loaded.
//        /// Ensures that the page title is "The Internet".
//        /// </summary>
//        [Test]
//        public void Test_PageTitle()
//        {
//            // Arrange: Initialize expected title
//            string expectedTitle = "The Internet";

//            // Act: Navigate to the Slow Resources page and get the page title
//            slowResourcesPage.NavigateToPage();
//            string pageTitle = slowResourcesPage.GetPageTitle();
//            Console.WriteLine($"Page Title: {pageTitle}");

//            // Assert: Verify the page title
//            Assert.AreEqual(expectedTitle, pageTitle, "Page title does not match.");
//        }

//        /// <summary>
//        /// Test method to verify that the header on the Slow Resources page is correct.
//        /// Ensures that the header text is as expected.
//        /// </summary>
//        [Test]
//        public void Test_HeaderText()
//        {
//            // Arrange: Initialize expected header text
//            string expectedHeaderText = "This page has a resource that is very slow to load";

//            // Act: Navigate to the Slow Resources page and get the header text
//            slowResourcesPage.NavigateToPage();
//            string headerText = slowResourcesPage.GetHeaderText();
//            Console.WriteLine($"Header Text: {headerText}");

//            // Assert: Verify the header text
//            Assert.AreEqual(expectedHeaderText, headerText, "Header text does not match.");
//        }

//        /// <summary>
//        /// Test method to verify that the page content loads correctly after waiting for it.
//        /// Dynamically measures the time taken for the content to load, considering slow resources.
//        /// </summary>
//        [Test]
//        public void Test_ContentAfterLoading()
//        {
//            // Arrange: Expected content and timer setup
//            string expectedContentSubstring = "Some slow content";
//            Stopwatch stopwatch = new Stopwatch();

//            // Act: Navigate to the Slow Resources page and measure time taken to load content
//            slowResourcesPage.NavigateToPage();
//            stopwatch.Start();
//            string contentText = slowResourcesPage.GetContentAfterLoading(); // Fetch content after loading
//            stopwatch.Stop();
//            TimeSpan elapsed = stopwatch.Elapsed;

//            // Assert: Verify content text and loading time
//            Assert.IsTrue(contentText.Contains(expectedContentSubstring), "Content did not load properly.");
//            Assert.LessOrEqual(elapsed.TotalSeconds, 35, "Content took longer than expected to load.");
//            Console.WriteLine($"Content loaded in {elapsed.TotalSeconds} seconds.");
//        }

//        /// <summary>
//        /// Test method to verify the network response for slow external resources.
//        /// Ensures that the response code for a slow resource is 503.
//        /// </summary>
//        [Test]
//        public void Test_SlowExternalResourceResponse()
//        {
//            // Arrange: Expected status code for slow external resource
//            string slowResourceUrl = "https://the-internet.herokuapp.com/slow_external";

//            // Act: Monitor the network response for slow GET requests
//            var response = slowResourcesPage.GetNetworkResponse(slowResourceUrl);

//            // Assert: Verify the response status code
//            Assert.IsNotNull(response, "No network response detected.");

//            // If response is of type HttpResponseMessage
//            if (response is HttpResponseMessage httpResponse)
//            {
//                Assert.AreEqual(503, (int)httpResponse.StatusCode, "Status code of slow resource is not 503.");
//            }
//            // If response is of type HttpWebResponse
//            else if (response is System.Net.HttpWebResponse webResponse)
//            {
//                Assert.AreEqual(HttpStatusCode.ServiceUnavailable, webResponse.StatusCode, "Status code of slow resource is not 503.");
//            }
//            else
//            {
//                Assert.Fail("Unexpected response type.");
//            }

//            // Print response time for debugging
//            Console.WriteLine($"Slow resource response time: {response.ResponseTime} seconds.");
//        }

//        /// <summary>
//        /// Test method to verify network timeout handling if external resource fails to load in a reasonable time.
//        /// </summary>
//        [Test]
//        public void Test_NetworkTimeoutHandling()
//        {
//            // Arrange: Set up timeout duration
//            int timeoutDuration = 5;

//            // Act: Simulate network timeout and handle the timeout exception
//            var response = slowResourcesPage.GetNetworkResponseWithTimeout("https://the-internet.herokuapp.com/slow_external", timeout: timeoutDuration);

//            // Assert: Ensure a TimeoutException is thrown if the network request times out
//            Assert.Throws<TimeoutException>(() =>
//            {
//                if (response == null || response.StatusCode != 200)
//                    throw new TimeoutException("The network request timed out.");
//            });
//        }

//        /// <summary>
//        /// Test method to verify that the response time for slow external resources is logged correctly for debugging purposes.
//        /// </summary>
//        [Test]
//        public void Test_SlowExternalResourceResponseTimeLogging()
//        {
//            // Arrange: URL of the slow external resource
//            string slowResourceUrl = "https://the-internet.herokuapp.com/slow_external";

//            // Act: Monitor the network response for slow GET requests
//            var response = slowResourcesPage.GetNetworkResponse(slowResourceUrl);

//            // Log the response time for debugging
//            Console.WriteLine($"Slow resource response time: {response.ResponseTime} seconds.");

//            // Assert: Ensure that response time is within acceptable limits
//            Assert.LessOrEqual(response.ResponseTime, 30, "The response time is too slow.");
//        }

//        /// <summary>
//        /// Test method to verify page load speed when slow external resources are not present.
//        /// </summary>
//        [Test]
//        public void Test_PageLoadSpeedWithoutSlowResources()
//        {
//            // Arrange: Set expected content text and load speed threshold
//            string expectedContentSubstring = "Some content without slow resources";
//            Stopwatch stopwatch = new Stopwatch();

//            // Act: Navigate to the page and get content without slow resources
//            slowResourcesPage.NavigateToPage();
//            stopwatch.Start();
//            string contentText = slowResourcesPage.GetContentWithoutSlowResources(); // Fetch content without slow resources
//            stopwatch.Stop();
//            TimeSpan elapsed = stopwatch.Elapsed;

//            // Assert: Ensure page load speed is within the expected limit
//            Assert.LessOrEqual(elapsed.TotalSeconds, 5, "The page load time exceeded the acceptable limit.");
//            Console.WriteLine($"Content loaded in {elapsed.TotalSeconds} seconds.");
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            // Arrange: No specific arrangement needed here, as the cleanup is just closing the browser.
//            // Act: Clean up the resources by closing the browser
//            slowResourcesPage.CloseBrowser();
//        }
//    }
//}
