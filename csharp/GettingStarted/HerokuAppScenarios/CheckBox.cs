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
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class CheckBox
    {
        [Test]
        public void DefaultSettingsWorks() {
            ChromeDriver instance = new ChromeDriver();
            //instance.
            IWebDriver iinst = instance;
            ITakesScreenshot camera = (ITakesScreenshot)iinst;
            ((IJavaScriptExecutor)camera)
            IHomePage page = new HomePage();
            var checkPage = page.navigateToCheckBox();
            bool expectedstatusone = false;
            bool expectedstatustwo = true;
            bool actualone = checkPage.getCHekboxOneSatatus();
            bool actualtwo = checkPage.getCHekboxTwoSatatus();
            Assert.IsTrue(actualtwo);
            Assert.IsFalse(actualone);
        }
        [Test]
        public void OptingOUtofABTestWorks() { 
            ///AAA
            HomePage page = new HomePage();
            page.navigateToABTest();
            string actual = page.getTitle();
        }
    }
}
