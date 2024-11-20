using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace BrowserAutomation
{
    public class EdgeAutomator
    {
        EdgeDriver driver;

        public EdgeAutomator()
        {
            // Initialize the EdgeDriver (make sure Edge WebDriver is installed)
            driver = new EdgeDriver();

            // Navigate to the URL
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            var links = driver.FindElements(By.TagName("a"));

            // Print the page title
            Console.WriteLine(driver.Title);

            // Click on the "Add/Remove Elements" link
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();

            // Get the page title after the click
            string pageTitle = driver.FindElement(By.TagName("h3")).Text;
       

            // Count the number of links
            int linkCount = links.Count;

            // Print the title
            Console.WriteLine(pageTitle);
            // Output the count of links
            Console.WriteLine($"Total number of links on the page: {linkCount}");

            // Always quit the driver after test
            //  driver.Quit();
        }
    }
}
