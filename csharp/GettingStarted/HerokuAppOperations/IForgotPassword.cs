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
    /// This interface defines the operations related to the 'Forgot Password' functionality
    /// for the application. It includes methods for verifying the button, entering the email,
    /// and retrieving the password.
    /// </summary>
    public interface IForgotPassword
    {
        /// <summary>
        /// Verifies if the 'Forgot Password' button is enabled or clickable.
        /// This method can be used to check the state of the button before taking action.
        /// </summary>
        public void VerifyingButton();

        /// <summary>
        /// Enters the email address into the 'Forgot Password' form field.
        /// This method will fill the email field, which is required for password retrieval.
        /// </summary>
        public void EnteringEmail();

        /// <summary>
        /// Clicks the 'Retrieve Password' button to initiate the process of password retrieval.
        /// This action triggers the system to send a password reset email.
        /// </summary>
        public void ClickingRetrievPassword();
    }
}