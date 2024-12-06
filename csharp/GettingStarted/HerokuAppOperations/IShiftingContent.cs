
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
*/namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for interacting with the Shifting Content example page on the HerokuApp website.
    /// Defines methods for validating menu items, detecting shifting behavior, and navigation.
    /// </summary>
    public interface IShiftingContent
    {
        /// <summary>
        /// Verifies the menu items on the page to ensure they are loaded correctly.
        /// </summary>
        void VerifyMenuItems();

        /// <summary>
        /// Navigates to a specific menu item based on its text.
        /// </summary>
        /// <param name="menuItemText">The visible text of the menu item to navigate to.</param>
        void NavigateToMenuItem(string menuItemText);

        /// <summary>
        /// Detects if any content on the page shifts unexpectedly by comparing element positions before and after a refresh.
        /// </summary>
        void CheckShiftingBehavior();

        /// <summary>
        /// Gets the current URL of the page.
        /// </summary>
        /// <returns>The current URL as a string.</returns>
        string GetCurrentUrl();
    }
}