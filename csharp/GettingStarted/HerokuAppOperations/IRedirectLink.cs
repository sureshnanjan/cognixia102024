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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppOperations
{

    /// <summary>
    /// Defines the contract for interacting with the Redirect page on HerokuApp.
    /// This interface ensures consistency across any implementations for handling URL redirection and authentication operations.
    /// </summary>
    public interface IRedirectPage
    {
        /// <summary>
        /// Clicks on the "Redirect Link" on the main page to initiate the redirection process.
        /// </summary>
        void ClickRedirectLink();

        /// <summary>
        /// Clicks on the button to trigger the redirection to status code-specific pages.
        /// </summary>
        void ClickRedirectButton();

        /// <summary>
        /// Navigates to the page displaying a 200 status code.
        /// </summary>
        void NavigateTo200StatusCode();

        /// <summary>
        /// Clicks on the "here" link to load the content for the 200 status code page.
        /// </summary>
        void ClickHereLinkFor200();

        /// <summary>
        /// Navigates to the page displaying a 301 status code.
        /// </summary>
        void NavigateTo301StatusCode();

        /// <summary>
        /// Clicks on the "here" link to load the content for the 301 status code page.
        /// </summary>
        void ClickHereLinkFor301();

        /// <summary>
        /// Navigates to the page displaying a 404 status code.
        /// </summary>
        void NavigateTo404StatusCode();

        /// <summary>
        /// Clicks on the "here" link to load the content for the 404 status code page.
        /// </summary>
        void ClickHereLinkFor404();

        /// <summary>
        /// Navigates to the page displaying a 500 status code.
        /// </summary>
        void NavigateTo500StatusCode();

        /// <summary>
        /// Clicks on the "here" link to load the content for the 500 status code page.
        /// </summary>
        void ClickHereLinkFor500();
    }
}