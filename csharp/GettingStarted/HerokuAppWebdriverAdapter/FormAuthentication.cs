using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class FormAuthentication : HerokuAppCommon ,IFormAuthentication
    {
        public FormAuthentication()
        {
            
        }
        public void GetNavigated()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com");

        }
        public void GetCredentials()
        {
            IWebElement usernameField = driver.FindElement(By.Id("username"));
            usernameField.SendKeys("yourUsername");

            IWebElement passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys("yourPassword");
        }
        public void GetIntoLogin()
        {
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys(Keys.Enter);

        }
        public void VerifyingLoginSuccessful()
        {
            // Check for an element that is only visible after login (e.g., the user profile button)
            try
            {
                IWebElement userProfileButton = driver.FindElement(By.LinkText("Login Success"));
               
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Login failed.");
            }
            try
            {
                // Check if the error message is displayed (example: "Invalid username or password")
                IWebElement errorMessage = driver.FindElement(By.Id("errorMessage")); // Change this ID based on your app's error message element
                Console.WriteLine("Error Message: " + errorMessage.Text);

                // Validate if the error message is correct
                if (errorMessage.Text.Contains("Invalid username"))
                {
                    Console.WriteLine("Test passed: Correct error message displayed for invalid username.");
                }
                else
                {
                    Console.WriteLine("Test failed: Unexpected error message.");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Error message not found. Login might have succeeded, or the element is different.");
            }

        }
        public void VerifyLogin()
        {
            // Example of post-login check: Verify if logout button is visible
            IWebElement logoutButton = driver.FindElement(By.Id("logoutButton"));
            

        }
    }
}
