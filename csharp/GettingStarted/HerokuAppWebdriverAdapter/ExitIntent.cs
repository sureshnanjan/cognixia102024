using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuAppWebdriverAdapter
{
    public class ExitIntent : HerokuAppCommon, IExitIntent
    {
        public ExitIntent(IWebDriver driver) : base(driver){ }

        //To get the title of the webpage of ExitIntent
        public string getTitle()
        {
            //returning the title
            return driver.Title;
        }
        //To get the description about the ExitIntent
        public string getDescription()
        {
            // Locate the paragraph element using XPath
            IWebElement paragraph = driver.FindElement(By.XPath("//p[contains(text(),'Mouse out of the viewport pane and see a modal win')]"));

            // Get the text content of the paragraph
            string paragraphText = paragraph.Text;

            //returning the content
            return paragraphText;

        }


        public void openModalWindow()
        {
            // Use JavaScript to move the mouse out of the viewport
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // Simulate moving the mouse outside the viewport
            jsExecutor.ExecuteScript("var event = new MouseEvent('mouseleave', { view: window, bubbles: true, cancelable: true }); document.body.dispatchEvent(event);");

            // Wait for the modal to appear (if needed)
            Thread.Sleep(3000); 
            // Adjust the delay as necessary
        }

        public void closeModalWindow()
        {
            //To interact with the modal if it appears
            var CloseButton = driver.FindElement(By.XPath("//p[normalize-space()='Close']"));
            //To provide some delay
            Thread.Sleep(3000);
            //To Close the modal window
            CloseButton.Click();
        }
    }
}
