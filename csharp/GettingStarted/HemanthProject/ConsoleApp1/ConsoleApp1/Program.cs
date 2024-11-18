
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static HemanthProject.Class1;


namespace HemanthProject;
public class Person1
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

public class MainInterfaceDemo
{
    static void Main(string[] args)
    {
        //        ICar myCar = new Car();
        //        myCar.StartEngine();
        //        myCar.StopEngine();

        //        IBike myBike = new Bike();
        //        myBike.Pedal();
        //        myBike.Brake();

        //    //This is the main function for IComparable interface
        //    var people = new List<Person>
        //{
        //    new Person { Name = "Alice", Age = 30 },
        //    new Person { Name = "Bob", Age = 25 },
        //    new Person { Name = "Charlie", Age = 35 }
        //};

        //    people.Sort();  // This uses CompareTo method
        //    foreach (var person in people)
        //    {
        //        Console.WriteLine($"{person.Name}, {person.Age}");
        //    }



        //    //This is the main funtion for Ienmerable Interface


        //        var collection = new IenumerableDemo();
        //        foreach (var number in collection)
        //        {
        //            Console.WriteLine(number);
        //        }
        //   //This is the main code for Environment Console
        //   EnvironmentConsole enc=new EnvironmentConsole();
        //    enc.display();


        //    //THis is the main method for DirectoryInfo 
        //    DirectoryInfoDemo didd = new DirectoryInfoDemo();
        //    didd.display();












        // Create an object of the Person class
        var person = new Person1
        {
            Name = "John Doe",
            Age = 30,
            City = "New York"
        };



        // Serialize the object to a JSON string
        string jsonString = JsonConvert.SerializeObject(person, Formatting.Indented);

        // Print the JSON string to the console
        Console.WriteLine(jsonString);


        string filePath = @"C:\Testing\cognixia102024\csharp";

        // Write the serialized JSON string to a file
        File.WriteAllText(filePath, jsonString);
        Console.WriteLine($"Serialized data written to {filePath}");

        // Read the JSON string back from the file
        string readJsonString = File.ReadAllText(filePath);
        Console.WriteLine("\nContents of the file:");
        Console.WriteLine(readJsonString);

        // Optional: Deserialize the JSON string back into an object
        Person1 deserializedPerson = JsonConvert.DeserializeObject<Person1>(readJsonString);
        Console.WriteLine($"\nDeserialized object: {deserializedPerson.Name}, {deserializedPerson.Age}, {deserializedPerson.City}");


    }

}
