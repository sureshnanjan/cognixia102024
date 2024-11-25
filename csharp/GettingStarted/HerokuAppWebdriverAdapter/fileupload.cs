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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HerokuAppWebdriverAdapter
{
    public class fileupload : HerokuAppCommon, Iupload
    {
        public fileupload(IWebDriver driver) : base(driver) { }

 
     //To close the browser after doing the process
        public void CloseBrowser()
        {
            driver.Quit();
        }

        //To choose the file from the localpath
        public void ChooseFile(string filePath)
        {
            IWebElement ChooseFile = driver.FindElement(By.XPath("//input[@id='file-upload']"));
            //String path = @"C:\\Users\\nishanth.jaganthan\\OneDrive - ascendion\\Desktop\\Notes\\hello.txt";
            //driver.Quit();
            Thread.Sleep(2000);
            ChooseFile.SendKeys(filePath);
        
        }
        public void UploadFile()
        {
            //to upload the file
            IWebElement upload = driver.FindElement(By.XPath("//input[@id='file-submit']"));
            Thread.Sleep(2000);
            upload.Click();
        }

    }
}
