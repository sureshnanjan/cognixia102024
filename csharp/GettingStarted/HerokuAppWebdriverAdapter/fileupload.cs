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
