using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HerokuAppWebdriverAdapter
{
    public class HoverActions : HerokuAppCommon, IHoverAction
    {
        private readonly IWebDriver _driver;

        public HoverActions(IWebDriver driver)
        {
            _driver = driver;
        }

        // Hover over the specified element (image in this case)
        public void hoverOverElement(IWebElement element)
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(element).Perform();  // Perform hover action
            Console.WriteLine("Hovered over the element.");
        }

        // Validate that the content appears after hovering (check if user name or link becomes visible)
        public bool validateContentAppears(IWebElement element)
        {
            try
            {
                // Find the content (like username or link) after hovering
                IWebElement content = element.FindElement(By.XPath(".//div[@class='figcaption']//h5"));
                return content.Displayed; // Return true if content is visible after hover
            }
            catch (NoSuchElementException)
            {
                return false; // Return false if content doesn't appear
            }
        }

        // Click on the revealed link (after hover)
        public void clickOnRevealedLink(IWebElement link)
        {
            link.Click();  // Click on the revealed link
            Console.WriteLine("Clicked on the revealed link.");
        }
    }
}
