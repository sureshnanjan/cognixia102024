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
    /// Defines operations for interacting with nested frames in a webpage.
    /// </summary>
    public interface INestedFrames
    {
        /// <summary>
        /// Retrieves the text content from the top frame of the webpage.
        /// </summary>
        /// <returns>
        /// A string representing the text inside the top frame.
        /// </returns>
        /// <remarks>
        /// Ensure that the driver switches context to the top frame before calling this method.
        /// </remarks>
        public string GetTopFrameText();

        /// <summary>
        /// Retrieves the text content from the bottom frame of the webpage.
        /// </summary>
        /// <returns>
        /// A string representing the text inside the bottom frame.
        /// </returns>
        /// <remarks>
        /// Ensure that the driver switches context to the bottom frame before calling this method.
        /// </remarks>
        public string GetBottomFrameText();

        /// <summary>
        /// Retrieves the text content from the left frame inside the top frame.
        /// </summary>
        /// <returns>
        /// A string representing the text inside the left frame.
        /// </returns>
        /// <remarks>
        /// Switch to the top frame first, then switch to the left frame to extract its content.
        /// </remarks>
        public string GetLeftFrameText();

        /// <summary>
        /// Retrieves the text content from the middle frame inside the top frame.
        /// </summary>
        /// <returns>
        /// A string representing the text inside the middle frame.
        /// </returns>
        /// <remarks>
        /// Switch to the top frame first, then switch to the middle frame to extract its content.
        /// </remarks>
        public string GetMiddleFrameText();

        /// <summary>
        /// Retrieves the text content from the right frame inside the top frame.
        /// </summary>
        /// <returns>
        /// A string representing the text inside the right frame.
        /// </returns>
        /// <remarks>
        /// Switch to the top frame first, then switch to the right frame to extract its content.
        /// </remarks>
        public string GetRightFrameText();
    }
}
