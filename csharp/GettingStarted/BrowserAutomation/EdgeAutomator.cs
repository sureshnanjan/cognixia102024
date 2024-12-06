using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BrowserAutomation
{
    public class EdgeAutomator
    {
        public EdgeAutomator() {
            ////Edge
            //IWebDriver driverEdge;
            //EdgeOptions edgeOptions = new EdgeOptions();
            //driverEdge = new RemoteWebDriver(new Uri("http://localhost:8080"), edgeOptions);
            //driverEdge.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            //Console.WriteLine(driverEdge.Title);
            //var links = driverEdge.FindElements(By.TagName("a"));
            //Console.WriteLine("Total number of links on the page: " + links.Count);
            // Initialize the WebDriver
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/exit_intent"); // Replace with your target URL

            Console.WriteLine(driver.Title);
            // Ensure the page is loaded
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Locate the paragraph element using XPath
            IWebElement paragraph = driver.FindElement(By.XPath("//p[contains(text(),'Mouse out of the viewport pane and see a modal win')]"));

            // Get the text content of the paragraph
            string paragraphText = paragraph.Text;

            Console.WriteLine(paragraphText);

            Thread.Sleep(3000);

            // Use JavaScript to move the mouse out of the viewport
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Simulate moving the mouse outside the viewport
            jsExecutor.ExecuteScript("var event = new MouseEvent('mouseleave', { view: window, bubbles: true, cancelable: true }); document.body.dispatchEvent(event);");

            // Wait for the modal to appear (if needed)
            Thread.Sleep(3000); // Adjust the delay as necessary

            //To interact with the modal if it appears
            var CloseButton = driver.FindElement(By.XPath("//p[normalize-space()='Close']")); // Replace 'modal-id' with the actual ID or selector
           
            Thread.Sleep(3000);
            CloseButton.Click();

            // Close the browser
            //driver.Quit();
        }
    }
}
