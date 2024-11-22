using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class BrokenImage : IBrokenImage
    {
        private readonly IWebDriver _driver;
        public BrokenImage()
        {
            _driver = new ChromeDriver();
        }

        public int ValidateImages(string url)
        {
            _driver.Navigate().GoToUrl(url);

            // Get all image elements on the page
            IReadOnlyCollection<IWebElement> images = _driver.FindElements(By.TagName("img"));
            int brokenImageCount = 0;

            foreach (var image in images)
            {
                string imageUrl = image.GetAttribute("src");
                if (!string.IsNullOrEmpty(imageUrl) && !IsImageValid(imageUrl))
                {
                    brokenImageCount++;
                }
            }

            return brokenImageCount;
        }
        private bool IsImageValid(string imageUrl)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(imageUrl);
            request.Method = "HEAD";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                return (response.StatusCode == HttpStatusCode.OK);
            }
        }
    }
}