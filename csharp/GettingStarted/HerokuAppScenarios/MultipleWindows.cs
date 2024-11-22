using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppScenarios
{
    public class MultipleWindows
    {
        

        [SetUp]
        public void Setup()
        {
            // Initialize the ChromeDriver and navigate to the website
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }

        [Test]
        public void TestOpenNewWindow()
        {
            ChromeDriver driver = new ChromeDriver();
            // Navigate to the "Multiple Windows" page
            driver.FindElement(By.LinkText("Multiple Windows")).Click();

            // Open the new window
            driver.FindElement(By.LinkText("Click Here")).Click();

            // Switch to the new window
            var originalWindow = driver.CurrentWindowHandle;
            var allWindows = driver.WindowHandles;
            string newWindow = null;
            foreach (var window in allWindows)
            {
                if (window != originalWindow)
                {
                    newWindow = window;
                    break;
                }
            }
            driver.SwitchTo().Window(newWindow);

            // Verify that the new window has opened by checking its title
            Assert.AreEqual("New Window", driver.Title, "The title of the new window should be 'New Window'.");

            // Switch back to the main window
            driver.SwitchTo().Window(originalWindow);
        }

        [Test]
        public void TestMultipleWindowsVerification()
        {
            ChromeDriver driver = new ChromeDriver();
            // Navigate to the "Multiple Windows" page
            driver.FindElement(By.LinkText("Multiple Windows")).Click();

            // Click the link to open a new window
            driver.FindElement(By.LinkText("Click Here")).Click();

            // Ensure that the new window has opened
            var allWindows = driver.WindowHandles;
            Assert.AreEqual(2, allWindows.Count, "There should be two windows open now.");

            // Switch to the new window and verify its content
            string newWindow = allWindows[1]; // The new window is always at index 1
            driver.SwitchTo().Window(newWindow);

            // Check if the new window has the correct title
            Assert.AreEqual("New Window", driver.Title, "The new window should have the title 'New Window'.");

            // Switch back to the main window
            driver.SwitchTo().Window(allWindows[0]);
        }

        [Test]
        public void TestSwitchBackToMainWindow()
        {
            ChromeDriver driver = new ChromeDriver();
            // Navigate to the "Multiple Windows" page
            driver.FindElement(By.LinkText("Multiple Windows")).Click();

            // Open the new window
            driver.FindElement(By.LinkText("Click Here")).Click();

            // Switch to the new window
            var originalWindow = driver.CurrentWindowHandle;
            var allWindows = driver.WindowHandles;
            string newWindow = null;
            foreach (var window in allWindows)
            {
                if (window != originalWindow)
                {
                    newWindow = window;
                    break;
                }
            }
            driver.SwitchTo().Window(newWindow);

            // Switch back to the main window
            driver.SwitchTo().Window(originalWindow);

            // Verify that we are back on the main window by checking the title
            Assert.AreEqual("The Internet", driver.Title, "The title of the main window should be 'The Internet'.");
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver driver = new ChromeDriver();
            // Close the browser after the test
            driver.Quit();
        }
    }
}
