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

namespace HerokuAppOperations
{
    // This interface defines the contract for operations on the home page.
    // An interface in C# is a type that defines a set of methods and properties
    // that the implementing class must provide. It is used to achieve abstraction
    // and multiple inheritance in C#.
    public interface IHomePage
    {
        // Method to get the title of the home page.
        // This method should return the title of the home page as a string.
        public string getTitle();

        // Method to get the description of the home page.
        // This method should return the description of the home page as a string.
        public string getDescription();

        // Method to get the available examples on the home page.
        // This method should return an array of strings, where each string represents
        // the name of an example available on the home page.
        public string[] getAvailableExamples();

        // Method to navigate to the CheckBox example page.
        // This method should return an instance of the ICheckBox interface,
        // which provides operations related to checkboxes.
        public ICheckBox navigateToCheckBox();

        // Method to navigate to the A/B Testing example page.
        // This method should return an instance of the IABTesting interface,
        // which provides operations related to A/B testing.
        public IABTesting navigateToABTest();

        // Method to navigate to a specific example page by its name.
        // This method should take a string 'exname' as a parameter, which specifies
        // the name of the example to navigate to, and return an object representing
        // the example page.
        public object navigateToExample(string exname);
    }
}