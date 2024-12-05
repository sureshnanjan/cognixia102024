using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
        //public StatusCodes(IWebDriver driver) : base(driver) { }

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
        public string GetPageContent()
        {
            try
            {
                return driver.FindElement(By.TagName("body")).Text;  // Fetch entire body text
            }
            catch (NoSuchElementException)
            {
                return string.Empty;  // Return empty if the element is not found
            }
        }

        public string GetErrorMessage()
        {
            try
            {
                return driver.FindElement(By.ClassName("error-message")).Text; // Check for error message by class
            }
            catch (NoSuchElementException)
            {
                return string.Empty;  // Return empty if no error message element is found
            }
        }


        // Close the browser (cleanup after tests)
        public void CloseBrowser()
        {
            driver.Quit(); // This properly closes the browser after the tests are completed
        }

        public double GetHttpStatusCode()
        {
            throw new NotImplementedException();
        }
    }
}
