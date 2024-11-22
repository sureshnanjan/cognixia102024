using OpenQA.Selenium;
using NUnit.Framework;
using HerokuAppOperations;
using OpenQA.Selenium.Chrome;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class HorizontalSlider
    {
        private IWebDriver driver;
        private IHorizontalSlider sliderActions;

        [SetUp]
        public void SetUp()
        {
            // Initialize the WebDriver (Chrome in this case)
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // Optional: Maximize the window for better visibility
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/horizontal_slider"); // Navigate to the slider page

            // Initialize HorizontalSliderActions class
            sliderActions = new HorizontalSlider(driver);
        }

        [Test]
        public void DragSliderAndValidateValue()
        {
            // Locate the slider element using the XPath you provided
            IWebElement slider = driver.FindElement(By.XPath("//*[@id='content']/div/div/input"));

            // Drag the slider by a specific offset (let's move it by 30 pixels)
            sliderActions.dragSlider(slider, 30);

            // Get the current value of the slider and validate if it has changed
            string currentValue = sliderActions.getSliderValue(slider);
            Assert.AreEqual("0.3", currentValue, "Slider value is incorrect after dragging.");
        }

        [Test]
        public void SetSliderValueAndValidate()
        {
            // Locate the slider element using the XPath you provided
            IWebElement slider = driver.FindElement(By.XPath("//*[@id='content']/div/div/input"));

            // Set the slider value directly (e.g., set it to 2)
            sliderActions.setSliderValue(slider, "2");

            // Get the current value of the slider and validate it
            string currentValue = sliderActions.getSliderValue(slider);
            Assert.AreEqual("2", currentValue, "Slider value was not set correctly.");
        }

        [Test]
        public void ValidateSliderRange()
        {
            // Locate the slider element using the XPath you provided
            IWebElement slider = driver.FindElement(By.XPath("//*[@id='content']/div/div/input"));

            // Validate the min and max range of the slider
            sliderActions.validateSliderRange(slider, "0", "5");  // Expected min = 0, max = 5
        }

       
    }
}
