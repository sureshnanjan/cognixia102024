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
    // This interface defines the contract for A/B testing operations.
    // An interface in C# is a type that defines a set of methods and properties
    // that the implementing class must provide. It is used to achieve abstraction
    // and multiple inheritance in C#.
    public interface IABTesting
    {
        // Method to opt-in a user to an A/B test.
        // A/B testing is a method of comparing two versions of a webpage or app
        // against each other to determine which one performs better.
        // This method should contain the logic to include a user in an A/B test.
        public void OptInABTest();

        // Method to opt-out a user from an A/B test.
        // This method should contain the logic to exclude a user from an A/B test.
        // Opting out means the user will not be part of the test and will see the
        // default version of the webpage or app.
        public void OptOutABTest();
    }
}