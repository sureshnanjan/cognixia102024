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
//*/using HerokuAppOperations;
//using OpenQA.Selenium;
//using System;
//using HerokuAppOperations;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HerokuAppWebdriverAdapter
//{
//    public class CheckBox : HerokuAppCommon, ICheckBox
//    {
//        private By checkbox1;
//        private By checkbox2;
//        public CheckBox(IWebDriver arg): base(arg) {
//            this.checkbox1 = By.XPath("//*[@id='checkboxes']/input[1]");
//            this.checkbox2 = By.XPath("//*[@id='checkboxes']/input[2]");
//        }
//        public CheckBox() : base()
//        {
//            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");
//        }

//        public bool getCheckboxOneStatus()
//        {
//            IWebElement checkboxElement = driver.FindElement(By.XPath("//input[1]"));
//            return checkboxElement.Selected;
//        }

//        public bool getCheckboxTwoStatus()
//        {
//            IWebElement checkboxElement = driver.FindElement(By.XPath("//input[2]"));
//            return checkboxElement.Selected;
//        }

//        public string getTitle()
//        {
//            //throw new NotImplementedException()
//            IWebElement headingElement = driver.FindElement(By.XPath("//h3[normalize-space()='Checkboxes']"));
//            return headingElement.Text;
//        }
//    }
//}
