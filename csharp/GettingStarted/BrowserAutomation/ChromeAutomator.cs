using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
namespace BrowserAutomation
{
    public class ChromeAutomator
    {
        //ChromeDriver driver;
        IWebDriver driver;
        string configfile;

        public ChromeAutomator()
        {
            if (configfile.EndsWith("chrome"))
            {
                driver = new ChromeDriver();
            }
            if (configfile.EndsWith("firefox"))
            {
                driver = new FirefoxDriver();
            }

            driver = new ChromeDriver();
            //IWebDriver driver;
            driver = new RemoteWebDriver(new Uri("http://localhost:8989"), new ChromeOptions());
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            Console.WriteLine(driver.Title);
            // Click on Add Remove Link
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            // Get The Title
            string pageTitle = driver.FindElement(By.TagName("h3")).Text;
            // Check if it matches Add / Remove Elements

            Console.WriteLine(pageTitle);
            // Print the total number of links on the Home Page
        }

    }
}
