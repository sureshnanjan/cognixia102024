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
    // This interface defines the contract for adding and removing elements.
    // An interface in C# is a type that defines a set of methods and properties
    // that the implementing class must provide. It is used to achieve abstraction
    // and multiple inheritance in C#.
    public interface IAddRemove
    {
        // Method to get the title of the element.
        // This method should return the title of the element as a string.
        public string getTitle();

        // Method to add an element.
        // This method should contain the logic to add a new element to a collection or list.
        public void AddElement();

        // Method to delete an element.
        // This method should contain the logic to remove an existing element from a collection or list.
        public void DeleteElement();

        // Method to get the count of elements.
        // This method should return the total number of elements currently in the collection or list.
        public int GetCountofElements();
    }
}