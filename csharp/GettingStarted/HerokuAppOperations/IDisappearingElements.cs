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
    /// Interface representing the operations for interacting with the Disappearing Elements page.
    /// Provides methods to retrieve menu items, click a menu item, and refresh the page.
    /// </summary>
    public interface IDisappearingElements
    {
        /// <summary>
        /// Method to get the list of all visible menu items on the page.
        /// </summary>
        /// <returns>A list of strings representing the visible menu items.</returns>
        public List<string> GetMenuItems();

        /// <summary>
        /// Method to click a menu item based on its displayed text.
        /// </summary>
        /// <param name="menuItem">The text of the menu item to click.</param>
        public void ClickMenuItem(string menuItem);

        /// <summary>
        /// Method to refresh the page, reloading the content.
        /// </summary>
        public void RefreshPage();
    }
}
