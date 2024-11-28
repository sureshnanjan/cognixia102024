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
    /// <summary>
    /// This interface defines the operations related to form-based authentication.
    /// It includes methods for navigating to the login page, entering credentials, 
    /// attempting to log in, and verifying whether the login was successful or failed.
    /// </summary>
    public interface IFormAuthentication
    {
        /// <summary>
        /// Navigates to the login page of the application.
        /// This method will take the user to the page where login credentials can be entered.
        /// </summary>
        public void GetNavigatedTo();

        /// <summary>
        /// Retrieves the login credentials (username and password).
        /// This method can be used to fetch or set the credentials needed for authentication.
        /// </summary>
        public void GetCredentials();

        /// <summary>
        /// Submits the credentials and attempts to log the user in.
        /// This method will trigger the action of logging in using the provided credentials.
        /// </summary>
        public void GetIntoLogin();

        /// <summary>
        /// Verifies whether the login attempt was successful or failed.
        /// This method checks the result of the login attempt and provides feedback on the outcome.
        /// </summary>
        public void VerifyingLoginSuccessorFail();

        /// <summary>
        /// Verifies the login status of the user.
        /// This method can be used to check if the login was successful or if any errors occurred.
        /// </summary>
        public void VerifyingLogin();
    }
}