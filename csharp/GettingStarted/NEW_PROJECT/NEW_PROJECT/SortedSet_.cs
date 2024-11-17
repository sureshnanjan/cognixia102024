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
    public class SortedSet_
    {
        public void display()
        {
            // Create (Add)
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(3);
            sortedSet.Add(1);
            sortedSet.Add(2);

            // Read
            Console.WriteLine("Read from SortedSet:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);  // Outputs: 1, 2, 3 (sorted)
            }

            // Update (SortedSet does not allow direct updates, so remove and add)
            sortedSet.Remove(2);
            sortedSet.Add(4);

            Console.WriteLine("\nAfter Update:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);  // Outputs: 1, 3, 4
            }

            // Delete
            sortedSet.Remove(1);

            Console.WriteLine("\nAfter Delete:");
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);  // Outputs: 3, 4
            }
        }
    }
}
