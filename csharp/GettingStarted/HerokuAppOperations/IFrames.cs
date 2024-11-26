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
    public interface IFrames
    {


        /// <summary>
        /// This method is called when the user clicks on nested frames
        /// on the webpage, typically for interacting with frames embedded within other frames.
        /// </summary>
        void OnClickingNestedframes();

        /// <summary>
        /// This method is used to check or interact with the top frame on the webpage.
        /// It can be used to verify properties or perform actions specific to the topmost frame.
        /// </summary>
        void CheckTopframe();

        /// <summary>
        /// This method is used to check or interact with the bottom frame on the webpage.
        /// It can be used to verify properties or perform actions specific to the bottom frame.
        /// </summary>
        void CheckBottomframe();

        /// <summary>
        /// This method is used to check or interact with the left frame on the webpage.
        /// It can be used to verify properties or perform actions specific to the leftmost frame.
        /// </summary>
        void CheckLeftframe();

        /// <summary>
        /// This method is used to check or interact with the right frame on the webpage.
        /// It can be used to verify properties or perform actions specific to the rightmost frame.
        /// </summary>
        void CheckRightframe();

        /// <summary>
        /// This method is used to check or interact with the middle frame on the webpage.
        /// It can be used to verify properties or perform actions specific to the middle frame.
        /// </summary>
        void CheckMiddleframe();

        /// <summary>
        /// This method is invoked when the user clicks on iframe,
        /// typically for interacting with inline frames (iframe elements) embedded in the webpage.
        /// </summary>
        void OnClickingiFrame();
    }
}
