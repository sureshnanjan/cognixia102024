using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    internal class DisappearingElements
    {
        private By menuItemsLocator = By.CssSelector("ul li a"); // Adjust locator as needed

        public DisappearingElements(IWebDriver driver) : base(driver) { }

        public List<string> GetMenuItems()
        {
            var elements = this.driver.FindElements(menuItemsLocator);
            return elements.Select(element => element.Text).ToList();
        }

        public void ClickMenuItem(string menuItemName)
        {
            var menuItems = this.driver.FindElements(menuItemsLocator);
            var menuItem = menuItems.FirstOrDefault(item => item.Text.Equals(menuItemName, StringComparison.OrdinalIgnoreCase));
            if (menuItem != null)
            {
                menuItem.Click();
            }
            else
            {
                throw new NoSuchElementException($"Menu item '{menuItemName}' not found on the page.");
            }
        }

        public bool IsMenuItemPresent(string menuItemName)
        {
            var menuItems = this.driver.FindElements(menuItemsLocator);
            return menuItems.Any(item => item.Text.Equals(menuItemName, StringComparison.OrdinalIgnoreCase));
        }

        public string GetNavigationResult()
        {
            try
            {
                return this.driver.Title; // Returns the page title after navigation
            }
            catch (WebDriverException)
            {
                return "Navigation failed or page not found.";
            }
        }
    }
}
