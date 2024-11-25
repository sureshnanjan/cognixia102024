using System;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class DisappearingElements
    {
        [Test]
        public void VerifyMenuItemsPresenceAndNavigation()
        {
            // Initialize WebDriver
            ChromeDriver instance = new ChromeDriver();
            IWebDriver driver = instance;

            try
            {
                // Navigate to the home page
                IHomePage page = new HomePage(driver);
                var disappearingElementsPage = page.NavigateToDisappearingElements();

                // Get the list of available menu items
                var menuItems = disappearingElementsPage.GetMenuItems();

                // Expected menu items
                var expectedMenuItems = new List<string> { "Home", "About", "Contact Us", "Portfolio", "Gallery" };

                // Verify all expected menu items are present
                foreach (var menuItem in expectedMenuItems)
                {
                    if (menuItem == "Home")
                    {
                        // Click on "Home" and verify navigation to the home page
                        disappearingElementsPage.ClickMenuItem(menuItem);
                        string actualTitle = disappearingElementsPage.GetNavigationResult();
                        Assert.AreEqual("The Internet", actualTitle, "Navigation to 'Home' failed.");
                    }
                    else
                    {
                        // Verify other menu items navigate to "Not Found" or equivalent page
                        if (disappearingElementsPage.IsMenuItemPresent(menuItem))
                        {
                            disappearingElementsPage.ClickMenuItem(menuItem);
                            string actualTitle = disappearingElementsPage.GetNavigationResult();
                            Assert.AreEqual("Not Found", actualTitle, $"Navigation for '{menuItem}' did not show 'Not Found'.");
                        }
                        else
                        {
                            Console.WriteLine($"Menu item '{menuItem}' is not present on the page.");
                        }
                    }
                }
            }
            finally
            {
                // Close the browser
                driver.Quit();
            }
        }
    }
}
