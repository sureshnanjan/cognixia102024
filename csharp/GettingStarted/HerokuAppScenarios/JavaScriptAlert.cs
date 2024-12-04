using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using HerokuAppScenarios;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
namespace HerokuAppScenarios
{
     public class JavaScriptAlertTest
    {
        private IJavaScriptAlerts jsAlert;

        [SetUp]
        public void Setup()
        {
            // Arrange: Initialize JavaScriptAlert object
            jsAlert = new JavaScriptAlert();
        }

        [Test]
        public void TriggerJsAlert()
        {
            // Arrange: No special setup needed.

            // Act: Trigger the JavaScript alert
            bool alertDisplayed = jsAlert.ClickforJsAlert();

            // Assert: Verify the alert is displayed
            Assert.IsTrue(alertDisplayed, "The JavaScript alert was not displayed.");
        }

        [Test]
        public void AcceptJsAlert()
        {
            // Arrange: Prepare for handling the alert
            bool alertTriggered = jsAlert.ClickforJsAlert();

            // Act: Accept the JavaScript alert
            bool alertClosed = jsAlert.ClickforJsAlertClose();

            // Assert: Verify the alert was closed
            Assert.IsTrue(alertTriggered && alertClosed, "The JavaScript alert was not handled correctly.");
        }

        [Test]
        public void TriggerJsConfirm()
        {
            // Arrange: No special setup needed.

            // Act: Trigger the JavaScript confirmation dialog
            bool confirmDisplayed = jsAlert.ClickforJsConfirm();

            // Assert: Verify the confirmation dialog is displayed
            Assert.IsTrue(confirmDisplayed, "The JavaScript confirmation dialog was not displayed.");
        }

        [Test]
        public void DismissJsConfirm()
        {
            // Arrange: Trigger the confirmation dialog
            bool confirmTriggered = jsAlert.ClickforJsConfirm();

            // Act: Dismiss the confirmation dialog
            bool confirmDismissed = jsAlert.ClickforJsConfirmClose();

            // Assert: Verify the confirmation dialog was dismissed
            Assert.IsTrue(confirmTriggered && confirmDismissed, "The JavaScript confirmation dialog was not dismissed correctly.");
        }

        [Test]
        public void TriggerJsPrompt()
        {
            // Arrange: No special setup needed.

            // Act: Trigger the JavaScript prompt dialog
            bool promptDisplayed = jsAlert.ClickforJsPrompt();

            // Assert: Verify the prompt dialog is displayed
            Assert.IsTrue(promptDisplayed, "The JavaScript prompt dialog was not displayed.");
        }

        [Test]
        public void SendInputToJsPrompt()
        {
            // Arrange: Set up input for the prompt
            string inputMessage = "Test Message";

            // Act: Trigger the prompt and send input
            bool promptDisplayed = jsAlert.ClickforJsPrompt();
            bool promptClosed = jsAlert.ClickforJsPromptClose(inputMessage);

            // Assert: Verify the prompt was displayed and input was handled
            Assert.IsTrue(promptDisplayed && promptClosed, "The JavaScript prompt was not handled correctly.");
        }

        [Test]
        public void DismissJsPromptWithoutInput()
        {
            // Arrange: Trigger the prompt dialog
            bool promptTriggered = jsAlert.ClickforJsPrompt();

            // Act: Dismiss the prompt dialog without input
            bool promptDismissed = jsAlert.ClickforJsConfirmClose();

            // Assert: Verify the prompt was dismissed
            Assert.IsTrue(promptTriggered && promptDismissed, "The JavaScript prompt was not dismissed correctly.");
        }

    }
}

