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

namespace KeywordLearning;
// Enum defined outside the classes
public enum Status
{
    Unknown,
    Active,
    Inactive,
    Suspended
}

// Class Person that uses the Status enum
public class enumdemo
{
    public string Name { get; set; }
    public Status CurrentStatus { get; set; }

    // Constructor to initialize Name and Status
    public enumdemo(string name, Status status)
    {
        Name = name;
        CurrentStatus = status;
    }

    // Method to display person's information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Status: {CurrentStatus}");
    }
}





