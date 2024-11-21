using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace HerokuAppOperations
{
    
    
        // Interface for handling URL redirection and authentication
        public interface IRedirectLink
        {
            // Method to navigate to a specified URL
           public  void NavigateToUrl(IWebDriver driver, string url);

            // Method to navigate to a URL with basic authentication
            public void NavigateToUrlWithAuth(IWebDriver driver, string url, string username, string password);

            // Method to extract a URL from a link element
           public  string ExtractUrlFromLink(IWebDriver driver, By locator);
        }
    }


