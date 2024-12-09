using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

namespace HerokuAppWebdriverAdapter
{
    public class AddRemovePage : HerokuAppCommon, IAddRemove
    {
        // Constructor which uses inherited WebDriver from HerokuAppCommon
        //private IWebDriver driver;
        private WebDriverWait wait;
        public AddRemovePage() : base()
        {
            //driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
        }
        public AddRemovePage(IWebDriver driver) : base(driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
        }
        // Method to get the page title
        public string getTitle()
        {
            //string ele = driver.FindElement(By.XPath("//h3[normalize-space()='Add/Remove Elements']"));
            string ele = driver.FindElement(By.XPath("//h3[normalize-space()='Add/Remove Elements']")).Text;
            // Console.WriteLine(ele);
            return ele;
        }

        // Method to add an element
        public void AddElement()
        {
            driver.FindElement(By.XPath("//html/body/div[2]/div/div/button")).Click();
        }

        // Method to delete an element
        public void DeleteElement()
        {
            var deleteButton = driver.FindElements(By.XPath("/html/body/div[2]/div/div/div/button"));
            if (deleteButton.Count > 0)
            {
                deleteButton[0].Click();
            }
        }

        // Method to get count of elements on the page
        public int GetCountofElements()
        {
            return driver.FindElements(By.XPath("/html/body/div[2]/div/div/div/button")).Count;
        }
        public void Quit()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}