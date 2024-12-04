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
    // Defining the IBasicAuth interface, which outlines methods for handling basic authentication and sign-in logic.
    public interface IBasicAuth
    {
        // Method to navigate to the Basic Authentication page
        void NavigateToBasicAuthPage();

        // Method to validate if the authentication was successful
        bool IsAuthenticationSuccessful();

        // Method to print the success message upon successful authentication
        void PrintSuccessMessage();

        // Method to enter the username in the username field
        void EnterUsername(string username);

        // Method to enter the password in the password field
        void EnterPassword(string password);

        // Method to click the "Sign In" or "Login" button
        void ClickSignInButton();

        // Method to check if the user has been successfully redirected after signing in
        bool IsUserRedirectedToDashboard();

        // Method to log out the user
        void LogOut();

        // Optional: Method to check if the user is on the login page
        bool IsOnLoginPage();
    }
}
