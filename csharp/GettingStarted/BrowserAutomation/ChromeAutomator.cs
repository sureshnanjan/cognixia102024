using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using HerokuAppWebdriverAdapter;
namespace BrowserAutomation
{
    public class ChromeAutomator
    {
        //ChromeDriver driver;
        IWebDriver driver;
        string configfile;

        public ChromeAutomator()
        {
            //if (configfile.EndsWith("chrome"))
            //{
            //    driver = new ChromeDriver();
            //}
            //if (configfile.EndsWith("firefox"))
            //{
            //    driver = new FirefoxDriver();
            //}

            driver = new EdgeDriver();
            //IWebDriver driver;
<<<<<<< HEAD
            driver = new RemoteWebDriver(new Uri("http://localhost:61681"), new EdgeOptions());
=======
            driver = new RemoteWebDriver(new Uri("http://localhost:51389"), new EdgeOptions());
>>>>>>> origin/HemanthSelenium-branch
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            Console.WriteLine(driver.Title);

           

            // Click on Add Remove Link
<<<<<<< HEAD
            driver.FindElement(By.LinkText("Forgot Password")).Click();
=======
            driver.FindElement(By.LinkText("Frames")).Click();
>>>>>>> origin/HemanthSelenium-branch
            // Get The Title
           //  string pageTitle = driver.FindElement(By.TagName("h3")).Text;
            // Check if it matches Add / Remove Elements

            // Console.WriteLine(pageTitle);
            // Print the total number of links on the Home Page

<<<<<<< HEAD
            

=======
>>>>>>> origin/HemanthSelenium-branch
        }

    }
}
