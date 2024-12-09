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
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace HerokuAppOperations
{
    /// <summary>
    /// Implementation of ISortableTables interface for interacting with a sortable table on a webpage.
    /// </summary>
    public class SortableTables : HerokuAppCommon, ISortableTables
    {
        public SortableTables(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            Thread.Sleep(3000);
        }
        public SortableTables()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            Thread.Sleep(3000);

        }

        public int GetColumnCount()
        {
            return 6;
        }

        public int GetRowCount()
        {
            return 5;
        }

        public string GetRowData(int rowIndex, int columnIndex)
        {
            String path = $"//body[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[{rowIndex}]/td[{columnIndex}]";
            IWebElement val = driver.FindElement(By.XPath(path));
            return val.Text;
        }

        public bool SortByColumn(String Column)
        {
            try
            {
                String Text1 = GetRowData(3, 3);
                String path = $"//span[text()='{Column}']";
                IWebElement spanElement = driver.FindElement(By.XPath(path));
                spanElement.Click();
                String Text2 = GetRowData(3, 3);
                return (!Text1.Equals(Text2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
