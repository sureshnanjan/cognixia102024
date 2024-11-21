using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

using HerokuAppOperations;

namespace HerokuAppWebdriverAdapter
{


    
        // Class to handle URL redirection and authentication
        public class RedirectLinkHandler : IRedirectLink
        {
            // Method to navigate to a specified URL
            public void NavigateToUrl(IWebDriver driver, string url)
            {
                driver.Navigate().GoToUrl(url);
            }

            // Method to navigate to a URL with basic authentication
            public void NavigateToUrlWithAuth(IWebDriver driver, string url, string username, string password)
            {
                // Construct the URL with embedded credentials
                string authUrl = $"https://{username}:{password}@{new Uri(url).Host}{new Uri(url).AbsolutePath}";

                // Navigate to the authenticated URL
                driver.Navigate().GoToUrl(authUrl);
            }

            // Method to extract a URL from a link element
            public string ExtractUrlFromLink(IWebDriver driver, By locator)
            {
                // Locate the link element using the provided locator
                IWebElement linkElement = driver.FindElement(locator);

                // Return the href attribute value, which contains the URL
                return linkElement.GetAttribute("href");
            }

    }
    }


