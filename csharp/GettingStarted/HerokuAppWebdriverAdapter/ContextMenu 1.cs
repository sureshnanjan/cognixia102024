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
using HerokuAppOperations;

namespace HerokuAppWebdriverAdapter
{
    public class ContextMenu : IContextMenu
    {
        private string[] menuOptions = { "Option 1", "Option 2", "Option 3" };

        public void RightClickOnElement()
        {
            // Simulate right-click action (this could be more complex with actual UI testing, e.g., using Selenium)
            Console.WriteLine("Right-click action performed.");
        }

        public string[] GetMenuOptions()
        {
            // Return available menu options after right-click
            return menuOptions;
        }

        public void SelectMenuOption(string option)
        {
            // Simulate selecting a menu option
            Console.WriteLine($"{option} selected.");
        }
    }
}
