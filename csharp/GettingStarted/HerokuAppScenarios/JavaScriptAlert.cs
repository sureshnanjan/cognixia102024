using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HerokuAppScenarios
{
     public class JavaScriptAlertTest
    {
        JavaScriptAlert jsAlert;
        [SetUp]
        public void Setup()
        {
            jsAlert = new JavaScriptAlert();
        }

        [Test]
        public void TriggerJsAlert()
        {
            bool val=jsAlert.ClickforJsAlert();

            // Verify that the alert is displayed
            Assert.IsTrue(val);
           
        }

        [Test]
        public void AcceptJsAlert()
        {
            bool val1=jsAlert.ClickforJsAlert();
            bool val2=jsAlert.ClickforJsAlertClose();

            // Verify alert is closed (no exception when accessing the page after alert)
            Assert.IsTrue(val1 && val2, "JavaScript alert was not closed.");
        }

        [Test]
        public void TriggerJsConfirm()
        {
            bool val=jsAlert.ClickforJsConfirm();

            // Verify that the confirmation dialog is displayed
            Assert.IsTrue(val, "JavaScript confirmation dialog was not displayed.");
        }

        [Test]
        public void DismissJsConfirm()
        {
            bool val1=jsAlert.ClickforJsConfirm();
            bool val2=jsAlert.ClickforJsConfirmClose();

            // Verify dialog is closed
            Assert.IsTrue(val1||val2, "JavaScript confirmation dialog was not dismissed.");
        }

        [Test]
        public void TriggerJsPrompt()
        {
            bool val=jsAlert.ClickforJsPrompt();

            // Verify that the prompt dialog is displayed
            Assert.IsTrue(val, "JavaScript prompt dialog was not displayed.");
        }

        [Test]
        public void SendInputToJsPrompt()
        {
            bool val1=jsAlert.ClickforJsPrompt();
            string inputMessage = "Test Message";
            bool val2=jsAlert.ClickforJsPromptClose(inputMessage);
            Assert.IsTrue(val1 && val2);

        }

        [Test]
        public void DismissJsPromptWithoutInput()
        {
            bool val1 =jsAlert.ClickforJsPrompt();
            bool val2=jsAlert.ClickforJsConfirmClose(); // Dismiss the prompt

            // Verify prompt is closed
            Assert.IsTrue(val1&&val2, "JavaScript prompt was not dismissed.");
        }

        [Test]
        public void HandleNoAlertPresent()
        {
            // Attempt to close an alert when none is present
            Assert.DoesNotThrow(() => jsAlert.ClickforJsAlertClose(), "Exception was thrown when no alert was present.");
        }

        

    }
}
