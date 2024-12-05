using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using OpenQA.Selenium.Support.UI;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace HerokuAppScenarios
{
    /// <summary>
    /// This class contains NUnit test cases that verify the functionality of secure file download on the HerokuApp download page.
    /// It includes tests for verifying the page title, visibility of the download link, and the functionality of the download link.
    /// </summary>
    [TestFixture]
    public class DownloadSecureTests
    {
        IWebDriver driver; // WebDriver instance for interacting with the browser.
        IDownloadSecurePage downloadSecurePage; // Interface for interacting with the "Download Secure" page.
        private string downloadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Downloads"); // Directory to save downloaded files.

        /// <summary>
        /// SetUp method initializes the WebDriver, configures the download location, 
        /// and navigates to the secure download page with authentication credentials.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // Setup Chrome options to define the download directory and other browser settings.
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", downloadDirectory);
            options.AddArgument("headless"); // Optional: Use headless mode for CI environments where a GUI is not available.

            // Initialize the WebDriver with the specified options.
            driver = new ChromeDriver(options);

            // Initialize the page object for interacting with elements on the "Download Secure" page.
            downloadSecurePage = new DownloadSecurePage(driver);

            // Navigate to the download page with authentication credentials embedded in the URL.
            driver.Navigate().GoToUrl("https://admin:admin@the-internet.herokuapp.com/download_secure");
        }

        /// <summary>
        /// Test to verify that the page title is correct.
        /// </summary>
        [Test]
        public void VerifyPageTitle()
        {
            // Get the page title using the method defined in the DownloadSecurePage class.
            string pageTitle = downloadSecurePage.GetPageTitle();

            // Assert that the title of the page is as expected.
            Assert.AreEqual("Secure File Downloader", pageTitle);
        }

        /// <summary>
        /// Test to verify that the download link is visible on the page.
        /// </summary>
        [Test]
        public void VerifyDownloadLinkIsVisible()
        {
            // Check if the download link is visible on the page.
            bool isLinkVisible = downloadSecurePage.IsDownloadLinkVisible();

            // Assert that the download link is visible.
            Assert.IsTrue(isLinkVisible, "Download link is not visible on the page.");
        }

        /// <summary>
        /// Test to verify that the download link is functional and the file is downloaded successfully.
        /// This test simulates clicking the download link, waits for the download to complete, and checks the downloaded file.
        /// </summary>
        [Test]
        public void VerifyDownloadLinkFunctionality()
        {
            // Locate the download link element (text "some-file.txt") on the page.
            IWebElement downloadLink = driver.FindElement(By.LinkText("some-file.txt"));

            // Click on the download link to start downloading the file.
            downloadLink.Click();

            // Use WebDriverWait to wait for the download to complete. The file should appear in the download directory.
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => File.Exists(Path.Combine(downloadDirectory, "some-file.txt")));

            // Define the expected file path where the file should be downloaded.
            string filePath = Path.Combine(downloadDirectory, "some-file.txt");

            // Check if the file exists in the download directory.
            bool fileExists = File.Exists(filePath);

            // Assert that the file has been downloaded successfully.
            Assert.IsTrue(fileExists, "File was not downloaded successfully.");

            // Clean up: Delete the downloaded file after the test is complete to maintain a clean state.
            if (fileExists)
            {
                File.Delete(filePath);
            }
        }

        /// <summary>
        /// TearDown method is called after each test to close the browser and clean up any resources.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Close the WebDriver and the browser to free resources.
            driver.Quit();
        }
    }
}


