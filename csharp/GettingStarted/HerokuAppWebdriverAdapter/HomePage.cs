using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace HerokuAppWebdriverAdapter
{
    public class HomePage : IHomePage
    {
        private readonly IWebDriver driver;
        public HomePage() {
            _title = By.TagName("h1");
            _description = By.TagName("h2");
            exampleLink = By.TagName("a");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }
        private By _title;
        private By _description;
        private By exampleLink;
        public string[] getAvailableExamples()
        {
            string[] results = { };
            var alllinks = driver.FindElements(exampleLink).SelectMany(element => element.Text);
            foreach (var item in alllinks)
            {
                //results.Append(item);
                
            }

            return results;
        }

        public string getDescription()
        {
            return driver.FindElement(_description).Text;
        }

        public string getTitle()
        {
            return driver.FindElement(_title).Text;
        }

        public void navigateToExample(string exname)
        {
            throw new NotImplementedException();
        }
    }
}
