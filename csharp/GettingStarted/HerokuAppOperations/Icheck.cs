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
    // This interface defines the contract for checkbox operations.
    // An interface in C# is a type that defines a set of methods and properties
    // that the implementing class must provide. It is used to achieve abstraction
    // and multiple inheritance in C#.
    public interface ICheck
    {
        // Method to get the title of the checkbox.
        // This method should return the title of the checkbox as a string.
        string GetTitle();

        // Method to get the checkbox status (checked or unchecked).
        // This method should return a boolean value indicating whether the checkbox
        // is currently checked (true) or unchecked (false).
        bool GetCheckboxStatus();

        // Method to toggle the checkbox status (check/uncheck).
        // This method should change the status of the checkbox from checked to unchecked
        // or from unchecked to checked.
        void ToggleCheckboxStatus();
    }
}