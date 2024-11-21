using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class floatingmenu : HerokuAppCommon, Ifloatingmenu

    {
        public void CloseBrowser()
        {
            
        }

        public bool IsFloatingMenuVisible()
        {
            try
            {
                // Locate the floating menu
                IWebElement floatingMenu = driver.FindElement(By.Id("menu"));
                // Check if the menu is displayed
                return floatingMenu.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

     

        public void ScrollTo(int position)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript($"window.scrollTo(0, {position});");
        }
    }
}
