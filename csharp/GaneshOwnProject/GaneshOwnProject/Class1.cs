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
namespace GaneshOwnProject
{
    public class Class1
    {
        // Car class implementing ICar interface
        public class Car : ICar
        {
            public void StartEngine()
            {
                Console.WriteLine("Car engine started.");
            }

            public void StopEngine()
            {
                Console.WriteLine("Car engine stopped.");
            }
        }

        // Bike class implementing IBike interface
        public class Bike : IBike
        {
            public void Pedal()
            {
                Console.WriteLine("Pedaling the bike.");
            }

            public void Brake()
            {
                Console.WriteLine("Bike brake applied.");
            }
        }

    }
}
