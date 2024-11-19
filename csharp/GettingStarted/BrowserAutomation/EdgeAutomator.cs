using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace BrowserAutomation
{
    public class EdgeAutomator
    {
        public EdgeAutomator() {
            ////Edge
            IWebDriver driverEdge;
            EdgeOptions edgeOptions = new EdgeOptions();
            driverEdge = new RemoteWebDriver(new Uri("http://localhost:8080"), edgeOptions);
            driverEdge.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            Console.WriteLine(driverEdge.Title);
            var links = driverEdge.FindElements(By.TagName("a"));
            Console.WriteLine("Total number of links on the page: " + links.Count);

        }
    }
}
