using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
namespace BrowserAutomation
{
    public class ChromeAutomator
    {
        EdgeDriver driver;

        public ChromeAutomator()
        {
            //driver = new ChromeDriver();
            IWebDriver driver;
            driver = new RemoteWebDriver(new Uri("http://localhost:8666"), new EdgeOptions());
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            Console.WriteLine(driver.Title);
            var links = driver.FindElements(By.TagName("a"));
            Console.WriteLine(links.Count);
        }

    }
}
