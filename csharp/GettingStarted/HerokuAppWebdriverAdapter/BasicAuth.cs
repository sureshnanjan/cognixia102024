
//using HerokuAppWebdriverAdapter;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;
//using System;

//namespace HerokuAppOperations
//{
//    public class BasicAuth : HerokuAppCommon,IBasicAuth
//    {
//        //private IWebDriver driver;
//        private WebDriverWait wait;
//        public BasicAuth(IWebDriver driver) : base(driver)
//        {
//            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//        }
//        public BasicAuth() : base()
//        {
//            // Initialize the driver
//            //driver = new ChromeDriver();
//            // Set up the WebDriverWait for 10 seconds
//            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//        }

//        // Navigate to the Basic Authentication page
//        public void NavigateToBasicAuthPage()
//        {
//            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/basic_auth");
//        }

//        // Enter the username in the Basic Authentication dialog
//        public void EnterUsername(string username)
//        {
//            try
//            {
//                IAlert alert = driver.SwitchTo().Alert();
//                alert.SendKeys(username);
//                alert.SendKeys(Keys.Tab); // Tab to password field
//                alert.Accept();
//            }
//            catch (NoAlertPresentException)
//            {
//                Console.WriteLine("No authentication alert present.");
//            }
//        }

//        // Enter the password in the Basic Authentication dialog
//        public void EnterPassword(string password)
//        {
//            try
//            {
//                var alert = driver.SwitchTo().Alert();
//                alert.SendKeys(password);
//                alert.Accept(); // Accept the alert (submit)
//            }
//            catch (NoAlertPresentException)
//            {
//                Console.WriteLine("No authentication alert present.");
//            }
//        }

//        // Check if authentication was successful by looking for an element on the page
//        public bool IsAuthenticationSuccessful()
//        {
//            try
//            {
//                // Wait for a page element that indicates successful login (Basic Auth header or something unique)
//                IWebElement successMessage = wait.Until(d =>
//                {
//                    try
//                    {
//                        return d.FindElement(By.XPath("//h3[text()='Basic Auth']"));
//                    }
//                    catch (NoSuchElementException)
//                    {
//                        return null;
//                    }
//                });

//                return successMessage != null && successMessage.Displayed;
//            }
//            catch (WebDriverTimeoutException)
//            {
//                return false;
//            }
//        }

//        // Check if we are still on the login page
//        public bool IsOnLoginPage()
//        {
//            return driver.Url.Contains("basic_auth");
//        }

//        // Simulate logout by navigating to the logout page
//        public void LogOut()
//        {
//            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/logout");
//        }

//        // Clear cookies and session (helps with logout-related issues)
//        public void ClearCookies()
//        {
//            driver.Manage().Cookies.DeleteAllCookies();
//        }

//        // Close the browser
//        public void Close()
//        {
//            driver.Quit();
//        }
//    }
//}
