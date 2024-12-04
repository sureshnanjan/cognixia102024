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


using System; // Imports the System namespace, providing fundamental classes like string, int, etc.
using System.Collections.Generic; // Imports the collection classes (List, Dictionary, etc.)
using System.Linq; // Imports LINQ methods for querying collections
using System.Text; // Imports the Text namespace, provides classes for working with text encoding and manipulation
using System.Threading.Tasks; // Imports support for asynchronous programming and tasks

// Defining the namespace for the application, used for organizing classes
namespace HerokuAppOperations
{
    // Defining the interface IChallengingDOM, which will be implemented by classes that interact with a web page's DOM
    public interface IChallengingDOM
    {
        // Method declaration for getting the title of the page (returns a string)
        public string GetPageTitle();

        // Method declaration to get the count of rows in a table (returns an integer)
        // This method will be used to determine how many rows are present in a table on the page
        public int GetTableRowCount();

        // Method declaration for clicking the edit button of a specific row in the table (parameter: rowIndex)
        // The rowIndex parameter allows specifying which row's edit button to click
        public bool ClickEditButton(int rowIndex);

        // Method declaration for clicking the delete button of a specific row in the table (parameter: rowIndex)
        // Similar to ClickEditButton, but it is used to delete the row at the specified index
        public bool ClickDeleteButton(int rowIndex);
        public bool ClickFirstButton();
        public bool ClickSecondButton();
        public bool ClickThirdButton();

    }

}

