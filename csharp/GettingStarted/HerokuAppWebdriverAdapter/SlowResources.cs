using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.DevTools.V107.Network;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading.Tasks;

public class SlowResources : HerokuAppCommon, ISlowResources
{
    private readonly By header = By.TagName("h3");
    private readonly By content = By.TagName("p");
    private IWebDriver driver;
    private IDevTools devTools;
    private string capturedUrl;

    public SlowResources()
    {
        // Initialize WebDriver with ChromeOptions for DevTools access
        ChromeOptions options = new ChromeOptions();
        driver = new ChromeDriver(options);

        // Initialize DevTools session
        devTools = ((ChromeDriver)driver).GetDevTools();
    }

    public void NavigateToPage()
    {
        driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/slow");
    }

    public string GetPageTitle()
    {
        return driver.Title;
    }

    public string GetHeaderText()
    {
        return driver.FindElement(header).Text;
    }

    public string GetContentAfterLoading(int timeoutInSeconds)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
        wait.Until(d => d.FindElement(content).Displayed);
        return driver.FindElement(content).Text;
    }

    public async Task<dynamic> GetNetworkResponseAsync(string url)
    {
        // Initialize response variable to hold the network data
        dynamic response = null;

        // Enable network tracking through DevTools
        await devTools.SendCommandAsync(Network.Enable(new Network.EnableCommandSettings
        {
            MaxPostDataSize = 0 // Optional: Set a limit for POST data size if needed
        }));

        // Attach an event listener for network responses
        devTools.Network.ResponseReceived += (sender, e) =>
        {
            if (e.Response.Url.Contains(url))
            {
                response = new
                {
                    Method = e.Request.Method,
                    Url = e.Response.Url,
                    StatusCode = e.Response.Status,
                    StatusText = e.Response.StatusText
                };
            }
        };

        // Wait for the network response
        await Task.Delay(5000); // Adjust the wait time depending on when the network response is expected

        return response;
    }

    public void CloseBrowser()
    {
        driver.Quit();
    }

    public dynamic GetNetworkResponse(string url)
    {
        throw new NotImplementedException();
    }

    public string GetCurrentUrl()
    {
        throw new NotImplementedException();
    }

    public string GetContentWithoutSlowResources()
    {
        throw new NotImplementedException();
    }

    public object GetNetworkResponseWithTimeout(string v, int timeout)
    {
        throw new NotImplementedException();
    }

    public string GetContentAfterLoading()
    {
        throw new NotImplementedException();
    }
}
