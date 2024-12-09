using HerokuAppOperations;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class ShiftingContentOperationsTests
    {
        private ShiftingContentOperations _operations;

        [SetUp]
        public void SetUp()
        {
            // Initialize the ShiftingContentOperations class before each test
            _operations = new ShiftingContentOperations();
        }

        [Test]
        public void TestNavigateToShiftingContentPage()
        {
            // Arrange

            // Act
            _operations.NavigateToShiftingContentPage();
            var currentUrl = _operations.GetCurrentUrl();

            // Assert
            Assert.AreEqual("https://the-internet.herokuapp.com/shifting_content/menu", currentUrl,"The browser did not navigate to the expected URL.");
        }

        [Test]
        public void TestVerifyMenuItems()
        {
            // Arrange

            // Act & Assert
            Assert.DoesNotThrow(() => _operations.VerifyMenuItems(),
                "Menu items verification threw an exception. Check for shifting behavior.");
        }

        [Test]
        public void TestNavigateToMenuItem()
        {
            // Arrange
            string menuItemText = "Example 1"; // Replace with an actual menu item text on the page

            // Act & Assert
            Assert.DoesNotThrow(() => _operations.NavigateToMenuItem(menuItemText),
                $"Navigating to the menu item '{menuItemText}' threw an exception.");
        }

        [Test]
        public void TestCheckShiftingBehavior()
        {
            // Arrange

            // Act & Assert
            Assert.DoesNotThrow(() => _operations.CheckShiftingBehavior(),
                "Shifting behavior detection threw an exception.");
        }

        [Test]
        public void TestGetCurrentUrl()
        {
            // Arrange
            _operations.NavigateToShiftingContentPage();

            // Act
            var currentUrl = _operations.GetCurrentUrl();

            // Assert
            Assert.IsNotNull(currentUrl, "Current URL should not be null.");
            Assert.IsNotEmpty(currentUrl, "Current URL should not be empty.");
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up resources after each test
            _operations.CleanUp();
        }
    }
}