using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace BrowserAutomation
{

    public class EdgeAutomator
    {
        //IWebDriver driver;
        EdgeDriver driver;
        public EdgeAutomator()
        {
            driver = new EdgeDriver();
            //IWebDriver driver;
            //driver = new RemoteWebDriver(new Uri("http://localhost:8989"), new ChromeOptions());
            // driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
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
