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
    /// Interface for interacting with the JQuery UI Menus example page on the HerokuApp website.
    /// Defines methods for menu interactions such as navigation and submenu selection.
    /// </summary>
    public interface IJQueryUIMenus
    {
        /// <summary>
        /// Navigates to a specific menu item and optionally selects a submenu item.
        /// This method should contain the logic to navigate to a main menu item
        /// identified by its visible text and optionally select a submenu item.
        /// </summary>
        /// <param name="menuText">The visible text of the main menu item to interact with.</param>
        /// <param name="submenuText">The visible text of the submenu item to select (optional).</param>
        public void SelectMenuItem(string menuText, string submenuText = null);

        /// <summary>
        /// Checks if the menu structure is fully visible and accessible.
        /// This method should contain the logic to verify that all menu items
        /// and submenus are visible and can be interacted with.
        /// </summary>
        public void VerifyMenuAccessibility();

        /// <summary>
        /// Gets the current URL after interacting with a menu item.
        /// This method should return the current URL as a string after a menu item
        /// has been selected and any navigation has occurred.
        /// </summary>
        /// <returns>The current URL as a string.</returns>
        public string GetCurrentUrl();
        void Dispose();
        void SelectMenuItem(string v1, string v2, string submenu);
    }
}