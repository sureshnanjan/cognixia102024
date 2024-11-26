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
    // This interface defines the contract for context menu operations.
    // An interface in C# is a type that defines a set of methods and properties
    // that the implementing class must provide. It is used to achieve abstraction
    // and multiple inheritance in C#.
    public interface IContextMenu
    {
        // Method to handle the action of right-clicking on an element.
        // This method should contain the logic to simulate a right-click action
        // on a specified element within the application.
        void RightClickOnElement();

        // Method to retrieve the available context menu options.
        // This method should return an array of strings, where each string represents
        // an option available in the context menu that appears after a right-click action.
        string[] GetMenuOptions();

        // Method to select a specific menu option.
        // This method should take a string 'option' as a parameter, which specifies
        // the menu option to be selected from the context menu.
        void SelectMenuOption(string option);
    }
}