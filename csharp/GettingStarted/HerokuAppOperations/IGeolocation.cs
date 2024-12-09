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

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for interacting with the Geolocation page.
    /// Provides methods to retrieve geolocation data and validate its presence.
    /// </summary>
    public interface IGeolocation
    {
        /// <summary>
        /// Navigates to the Geolocation page.
        /// </summary>
        void NavigateToGeolocationPage();

        /// <summary>
        /// Requests the user's location by clicking the "Where am I?" button.
        /// </summary>
        void RequestLocation();

        /// <summary>
        /// Gets the latitude displayed on the page.
        /// </summary>
        /// <returns>The latitude as a string, or null if not found.</returns>
        string GetLatitude();

        /// <summary>
        /// Gets the longitude displayed on the page.
        /// </summary>
        /// <returns>The longitude as a string, or null if not found.</returns>
        string GetLongitude();

        string GetPageTitle();

        string GetPageDescription();
    }
}

