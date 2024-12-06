using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net.Http;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class StatusCodes : HerokuAppCommon, IStatusCodes
    {
        private IWebDriver driver;

        // Locator for the page header (<h3> tag)
        private readonly By pageHeader = By.TagName("h3");

        // Locator for the status code text (<p> tag)
        private readonly By statusCodeText = By.TagName("p");

        // Constructor initializes the driver
        public StatusCodes()
        {
            // Initialize WebDriver
            driver = new ChromeDriver();
        }

        // Navigates to the page for a specific HTTP status code
        public void NavigateToStatusCode(string code)
        {
            driver.Navigate().GoToUrl($"https://the-internet.herokuapp.com/status_codes/{code}");
        }

        // Retrieves the page title (<title> tag)
        public string GetPageTitle()
        {
            return driver.Title;  // This gets the <title> tag content of the HTML page
        }

        // Retrieves the header text (from <h3> tag)
        public string GetPageHeader()
        {
            return driver.FindElement(pageHeader).Text;
        }

        // Retrieves the descriptive text (from <p> tag)
        public string GetStatusCodeText()
        {
            return driver.FindElement(statusCodeText).Text;
        }

        // Retrieves the error message (if any)
        public string GetErrorMessage()
        {
            try
            {
                return driver.FindElement(By.ClassName("error-message")).Text; // Look for error message element
            }
            catch (NoSuchElementException)
            {
                return string.Empty;  // Return empty if no error message found
            }
        }

        // Close the browser after tests
        public void CloseBrowser()
        {
            driver.Quit(); // Properly closes the browser after the tests are completed
        }

        // Implemented method to get HTTP status code
        public double GetHttpStatusCode()
        {
            // Make a request to the same URL using HttpClient to fetch the HTTP status code
            string url = driver.Url;  // Get the current URL loaded by the driver
            using (var client = new HttpClient())
            {
                var response = client.SendAsync(new HttpRequestMessage(HttpMethod.Get, url)).Result;
                return (double)response.StatusCode;  // Return the status code as double
            }
        }
    }
}
