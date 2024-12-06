using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    /// <summary>
    /// WebDriver adapter for Exit Intent Modal operations.
    /// </summary>
    public class ExitIntentWebdriverAdapter : IExitIntent
    {
        private readonly IWebDriver _driver;

        public ExitIntentWebdriverAdapter(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToExitIntentPage()
        {
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/exit_intent");
        }

        public bool IsPageLoaded()
        {
            return _driver.Title.Contains("Exit Intent");
        }

        public void TriggerExitIntent()
        {
            var actions = new OpenQA.Selenium.Interactions.Actions(_driver);
            actions.MoveByOffset(-10, -10).Perform();
        }

        public bool IsModalDisplayed()
        {
            try
            {
                var modal = _driver.FindElement(By.ClassName("modal"));
                return modal.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void CloseModal()
        {
            var closeButton = _driver.FindElement(By.LinkText("Close"));
            closeButton.Click();
        }

        public string GetModalMessage()
        {
            var modalBody = _driver.FindElement(By.ClassName("modal-body"));
            return modalBody.Text;
        }

        public string GetTitle()
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public void OpenModalWindow()
        {
            throw new NotImplementedException();
        }

        public void CloseModalWindow()
        {
            throw new NotImplementedException();
        }
    }
}
