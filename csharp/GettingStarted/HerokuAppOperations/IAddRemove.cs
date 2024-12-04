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

using System; // Importing the System namespace, which includes fundamental types like string, int, and console functionalities.
using System.Collections.Generic; // Importing collections like List, Dictionary, etc. (not used in this code but might be useful for future extensions).
using System.Linq; // Importing LINQ methods for querying collections (not used in this code but could be useful for querying data).
using System.Text; // Importing the Text namespace for string manipulation (not used in this code).
using System.Threading.Tasks; // Importing support for asynchronous programming (not used in this code).

// Defining the IAddRemove interface inside the HerokuAppOperations namespace.
// The interface outlines the contract that any implementing class must follow.
namespace HerokuAppOperations
{
    // The IAddRemove interface defines the required methods for adding and removing elements
    // in a web application. Any class that implements this interface must provide the actual logic
    // for these methods.
    public interface IAddRemove
    {
        // Method declaration for getting the title of the page.
        // This method returns the title as a string when implemented.
        public string getTitle();

        // Method declaration to add a new element.
        // This method doesn't return anything (void), and the actual logic for adding an element will be implemented in a class.
        public void AddElement();

        // Method declaration to delete an existing element.
        // This method doesn't return anything (void), and the actual logic for deleting an element will be implemented in a class.
        public void DeleteElement();

        // Method declaration for getting the current count of elements.
        // This method returns an integer representing the number of elements on the page.
        public int GetCountofElements();
    }
}

