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

namespace KeywordLearning
{
    /// <summary>
    /// Provides services for generating greeting and response messages.
    /// </summary>
    public class GreetingService
    {
        /// <summary>
        /// Generates a personalized greeting message.
        /// </summary>
        /// <param name="name">The name of the person to greet.</param>
        /// <returns>A greeting message for the specified name.</returns>
        public string GetGreetingMessage(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
            }

            return $"Hello, {name}! Hope you're having a great day!";
        }

        /// <summary>
        /// Responds to the user's favorite programming language input.
        /// </summary>
        /// <param name="language">The user's favorite programming language.</param>
        /// <returns>A response message based on the provided language.</returns>
        public string GetLanguageResponse(string language)
        {
            if (string.IsNullOrWhiteSpace(language))
            {
                return "You didn't specify a language. That's okay!";
            }

            return $"Wow! {language} is a great programming language!";
        }
    }
}
