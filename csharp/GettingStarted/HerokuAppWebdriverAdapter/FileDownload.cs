using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class FileDownloadWebdriverAdapter : IFileDownload
    {
        private readonly IWebDriver _driver;

        public FileDownloadWebdriverAdapter(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        /// <summary>
        /// Navigates to the file download page on HerokuApp.
        /// </summary>
        public void NavigateToFileDownloadPage()
        {
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
        }

        /// <summary>
        /// Simulates the file download process by clicking the first file link on the page.
        /// </summary>
        public void Download()
        {
            // Find the first file link and click to download the file.
            var fileLink = _driver.FindElement(By.CssSelector(".example a"));
            fileLink.Click();
        }

        /// <summary>
        /// Verifies if a file link exists on the page.
        /// </summary>
        /// <returns>True if a file link exists, false otherwise.</returns>
        public bool IsFileLinkAvailable()
        {
            try
            {
                var fileLink = _driver.FindElement(By.CssSelector(".example a"));
                return fileLink.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
