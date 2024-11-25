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
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    internal interface IDragandDrop
    {
        // Gets the current text or label of the first draggable square (A).
        string GetSquareAText();

        // Gets the current text or label of the second draggable square (B).
        string GetSquareBText();

        // Performs a drag-and-drop action from square A to square B.
        void DragAToB();

        // Performs a drag-and-drop action from square B to square A.
        void DragBToA();

        // Verifies if the drag-and-drop operation swapped the contents of square A and square B.
        bool IsSwapSuccessful();
    }
}
