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
using HerokuAppOperations;
using OpenQA.Selenium;
using System;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// A class that provides operations for interacting with frames in a web page.
    /// This class uses Selenium WebDriver to interact with the frames on the "Nested Frames" and "iFrames" pages.
    /// </summary>
    public class Frames : HerokuAppCommon, IFrames
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Frames"/> class with the provided WebDriver.
        /// </summary>
        /// <param name="driver">The WebDriver instance used for browser interaction.</param>
        public Frames(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Navigates to the "Nested Frames" page, where multiple frames are present.
        /// This method is used to simulate a user clicking on a link to go to the nested frames page.
        /// </summary>
        public void OnClickingNestedframes()
        {
            // Navigate to the "Nested Frames" page
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/nested_frames");
        }

        /// <summary>
        /// Switches to the top frame of the "Nested Frames" page and prints its contents.
        /// After interacting with the top frame, the method switches back to the default content.
        /// </summary>
        public void CheckTopframe()
        {
            // Switch to the top frame
            driver.SwitchTo().Frame("frame-top");
            // Print the page source of the top frame
            Console.WriteLine("Inside Top Frame: " + driver.PageSource);

            // Return to the default content (main page)
            driver.SwitchTo().DefaultContent();
        }

        /// <summary>
        /// Switches to the bottom frame of the "Nested Frames" page and prints its contents.
        /// After interacting with the bottom frame, the method switches back to the default content.
        /// </summary>
        public void CheckBottomframe()
        {
            // Switch to the bottom frame
            driver.SwitchTo().Frame("frame-bottom");
            // Print the page source of the bottom frame
            Console.WriteLine("Inside Bottom Frame: " + driver.PageSource);

            // Return to the default content (main page)
            driver.SwitchTo().DefaultContent();
        }

        /// <summary>
        /// Switches to the left frame of the "Nested Frames" page and prints its contents.
        /// After interacting with the left frame, the method switches back to the default content.
        /// </summary>
        public void CheckLeftframe()
        {
            // Switch to the left frame (this might be a nested frame inside the top frame)
            driver.SwitchTo().Frame("frame-left");
            // Print the page source of the left frame
            Console.WriteLine("Inside Left Frame: " + driver.PageSource);

            // Return to the default content (main page)
            driver.SwitchTo().DefaultContent();
        }

        /// <summary>
        /// Switches to the right frame of the "Nested Frames" page and prints its contents.
        /// After interacting with the right frame, the method switches back to the default content.
        /// </summary>
        public void CheckRightframe()
        {
            // Switch to the right frame (this might be a nested frame inside the top frame)
            driver.SwitchTo().Frame("frame-right");
            // Print the page source of the right frame
            Console.WriteLine("Inside Right Frame: " + driver.PageSource);

            // Return to the default content (main page)
            driver.SwitchTo().DefaultContent();
        }

        /// <summary>
        /// Switches to the middle frame of the "Nested Frames" page and prints its contents.
        /// After interacting with the middle frame, the method switches back to the default content.
        /// </summary>
        public void CheckMiddleframe()
        {
            // Switch to the middle frame (this is often a nested frame)
            driver.SwitchTo().Frame("frame-middle");
            // Print the page source of the middle frame
            Console.WriteLine("Inside Middle Frame: " + driver.PageSource);

            // Return to the default content (main page)
            driver.SwitchTo().DefaultContent();
        }

        /// <summary>
        /// Navigates to the "iFrames" page, where an iframe is embedded inside the page.
        /// This method simulates a user clicking on a link to access the iframe page.
        /// </summary>
        public void OnClickingiFrame()
        {
            // Navigate to the "iFrames" page
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframes");
        }
    }
}
