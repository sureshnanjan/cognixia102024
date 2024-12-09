using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NestedFramesTests
{
    // Test class for NestedFramesHandler
    [TestFixture]
    public class NestedFramesHandlerTests
    {
        private IWebDriver _driver;
        private INestedFramesHandler _frameHandler;

        // Setup method to initialize resources before each test
        [SetUp]
        public void Setup()
        {
            // Initialize Chrome WebDriver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/nested_frames");

            // Initialize the frame handler
            _frameHandler = new NestedFramesHandler(_driver);
        }

        // Test case for verifying text in the Left Frame
        [Test]
        public void Test_LeftFrame_Text()
        {
            // Switch to the left frame and get its text
            _frameHandler.SwitchToLeftFrame();
            string leftFrameText = _frameHandler.GetTextFromCurrentFrame();

            // Assert that the text in the left frame is as expected
            Assert.AreEqual("LEFT", leftFrameText, "Text in the Left Frame is incorrect.");

            // Switch back to the default content
            _frameHandler.SwitchToDefaultContent();
        }

        // Test case for verifying text in the Middle Frame
        [Test]
        public void Test_MiddleFrame_Text()
        {
            // Switch to the middle frame and get its text
            _frameHandler.SwitchToMiddleFrame();
            string middleFrameText = _frameHandler.GetTextFromCurrentFrame();

            // Assert that the text in the middle frame is as expected
            Assert.AreEqual("MIDDLE", middleFrameText, "Text in the Middle Frame is incorrect.");

            // Switch back to the default content
            _frameHandler.SwitchToDefaultContent();
        }

        // Test case for verifying text in the Right Frame
        [Test]
        public void Test_RightFrame_Text()
        {
            // Switch to the right frame and get its text
            _frameHandler.SwitchToRightFrame();
            string rightFrameText = _frameHandler.GetTextFromCurrentFrame();

            // Assert that the text in the right frame is as expected
            Assert.AreEqual("RIGHT", rightFrameText, "Text in the Right Frame is incorrect.");

            // Switch back to the default content
            _frameHandler.SwitchToDefaultContent();
        }

        // Test case for verifying text in the Bottom Frame
        [Test]
        public void Test_BottomFrame_Text()
        {
            // Switch to the bottom frame and get its text
            _frameHandler.SwitchToBottomFrame();
            string bottomFrameText = _frameHandler.GetTextFromCurrentFrame();

            // Assert that the text in the bottom frame is as expected
            Assert.AreEqual("BOTTOM", bottomFrameText, "Text in the Bottom Frame is incorrect.");
        }

        // Teardown method to clean up resources after each test
        [TearDown]
        public void Teardown()
        {
            // Close the browser session
            _driver.Quit();
        }
    }
}

