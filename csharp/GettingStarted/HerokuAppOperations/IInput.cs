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
    /// <summary>
    /// Interface for interacting with an input field element.
    /// This interface defines methods to set, get, and modify the value of an input field.
    /// </summary>
    public interface IInput
    {
        /// <summary>
        /// Method to set a specified value in the input field.
        /// </summary>
        /// <param name="value">The value to be set in the input field.</param>
        void SetInputValue(string value);

        /// <summary>
        /// Method to get the current value of the input field.
        /// </summary>
        /// <returns>The current value of the input field as a string.</returns>
        string GetInputValue();

        /// <summary>
        /// Method to increment the current value of the input field by simulating multiple presses of the Up Arrow key.
        /// </summary>
        /// <param name="times">The number of times to press the Up Arrow key to increment the value.</param>
        void IncrementValueUsingArrowKey(int times);

        /// <summary>
        /// Method to decrement the current value of the input field by simulating multiple presses of the Down Arrow key.
        /// </summary>
        /// <param name="times">The number of times to press the Down Arrow key to decrement the value.</param>
        void DecrementValueUsingArrowKey(int times);

        /// <summary>
        /// Method to quit and close the browser session.
        /// </summary>
        void Quit();
    }
}
