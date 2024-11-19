using OpenQA.Selenium.Chrome;
namespace BrowserAutomation
{
    public class ChromeAutomator
    {
        ChromeDriver driver;

        public ChromeAutomator()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            Console.WriteLine(driver.Title);
        }

    }
}
