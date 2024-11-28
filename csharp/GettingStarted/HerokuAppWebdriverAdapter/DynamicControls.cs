// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace HerokuAppWebdriverAdapter
{
    public class DynamicControlsPage : IDynamicControls
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        // Locators
        private By pageTitle = By.TagName("h4");
        private By checkbox = By.Id("checkbox");
        private By toggleButton = By.XPath("//*[@id=\"input-example\"]/button");
        private By message = By.Id("message");
        
        // Constructor

        public DynamicControlsPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        public string GetTitle()
        {
            return _driver.FindElement(pageTitle).Text;
        }

        public void EnableCheckbox()
        {
            // Click the toggle button to enable the checkbox
            _driver.FindElement(toggleButton).Click();

            // Wait until the message indicates the checkbox is enabled
            try
            {
                _wait.Until(d =>
                {
                    var messageElement = d.FindElement(message);
                    Console.WriteLine($"Message displayed: {messageElement.Text}"); // Debugging log
                    return messageElement.Displayed && messageElement.Text.Contains("enabled");
                });
            }
            catch (WebDriverTimeoutException)
            {
                throw new WebDriverTimeoutException("The checkbox did not get enabled within the expected time.");
            }
        }
        public void DisableCheckbox()
        {
            // Click the toggle button to disable the checkbox (first click)
            _driver.FindElement(toggleButton).Click();
            Console.WriteLine("First click on toggle button to disable the checkbox...");

            // Wait for a short delay to allow the state change (e.g., to wait for the message to update)
            System.Threading.Thread.Sleep(5000);  // Delay of 5 second, adjust if necessary

            // Click the toggle button again to finalize the action (second click)
            _driver.FindElement(toggleButton).Click();
            Console.WriteLine("Second click on toggle button to finalize disabling the checkbox...");

            // Wait until the message indicates the checkbox is disabled
            try
            {
                _wait.Until(d =>
                {
                    var messageElement = d.FindElement(message);
                    Console.WriteLine($"Message displayed: {messageElement.Text}"); // Debugging log
                    return messageElement.Displayed && messageElement.Text.Contains("disabled");
                });
                Console.WriteLine("Checkbox is successfully disabled.");
            }
            catch (WebDriverTimeoutException)
            {
                // Log the failure if the checkbox is not disabled
                Console.WriteLine("Timeout occurred while waiting for checkbox to be disabled.");
                throw new WebDriverTimeoutException("The checkbox did not get disabled within the expected time.");
            }
        }





        public bool IsCheckboxEnabled()
        {
            try
            {
                return _driver.FindElement(checkbox).Enabled;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
