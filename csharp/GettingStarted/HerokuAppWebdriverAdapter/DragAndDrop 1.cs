///*
//Licensed to the Software Freedom Conservancy (SFC) under one
//or more contributor license agreements. See the NOTICE file
//distributed with this work for additional information
//regarding copyright ownership. The SFC licenses this file
//to you under the Apache License, Version 2.0 (the
//"License"); you may not use this file except in compliance
//with the License. You may obtain a copy of the License at

//  http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing,
//software distributed under the License is distributed on an
//"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
//KIND, either express or implied. See the License for the
//specific language governing permissions and limitations
//under the License.
//*/

using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// Class that provides functionality for drag-and-drop actions between two columns.
    /// It initializes the WebDriver and performs drag-and-drop operations using the Selenium WebDriver and Actions class.
    /// </summary>
    public class DragAndDrop : HerokuAppCommon,IDragAndDrop
    {
        private IWebElement _sourceElement;
        private IWebElement _targetElement;

        /// <summary>
        /// Initializes a new instance of the <see cref="DragAndDrop"/> class.
        /// Locates the source and target elements on the page.
        /// Initializes WebDriver and navigates to the drag-and-drop page.
        /// </summary>
        public DragAndDrop() : base()  // Calls the base constructor to initialize WebDriver and navigate to the app URL.
        {
            // Navigate to the drag-and-drop page specifically
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");

            // Locate the source and target elements for drag-and-drop
            _sourceElement = driver.FindElement(By.Id("column-a"));
            _targetElement = driver.FindElement(By.Id("column-b"));
        }

        /// <summary>
        /// Performs the drag-and-drop operation from the source element to the target element.
        /// </summary>
        public void DragAndDropElements()
        {
            // Perform the drag-and-drop action using the internal elements
            var actions = new Actions(driver);
            actions.DragAndDrop(_sourceElement, _targetElement).Build().Perform();
        }

        /// <summary>
        /// Gets the text of the source element (column A).
        /// </summary>
        /// <returns>The text inside the source element (column A).</returns>
        public string GetSourceElementText()
        {
            return _sourceElement.Text; // Get the text of the source element
        }

        /// <summary>
        /// Gets the text of the target element (column B).
        /// </summary>
        /// <returns>The text inside the target element (column B).</returns>
        public string GetTargetElementText()
        {
            return _targetElement.Text; // Get the text of the target element
        }

        /// <summary>
        /// Cleans up by quitting the WebDriver instance.
        /// </summary>
        public void CleanUp()
        {
            driver.Quit(); // Quit the WebDriver after operation
        }
    }
}
