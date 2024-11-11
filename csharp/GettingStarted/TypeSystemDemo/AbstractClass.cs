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

namespace TypeSystemDemo
{
    // Abstract class representing a generic vehicle
    public abstract class Vehicle
    {
        // Abstract method that must be implemented by derived classes
        public abstract void Drive();

        // Regular method to display vehicle info
        public void DisplayInfo()
        {
            Console.WriteLine("This is a vehicle.");
        }
    }

    // Derived class for Car
    public class fourwheel : Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        // Constructor to initialize car details
        public fourwheel(string make, string model)
        {
            Make = make;
            Model = model;
        }

        // Override the Drive method to specify the car's driving behavior
        public override void Drive()
        {
            Console.WriteLine($"Driving the car: {Make} {Model}");
        }
    }

    // Derived class for Bike
    public class motorcycle : Vehicle
    {
        public string Brand { get; set; }

        // Constructor to initialize bike details
        public motorcycle(string brand)
        {
            Brand = brand;
        }

        // Override the Drive method to specify the bike's driving behavior
        public override void Drive()
        {
            Console.WriteLine($"Riding the bike: {Brand}");
        }
    }
}

    
           
        
    