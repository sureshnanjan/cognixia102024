using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    // Interface definition for handling context menu operations
    public interface IContextMenu
    {
        // Method to handle the action of right-clicking on an element
        void RightClickOnElement();

        // Method to retrieve the available context menu options
        // Returns an array of strings representing menu options
        string[] GetMenuOptions();

        // Method to select a specific menu option
        // Takes a string 'option' as the parameter, which is the menu option to select
        void SelectMenuOption(string option);
    }
}
