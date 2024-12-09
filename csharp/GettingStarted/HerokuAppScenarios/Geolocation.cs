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
using NUnit.Framework;

namespace HerokuAppScenarios
{
    /// <summary>
    /// Test suite for validating Geolocation functionality on the HerokuApp website.
    /// </summary>
    [TestFixture]
    public class GeolocationTests
    {
        private Geolocation geolocation;

        /// <summary>
        /// Sets up the test environment before each test.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            geolocation = new Geolocation();
        }

        /// <summary>
        /// Cleans up after each test.
        /// </summary>
        [TearDown]
        public void Teardown()
        {
            geolocation.Close();
        }

        /// <summary>
        /// Verifies that the geolocation functionality works and latitude/longitude are displayed.
        /// </summary>
        [Test]
        public void VerifyGeolocationDisplaysCoordinates()
        {
            // Arrange: Navigate to the Geolocation page.
            geolocation.NavigateToGeolocationPage();

            // Act: Request the location.
            geolocation.RequestLocation();
            string latitude = geolocation.GetLatitude();
            string longitude = geolocation.GetLongitude();

            // Assert: Verify that latitude and longitude are not null or empty.
            Assert.IsFalse(string.IsNullOrEmpty(latitude), "Latitude is not displayed.");
            Assert.IsFalse(string.IsNullOrEmpty(longitude), "Longitude is not displayed.");
        }

        /// <summary>
        /// Extra Test Case: Verify geolocation page loads successfully.
        /// </summary>
        [Test]
        public void Title()
        {
            // Arrange: Navigate to the Geolocation page.
            geolocation.NavigateToGeolocationPage();

            // Act: Retrieve the page title.
            string actualTitle = geolocation.GetPageTitle(); // Assuming this is implemented as a utility in base class.
            string expectedTitle = "Geolocation";

            // Assert: Verify that the title matches the expected page title.
            Assert.AreEqual(expectedTitle, actualTitle, "Geolocation page did not load successfully.");
        }

        [Test]
        public void Description()
        {
            // Arrange: Navigate to the Geolocation page.
            geolocation.NavigateToGeolocationPage();

            // Act: Retrieve the page title.
            string actualDescription = geolocation.GetPageDescription(); // Assuming this is implemented as a utility in base class.
            string expectedDescription = "Click the button to get your current latitude and longitude";

            // Assert: Verify that the title matches the expected page title.
            Assert.AreEqual(actualDescription, expectedDescription, "Geolocation page did not load successfully.");
        }
        /// <summary>
        /// Verifies that the geolocation functionality works and latitude/longitude are displayed.
        /// </summary>
        [Test]
        public void VerifyCoordinatesAndGoogleLink()
        {
            // Arrange: Navigate to the Geolocation page.
            geolocation.NavigateToGeolocationPage();

            // Act: Request the location.
            geolocation.RequestLocation();
            string latitude = geolocation.GetLatitude();
            string longitude = geolocation.GetLongitude();
            string googleLink = geolocation.ClickSeeItOnGoogle();

            // Assert: Verify that latitude and longitude are not null or empty.
            Assert.IsFalse(string.IsNullOrEmpty(latitude), "Latitude is not displayed.");
            Assert.IsFalse(string.IsNullOrEmpty(longitude), "Longitude is not displayed.");

            // Assert: Verify that the Google Maps link is valid.
            Assert.IsNotNull(googleLink, "Google link is not available.");
            Assert.IsTrue(googleLink.Contains("maps.google.com"), "Google link is incorrect.");
        }
    
}
}
