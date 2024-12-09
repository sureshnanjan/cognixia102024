using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Class that implements the INestedFramesHandler interface.
public class NestedFramesHandler : INestedFramesHandler
{
    private readonly IWebDriver _driver;

    // Constructor initializes the WebDriver.
    public NestedFramesHandler(IWebDriver driver)
    {
        _driver = driver;
    }

    // Switch to the top frame.
    public void SwitchToTopFrame()
    {
        _driver.SwitchTo().Frame("frame-top");
    }

    // Switch to the left frame within the top frame.
    public void SwitchToLeftFrame()
    {
        _driver.SwitchTo().Frame("frame-top");   // First, switch to the top frame.
        _driver.SwitchTo().Frame("frame-left");  // Then switch to the left frame inside the top frame.
    }

    // Switch to the middle frame within the top frame.
    public void SwitchToMiddleFrame()
    {
        _driver.SwitchTo().Frame("frame-top");   // First, switch to the top frame.
        _driver.SwitchTo().Frame("frame-middle"); // Then switch to the middle frame inside the top frame.
    }

    // Switch to the right frame within the top frame.
    public void SwitchToRightFrame()
    {
        _driver.SwitchTo().Frame("frame-top");   // First, switch to the top frame.
        _driver.SwitchTo().Frame("frame-right");  // Then switch to the right frame inside the top frame.
    }

    // Switch to the bottom frame (no parent frame).
    public void SwitchToBottomFrame()
    {
        _driver.SwitchTo().Frame("frame-bottom");
    }

    // Get the text content from the current frame.
    public string GetTextFromCurrentFrame()
    {
        return _driver.FindElement(By.TagName("body")).Text; // Extract text from the body tag of the current frame.
    }

    // Switch back to the main page's content (default content).
    public void SwitchToDefaultContent()
    {
        _driver.SwitchTo().DefaultContent();
    }
}
