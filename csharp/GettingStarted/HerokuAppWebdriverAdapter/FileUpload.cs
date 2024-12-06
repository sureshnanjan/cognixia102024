using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.IO;  // Add to handle file validation
using HerokuAppOperations;
using SeleniumExtras.WaitHelpers;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// WebDriver adapter implementation of the IFileUpload interface for HerokuApp.
    /// </summary>
    public class FileUploadWebdriverAdapter : IFileUpload
    {
        private readonly IWebDriver _driver;
        private readonly string _fileUploadUrl = "https://the-internet.herokuapp.com/upload";
        private readonly By _fileInputSelector = By.Id("file-upload");
        private readonly By _uploadButtonSelector = By.Id("file-submit");
        private readonly By _uploadedFilesSelector = By.Id("uploaded-files");

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadWebdriverAdapter"/> class.
        /// </summary>
        /// <param name="driver">The WebDriver instance to use for browser interactions.</param>
        public FileUploadWebdriverAdapter(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Navigates to the File Upload page on HerokuApp.
        /// </summary>
        public void NavigateToFileUploadPage()
        {
            _driver.Navigate().GoToUrl(_fileUploadUrl);
        }

        /// <summary>
        /// Checks if the File Upload page is loaded.
        /// </summary>
        /// <returns>True if the page is loaded; otherwise, false.</returns>
        public bool IsPageLoaded()
        {
            return _driver.Url.Equals(_fileUploadUrl, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Chooses a file to upload by setting the file path in the file input field.
        /// </summary>
        /// <param name="filePath">The full path of the file to upload.</param>
        public void ChooseFile(string filePath)
        {
            // Wait for the file input element to be visible and clickable
            // Wait for the file input element to be visible and clickable
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var fileInput = wait.Until(ExpectedConditions.ElementToBeClickable(_fileInputSelector));

            // Ensure the file exists before sending the path to the input field
            if (File.Exists(filePath))
            {
                fileInput.SendKeys(filePath);  // Send the file path to the file input element
            }
            else
            {
                throw new ArgumentException($"File not found at path: {filePath}");
            }
        }

        /// <summary>
        /// Initiates the file upload by clicking the Upload button.
        /// </summary>
        public void FileUpload()
        {
            var uploadButton = _driver.FindElement(_uploadButtonSelector);
            uploadButton.Click();
        }

        /// <summary>
        /// Verifies if the file upload was successful by checking the uploaded files element.
        /// </summary>
        /// <returns>True if the upload is successful; otherwise, false.</returns>
        public bool VerifyUploadSuccess()
        {
            try
            {
                var uploadedFilesElement = _driver.FindElement(_uploadedFilesSelector);
                return !string.IsNullOrEmpty(uploadedFilesElement.Text);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        /// <summary>
        /// Closes the browser by disposing of the WebDriver instance.
        /// </summary>
        public void CloseBrowser()
        {
            _driver.Quit();
        }

        /// <summary>
        /// Retrieves the selected file path from the file input field.
        /// </summary>
        /// <returns>The file path entered into the file input field.</returns>
        public string GetSelectedFilePath()
        {
            var fileInput = _driver.FindElement(_fileInputSelector);
            return fileInput.GetAttribute("value");
        }
    }
}
