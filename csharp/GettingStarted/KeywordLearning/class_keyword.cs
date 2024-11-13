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
under the License. Done by Sameera
 
*/
using System.Reflection.Metadata;

namespace KeywordLearning
{
    //interface
    public interface IArea
    {
        public double CalculateArea();
    }

    // abstract class
    public abstract class Shape
    {
        public string _name;
        //constructor
        public Shape(string name)
        {
            _name = name;
        }

        // Abstract method to display shape information
        public abstract void DisplayShapeInfo();
    }

    // Circle class inherits from Shape and implements IArea
    public class Circle : Shape, IArea
    {
        private double _radius { get; set; }
        //constructor
        public Circle(double radius) : base("Circle")
        {
            _radius = radius;
        }

        // Implementing CalculateArea() method from IArea
        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        public override void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: {_name}, Radius: {_radius}");
        }
    }

    // Triangle class inherits from Shape and implements IArea
    public class Triangle : Shape, IArea
    {
        private double _base { get; set; }
        
        private double _height { get; set; }

        public Triangle(double baseLength, double height) : base("Triangle")
        {
            _base = baseLength;
            _height = height;
        }

        // Implementing CalculateArea() method from IArea
        public double CalculateArea()
        {
            return 0.5 * _base * _height;
        }

        public override void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: {_name}, Base: {_base}, Height: {_height}");
        }
    }

}
