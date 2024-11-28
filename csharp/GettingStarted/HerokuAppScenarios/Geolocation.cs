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

namespace HerokuAppOperations
{
    /// <summary>
    /// Defines a contract for geolocation operations in a Heroku app.
    /// </summary>
    public interface IGeolocation
    {
        /// <summary>
        /// This method is called when the user clicks the "Where am I?" button or performs an action
        /// to determine their current geolocation.
        /// </summary>
        void OnclickWhereami();

        /// <summary>
        /// This method retrieves and displays the location details such as latitude, longitude,
        /// based on the current geolocation.
        /// </summary>
        void GetLocationDetails();

        /// <summary>
        /// This method is invoked when the user clicks a "Show in Maps" button 
        /// to open the current geolocation in a mapping application, such as Google Maps.
        /// </summary>
        void OnclickShowInMaps();
    }
}

namespace HerokuAppOperations.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// A stub implementation of the IGeolocation interface used for testing purposes.
    /// </summary>
    public class GeolocationStub : IGeolocation
    {
        public bool IsWhereAmIClicked { get; private set; }
        public bool IsLocationDetailsRetrieved { get; private set; }
        public bool IsShowInMapsClicked { get; private set; }

        /// <summary>
        /// Simulates the "Where am I?" button click.
        /// </summary>
        public void OnclickWhereami()
        {
            IsWhereAmIClicked = true;
        }

        /// <summary>
        /// Simulates retrieving and displaying location details.
        /// </summary>
        public void GetLocationDetails()
        {
            IsLocationDetailsRetrieved = true;
        }

        /// <summary>
        /// Simulates opening the current location in a mapping application.
        /// </summary>
        public void OnclickShowInMaps()
        {
            IsShowInMapsClicked = true;
        }
    }

    /// <summary>
    /// Contains NUnit tests for the IGeolocation interface using the GeolocationStub implementation.
    /// </summary>
    [TestFixture]
    public class GeolocationTests
    {
        private GeolocationStub _geolocation;

        /// <summary>
        /// Initializes the GeolocationStub instance before each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _geolocation = new GeolocationStub();
        }

        /// <summary>
        /// Tests that OnclickWhereami sets IsWhereAmIClicked to true.
        /// </summary>
        [Test]
        public void OnclickWhereami_ShouldSetIsWhereAmIClickedToTrue()
        {
            // Act
            _geolocation.OnclickWhereami();

            // Assert
            Assert.IsTrue(_geolocation.IsWhereAmIClicked, "OnclickWhereami should set IsWhereAmIClicked to true.");
        }

        /// <summary>
        /// Tests that GetLocationDetails sets IsLocationDetailsRetrieved to true.
        /// </summary>
        [Test]
        public void GetLocationDetails_ShouldSetIsLocationDetailsRetrievedToTrue()
        {
            // Act
            _geolocation.GetLocationDetails();

            // Assert
            Assert.IsTrue(_geolocation.IsLocationDetailsRetrieved, "GetLocationDetails should set IsLocationDetailsRetrieved to true.");
        }

        /// <summary>
        /// Tests that OnclickShowInMaps sets IsShowInMapsClicked to true.
        /// </summary>
        [Test]
        public void OnclickShowInMaps_ShouldSetIsShowInMapsClickedToTrue()
        {
            // Act
            _geolocation.OnclickShowInMaps();

            // Assert
            Assert.IsTrue(_geolocation.IsShowInMapsClicked, "OnclickShowInMaps should set IsShowInMapsClicked to true.");
        }
    }
}