﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
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
            //Links Total Number
            Console.WriteLine("Displaying the links and number of link is:");
            var clink = driver.FindElements(By.TagName("li"));
            foreach (var li in clink)
            {
                Console.WriteLine(li.Text);
            }
            Console.WriteLine($"Number of links on the page: {clink.Count}");
            // Click on Add Remove Link
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            // Get The Title
            string pageTitle = driver.FindElement(By.TagName("h3")).Text;
            // Check if it matches Add / Remove Elements
            Console.WriteLine(pageTitle);

        }

    }
}