using HerokuAppOperations;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace HerokuAppWebdriverAdapter
{
    public class BasicAuth : IBasicAuth
    {
        // WebDriver instance
        public IWebDriver driver;

        // Basic Authentication credentials
        public string username = "admin";
        public string password = "admin";
        public string url = "https://the-internet.herokuapp.com/basic_auth";

        // Constructor to initialize WebDriver
        public BasicAuth()
        {
            driver = new ChromeDriver();  // You can also use other browsers like EdgeDriver or FirefoxDriver
        }

        // Navigate to the Basic Auth page with embedded credentials in the URL
        public void NavigateToBasicAuthPage()
        {
            // Formulate the URL with credentials
            string authUrl = $"https://{username}:{password}@the-internet.herokuapp.com/basic_auth";

            // Navigate to the URL with embedded credentials
            driver.Navigate().GoToUrl(authUrl);
        }

        // Validate if the authentication was successful
        public bool IsAuthenticationSuccessful()
        {
            // Wait for the page to load and check for the success message
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath("//div[@class='example']")));

            // Find the success message element and check its text
            var successMessage = driver.FindElement(By.XPath("//div[@class='example']/h3")).Text;
            return successMessage.Contains("Congratulations!");
        }

        // Print the success message if authentication is successful
        public void PrintSuccessMessage()
        {
            if (IsAuthenticationSuccessful())
            {
                // Get the success message and print it
                var successMessage = driver.FindElement(By.XPath("//div[@class='example']/h3")).Text;
                Console.WriteLine("Authentication Successful: " + successMessage);
            }
            else
            {
                Console.WriteLine("Authentication Failed.");
            }
        }

        // Cleanup: Close the browser
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}

