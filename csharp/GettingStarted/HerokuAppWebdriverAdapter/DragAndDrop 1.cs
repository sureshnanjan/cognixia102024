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
*/using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations; 

namespace HerokuAppWebdriverAdapter
{
    public class DragAndDrop : HerokuAppCommon, IDragandDrop
    {
        private By squareA;
        private By squareB;

        public DragAndDrop(IWebDriver driver) : base(driver)
        {
            this.squareA = By.Id("column-a"); // Locator for square A
            this.squareB = By.Id("column-b"); // Locator for square B
        }

        public string GetSquareAText()
        {
            return this.driver.FindElement(squareA).Text;
        }

        public string GetSquareBText()
        {
            return this.driver.FindElement(squareB).Text;
        }

        public void DragAToB()
        {
            var elementA = this.driver.FindElement(squareA);
            var elementB = this.driver.FindElement(squareB);

            Actions actions = new Actions(this.driver);
            actions.DragAndDrop(elementA, elementB).Perform();
        }

        public void DragBToA()
        {
            var elementB = this.driver.FindElement(squareB);
            var elementA = this.driver.FindElement(squareA);

            Actions actions = new Actions(this.driver);
            actions.DragAndDrop(elementB, elementA).Perform();
        }

        public bool IsSwapSuccessful()
        {
            string textA = GetSquareAText();
            string textB = GetSquareBText();

            // Assuming that swapping changes the content or labels of A and B
            return textA == "B" && textB == "A";
        }
    }

}
