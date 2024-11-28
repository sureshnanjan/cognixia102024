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
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    /// <summary>
    /// A class that handles interaction with nested frames on a webpage using Selenium WebDriver.
    /// </summary>
    public class NestedFrames : HerokuAppCommon, INestedFrames
    {
        // Locators for the frames on the webpage
        private readonly By frameTop = By.Name("frame-top"); // Locator for the top frame.
        private readonly By frameBottom = By.Name("frame-bottom"); // Locator for the bottom frame.
        private readonly By frameLeft = By.Name("frame-left"); // Locator for the left frame inside the top frame.
        private readonly By frameMiddle = By.Name("frame-middle"); // Locator for the middle frame inside the top frame.
        private readonly By frameRight = By.Name("frame-right"); // Locator for the right frame inside the top frame.

        /// <summary>
        /// Constructor to initialize the WebDriver and navigate to the target URL with nested frames.
        /// </summary>
        /// <param name="driver">The Selenium WebDriver instance.</param>
        public NestedFrames(IWebDriver driver) : base(driver)
        {
            // Navigate to the URL where the nested frames are located.
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/nested_frames");
        }

        /// <summary>
        /// Retrieves text from the top frame.
        /// </summary>
        /// <returns>The text from the top frame or a message if the frame is not found.</returns>
        public string GetTopFrameText()
        {
            try
            {
                // Switch to the top frame using the locator.
                driver.SwitchTo().Frame(driver.FindElement(frameTop));
                return "Top Frame (No direct text to retrieve)"; // Placeholder message for top frame.
            }
            catch (NoSuchFrameException)
            {
                // Return a message if the frame is not found.
                return "Top frame not found.";
            }
            finally
            {
                // Switch back to the main (default) content of the webpage.
                driver.SwitchTo().DefaultContent();
            }
        }

        /// <summary>
        /// Retrieves text from the bottom frame.
        /// </summary>
        /// <returns>The text from the bottom frame or a message if the frame is not found.</returns>
        public string GetBottomFrameText()
        {
            try
            {
                // Switch to the bottom frame using the locator.
                driver.SwitchTo().Frame(driver.FindElement(frameBottom));
                // Find the body element inside the frame and retrieve its text.
                var content = driver.FindElement(By.TagName("body")).Text;
                return content.Trim(); // Return the trimmed text content.
            }
            catch (NoSuchFrameException)
            {
                // Return a message if the frame is not found.
                return "Bottom frame not found.";
            }
            finally
            {
                // Switch back to the main (default) content of the webpage.
                driver.SwitchTo().DefaultContent();
            }
        }

        /// <summary>
        /// Retrieves text from the left frame inside the top frame.
        /// </summary>
        /// <returns>The text from the left frame or a message if the frame is not found.</returns>
        public string GetLeftFrameText()
        {
            try
            {
                // Switch to the top frame first.
                driver.SwitchTo().Frame(driver.FindElement(frameTop));
                // Then switch to the left frame inside the top frame.
                driver.SwitchTo().Frame(driver.FindElement(frameLeft));
                // Find the body element inside the frame and retrieve its text.
                var content = driver.FindElement(By.TagName("body")).Text;
                return content.Trim(); // Return the trimmed text content.
            }
            catch (NoSuchFrameException)
            {
                // Return a message if the frame is not found.
                return "Left frame not found.";
            }
            finally
            {
                // Switch back to the main (default) content of the webpage.
                driver.SwitchTo().DefaultContent();
            }
        }

        /// <summary>
        /// Retrieves text from the middle frame inside the top frame.
        /// </summary>
        /// <returns>The text from the middle frame or a message if the frame is not found.</returns>
        public string GetMiddleFrameText()
        {
            try
            {
                // Switch to the top frame first.
                driver.SwitchTo().Frame(driver.FindElement(frameTop));
                // Then switch to the middle frame inside the top frame.
                driver.SwitchTo().Frame(driver.FindElement(frameMiddle));
                // Find the body element inside the frame and retrieve its text.
                var content = driver.FindElement(By.TagName("body")).Text;
                return content.Trim(); // Return the trimmed text content.
            }
            catch (NoSuchFrameException)
            {
                // Return a message if the frame is not found.
                return "Middle frame not found.";
            }
            finally
            {
                // Switch back to the main (default) content of the webpage.
                driver.SwitchTo().DefaultContent();
            }
        }

        /// <summary>
        /// Retrieves text from the right frame inside the top frame.
        /// </summary>
        /// <returns>The text from the right frame or a message if the frame is not found.</returns>
        public string GetRightFrameText()
        {
            try
            {
                // Switch to the top frame first.
                driver.SwitchTo().Frame(driver.FindElement(frameTop));
                // Then switch to the right frame inside the top frame.
                driver.SwitchTo().Frame(driver.FindElement(frameRight));
                // Find the body element inside the frame and retrieve its text.
                var content = driver.FindElement(By.TagName("body")).Text;
                return content.Trim(); // Return the trimmed text content.
            }
            catch (NoSuchFrameException)
            {
                // Return a message if the frame is not found.
                return "Right frame not found.";
            }
            finally
            {
                // Switch back to the main (default) content of the webpage.
                driver.SwitchTo().DefaultContent();
            }
        }
    }
}
