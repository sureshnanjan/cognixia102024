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
           // ChromeDriver driver;

            driver = new ChromeDriver();


            // IWebDriver webdriver;
            //driver = new RemoteWebDriver(new Uri("http://localhost:8989"), new ChromeOptions());
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            // Console.WriteLine(webdriver.Title);
            //Click on add remove link
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            //get the title
            String pageTitle = driver.FindElement(By.TagName("h3")).Text;
            Console.WriteLine(pageTitle);
            //check if it matches add/remove elements

        }


    }
}
