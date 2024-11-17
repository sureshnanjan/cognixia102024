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

namespace NEW_PROJECT
{
    public class Set_
    {
        public void display()
        {
            // Create (Add)
            HashSet<string> set = new HashSet<string>();
            set.Add("Ajay");
            set.Add("Samson");

            // Read
            Console.WriteLine("Read from Set:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            // Update (Set does not allow direct updates, so we remove and add)
            set.Remove("Ajay");
            set.Add("Ganesh");

            Console.WriteLine("\nAfter Update:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            // Delete
            set.Remove("Alice");

            Console.WriteLine("\nAfter Delete:");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }

    }
}

