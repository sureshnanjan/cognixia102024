using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class NotificationMessage
    {
        [Test]
        public void NotificationDisplaysCorrectMessage()
        {
            // Initialize the ChromeDriver instance
            ChromeDriver instance = new ChromeDriver();
            IWebDriver iinst = instance;

            // Create the page object for HomePage and navigate to Notification Message page
            IHomePage page = new HomePage();
            var notificationPage = page.NavigateToNotificationMessage();

            // Click the link to trigger a notification message
            notificationPage.ClickNotificationLink();

            // Retrieve the displayed notification message
            string notificationMessage = notificationPage.GetNotificationMessage();

            // Expected messages
            string[] expectedMessages = {
                "Action successful",
                "Action unsuccessful, please try again"
            };

            // Assert that the notification message is one of the expected values
            Assert.IsTrue(Array.Exists(expectedMessages, message => message.Equals(notificationMessage)),
                $"Unexpected notification message: {notificationMessage}");
        }
    }
}
