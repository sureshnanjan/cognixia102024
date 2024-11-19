using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
namespace BrowserAutomation
{
    public class ChromeAutomator
    {
        ChromeDriver driver;

        public ChromeAutomator()
        {
            //driver = new ChromeDriver();
            IWebDriver driver;
            driver = new RemoteWebDriver(new Uri("http://localhost:8989"), new ChromeOptions());
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            Console.WriteLine(driver.Title);
        }

    }
}
