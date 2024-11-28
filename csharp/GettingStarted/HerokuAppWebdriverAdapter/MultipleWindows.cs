// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class MultipleWindows
    {
        private IWebDriver driver;

        // Constructor to initialize WebDriver (e.g., ChromeDriver)
        public MultipleWindows()
        {
            driver = new ChromeDriver();
        }

        // Method to navigate to the 'Multiple Windows' page
        public void NavigateToMultipleWindowsPage()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            driver.FindElement(By.LinkText("Multiple Windows")).Click();
        }

        // Method to open a new window
        public void OpenNewWindow()
        {
            driver.FindElement(By.LinkText("Click Here")).Click();
        }

        // Method to switch to the new window
        public void SwitchToNewWindow()
        {
            string originalWindow = driver.CurrentWindowHandle;
            var allWindows = driver.WindowHandles;
            string newWindow = null;

            foreach (var window in allWindows)
            {
                if (window != originalWindow)
                {
                    newWindow = window;
                    break;
                }
            }

            if (newWindow != null)
            {
                driver.SwitchTo().Window(newWindow);
            }
            else
            {
                throw new InvalidOperationException("No new window found.");
            }
        }

        // Method to get the title of the current window
        public string GetCurrentWindowTitle()
        {
            return driver.Title;
        }

        // Method to check if a new window has been opened
        public bool IsNewWindowOpened()
        {
            var allWindows = driver.WindowHandles;
            return allWindows.Count > 1;
        }
    }
}
