using HerokuAppOperations;
using OpenQA.Selenium;
using System;

namespace HerokuAppWebdriverAdapter
{
    public class Frames : HerokuAppCommon, IFrames
    {
        public Frames(IWebDriver driver) : base(driver) { }

        

        // Navigate to the page that contains the nested frames
        public void OnClickingNestedframes()
        {
            // Assuming you're already on the "Nested Frames" page
            // You may need to first navigate to the page if you're not on it yet
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/nested_frames");
        }

        // Switch to the top frame and check its contents
        public void CheckTopframe()
        {
            // Switch to the top frame
            driver.SwitchTo().Frame("frame-top");
            // Perform actions in the top frame (e.g., check some content)
            Console.WriteLine("Inside Top Frame: " + driver.PageSource);  // Example action

            // Return to the default content (main page)
            driver.SwitchTo().DefaultContent();
        }

        // Switch to the bottom frame and check its contents
        public void CheckBottomframe()
        {
            // Switch to the bottom frame
            driver.SwitchTo().Frame("frame-bottom");
            // Perform actions in the bottom frame
            Console.WriteLine("Inside Bottom Frame: " + driver.PageSource);  // Example action

            // Return to the default content (main page)
            driver.SwitchTo().DefaultContent();
        }

        // Switch to the left frame and check its contents
        public void CheckLeftframe()
        {
            // Switch to the left frame (this might be a nested frame inside the top frame)
            driver.SwitchTo().Frame("frame-left");
            // Perform actions in the left frame
            Console.WriteLine("Inside Left Frame: " + driver.PageSource);  // Example action

            // Return to the default content (main page)
            driver.SwitchTo().DefaultContent();
        }

        // Switch to the right frame and check its contents
        public void CheckRightframe()
        {
            // Switch to the right frame (this might be a nested frame inside the top frame)
            driver.SwitchTo().Frame("frame-right");
            // Perform actions in the right frame
            Console.WriteLine("Inside Right Frame: " + driver.PageSource);  // Example action

            // Return to the default content (main page)
            driver.SwitchTo().DefaultContent();
        }

        // Switch to the middle frame and check its contents
        public void CheckMiddleframe()
        {
            // Switch to the middle frame (this is often a nested frame)
            driver.SwitchTo().Frame("frame-middle");
            // Perform actions in the middle frame
            Console.WriteLine("Inside Middle Frame: " + driver.PageSource);  // Example action

            // Return to the default content (main page)
            driver.SwitchTo().DefaultContent();
        }

        // Click on a nested iframe inside a frame (example action)
        public void OnClickingiFrame()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframes");
        }
    }
}
