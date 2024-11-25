using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace HerokuAppWebdriverAdapter
{
    public class HomePage :HerokuAppCommon, IHomePage
    {
        public HomePage() : base()
        {
            _title = By.TagName("h1");
            _description = By.TagName("h2");
            checkboxlink = By.LinkText("Checkboxes");
            exampleLink = By.TagName("a");
        }
        public HomePage(IWebDriver arg) : base(arg) {
            _title = By.TagName("h1");
            _description = By.TagName("h2");
            checkboxlink = By.LinkText("Checkboxes");
            // Wrapper Class
           // _description = ascendion_findelement();
            exampleLink = By.TagName("a");
            //checkboxlink = By.LinkText("Checkboxes");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }
        private By _title;
        private By _description;
        private By exampleLink;
        private By checkboxlink;
        public string[] getAvailableExamples()
        {
            this.driver.Manage().Cookies.AddCookie(new Cookie("OptimizelyOptOut","true"));
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

        public object navigateToExample(string exname)
        {
            throw new NotImplementedException();
        }

        public ICheckBox navigateToCheckBox()
        {
            this.driver.FindElement(checkboxlink).Click();
            return new CheckBox(this.driver);
        }

        public IABTesting navigateToABTest()
        {
            throw new NotImplementedException();
        }

        object IHomePage.navigateToExample(string exname)
        {
            // Compare the example name and 
            return "";
            
        }

    }
}
