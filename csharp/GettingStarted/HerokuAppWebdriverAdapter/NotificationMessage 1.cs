using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class NotificationMessage : HerokuAppCommon, INotificationMessage
    {
        private By notificationLink;
        private By notificationText;

        public NotificationMessage(IWebDriver driver) : base(driver)
        {
            this.notificationLink = By.LinkText("Click here"); // Link to trigger a new notification
            this.notificationText = By.Id("flash");           // Locator for the notification message
        }

        public void ClickNotificationLink()
        {
            this.driver.FindElement(notificationLink).Click();
        }

        public string GetNotificationMessage()
        {
            // Extract and return the notification message text
            return this.driver.FindElement(notificationText).Text.Trim();
        }
    }

}
