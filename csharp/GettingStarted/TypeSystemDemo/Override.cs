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

namespace TypeSystemDemo
{
    //override example
    // Base class
    public class Shape
    {
        // Virtual method that can be overridden in derived classes
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    // Derived class: Circle
    public class Circle : Shape
    {
        // Overriding the Draw method in the Circle class
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // Derived class: Rectangle
    public class Rectangle : Shape
    {
        // Overriding the Draw method in the Rectangle class
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }

}

