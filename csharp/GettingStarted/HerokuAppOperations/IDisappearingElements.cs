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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    // This interface defines the contract for operations related to disappearing elements.
    // An interface in C# is a type that defines a set of methods and properties
    // that the implementing class must provide. It is used to achieve abstraction
    // and multiple inheritance in C#.
    internal interface IDisappearingElements
    {
        /// <summary>
        /// Retrieves the list of all available menu items.
        /// This method should return a list of strings, where each string represents
        /// the name of a menu item that is currently available.
        /// </summary>
        /// <returns>A list of menu item names as strings.</returns>
        List<string> GetMenuItems();

        /// <summary>
        /// Clicks on a specified menu item by its name.
        /// This method should contain the logic to simulate a click action on a menu item
        /// identified by its name.
        /// </summary>
        /// <param name="menuItemName">The name of the menu item to click.</param>
        void ClickMenuItem(string menuItemName);

        /// <summary>
        /// Checks if the specified menu item is present on the page.
        /// This method should return a boolean value indicating whether the menu item
        /// identified by its name is currently present on the page.
        /// </summary>
        /// <param name="menuItemName">The name of the menu item.</param>
        /// <returns>True if the menu item is present, otherwise false.</returns>
        bool IsMenuItemPresent(string menuItemName);

        /// <summary>
        /// Validates the navigation result after clicking a menu item.
        /// This method should return the title of the page or an error message
        /// after a menu item has been clicked and the navigation has occurred.
        /// </summary>
        /// <returns>The title of the page or an error message.</returns>
        string GetNavigationResult();
    }
}