

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

namespace HemanthProject;

using System;

public class Delegates
{
    // Declare a delegate that takes an int and returns an int
    public delegate int OperationDelegate(int num);
}

public class Calculator
{
    // Method to calculate the square of a number
    public int Square(int x)
    {
        return x * x;
    }

    // Method to calculate double of a number
    public int Double(int x)
    {
        return x * 2;
    }

    // Method to calculate the cube of a number
    public int Cube(int x)
    {
        return x * x * x;
    }

    // Method that accepts a delegate to perform a calculation
    public void PerformOperation(Delegates.OperationDelegate operation, int num)
    {
        int result = operation(num);
        Console.WriteLine("Result: " + result);
    }
}

class Program
{

}
