using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class NestedFrames
    {
        private INestedFrames nestedFrames;

        [Test]
        public void TestLeftFrameContent()
        {
            // Retrieve and verify the content of the LEFT frame
            string leftContent = nestedFrames.GetLeftFrameContent();
            Assert.AreEqual("LEFT", leftContent, "The content of the LEFT frame is not as expected.");
        }

        [Test]
        public void TestMiddleFrameContent()
        {
            // Retrieve and verify the content of the MIDDLE frame
            string middleContent = nestedFrames.GetMiddleFrameContent();
            Assert.AreEqual("MIDDLE", middleContent, "The content of the MIDDLE frame is not as expected.");
        }

        [Test]
        public void TestRightFrameContent()
        {
            // Retrieve and verify the content of the RIGHT frame
            string rightContent = nestedFrames.GetRightFrameContent();
            Assert.AreEqual("RIGHT", rightContent, "The content of the RIGHT frame is not as expected.");
        }

        [Test]
        public void TestBottomFrameContent()
        {
            // Retrieve and verify the content of the BOTTOM frame
            string bottomContent = nestedFrames.GetBottomFrameContent();
            Assert.AreEqual("BOTTOM", bottomContent, "The content of the BOTTOM frame is not as expected.");
        }

        [Test]
        public void TestIsFrameAvailable()
        {
            // Check if frames are available
            Assert.IsTrue(nestedFrames.IsFrameAvailable("frame-top"), "The frame 'frame-top' is not available.");
            Assert.IsTrue(nestedFrames.IsFrameAvailable("frame-bottom"), "The frame 'frame-bottom' is not available.");
        }

        [Test]
        public void TestSwitchToMainContent()
        {
            // Switch to a frame and then back to the main content
            nestedFrames.SwitchToFrame("frame-top");
            nestedFrames.SwitchToMainContent();

            // Verify switching back to the main content by checking for the presence of the frames
            Assert.IsTrue(nestedFrames.IsFrameAvailable("frame-top"), "Failed to switch back to the main content.");
        }
    }
}
