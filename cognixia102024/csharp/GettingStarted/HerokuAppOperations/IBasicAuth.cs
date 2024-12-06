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

using System; // Importing the System namespace for basic types and essential classes.
using System.Collections.Generic; // Importing the System.Collections.Generic namespace (not used here but can be useful for future extensions).
using System.Linq; // Importing the System.Linq namespace (not used here but might be helpful for future querying tasks).
using System.Text; // Importing the System.Text namespace (not used here, but could be useful for string manipulation).
using System.Threading.Tasks; // Importing the System.Threading.Tasks namespace (not used here, but useful for asynchronous tasks).

namespace HerokuAppOperations
{
    public interface IBasicAuth
    {
        // Navigate to the Basic Authentication page
        void NavigateToBasicAuthPage();

        // Enter the username in the Basic Authentication dialog
        void EnterUsername(string username);

        // Enter the password in the Basic Authentication dialog
        void EnterPassword(string password);

        // Check if authentication is successful by verifying a page element
        bool IsAuthenticationSuccessful();

        // Check if the user is still on the login page after authentication failure
        bool IsOnLoginPage();

        // Perform logout action (if applicable)
        void LogOut();

        // Close the browser after test execution
        void Close();
    }
}
