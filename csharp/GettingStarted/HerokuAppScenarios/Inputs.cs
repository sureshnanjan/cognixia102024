using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class Inputs
    {
        private IInputs inputsPage;

        [Test]
        public void VerifyPageIsLoadedSuccessfully()
        {
            HomePage homePage = new HomePage();
            // Act
            bool isPageLoaded = inputsPage.IsPageLoaded();

            // Assert
            Assert.IsTrue(isPageLoaded, "The Inputs page did not load successfully.");
        }

        [Test]
        public void ValidatePageTitle()
        {
            HomePage homePage = new HomePage();
            // Arrange
            string expectedTitle = "Inputs"; 

            // Act
            string actualTitle = inputsPage.GetPageTitle();

            // Assert
            Assert.AreEqual(expectedTitle, actualTitle, "The page title is incorrect.");
        }

        [Test]
        public void CanEnterValueIntoInputField()
        {
            // Arrange
            string inputValue = "11";

            // Act
            inputsPage.EnterValue(inputValue);
            string actualValue = inputsPage.GetInputValue();

            // Assert
            Assert.AreEqual(inputValue, actualValue, "The entered value is not reflected in the input field.");
        }

        [Test]
        public void CanClearInputField()
        {
            // Arrange
            string inputValue = "12345";
            inputsPage.EnterValue(inputValue);

            // Act
            inputsPage.ClearInputField();
            string actualValue = inputsPage.GetInputValue();

            // Assert
            Assert.IsEmpty(actualValue, "The input field was not cleared successfully.");
        }

        [Test]
        public void ValidateNumericInputReturnsTrueForValidNumbers()
        {
            // Arrange
            string numericInput = "67890";

            // Act
            bool isValid = inputsPage.ValidateNumericInput(numericInput);

            // Assert
            Assert.IsTrue(isValid, "Numeric input validation failed for a valid number.");
        }

        [Test]
        public void ValidateNumericInputReturnsFalseForInvalidInput()
        {
            // Arrange
            string invalidInput = "abc234";

            // Act
            bool isValid = inputsPage.ValidateNumericInput(invalidInput);

            // Assert
            Assert.IsFalse(isValid, "Numeric input validation incorrectly returned true for invalid input.");
        }

        [Test]
        public void IncrementValueIncreasesTheInputValue()
        {
            // Arrange
            string initialValue = "5";
            inputsPage.EnterValue(initialValue);

            // Act
            string incrementedValue = inputsPage.IncrementValue();

            // Assert
            Assert.AreEqual("6", incrementedValue, "The value did not increment as expected.");
        }

        [Test]
        public void DecrementValueDecreasesTheInputValue()
        {
            // Arrange
            string initialValue = "5";
            inputsPage.EnterValue(initialValue);

            // Act
            string decrementedValue = inputsPage.DecrementValue();

            // Assert
            Assert.AreEqual("4", decrementedValue, "The value did not decrement as expected.");
        }

        [Test]
        public void IncrementAndDecrementTest()
        {
            // Arrange
            string initialValue = "0";
            inputsPage.EnterValue(initialValue);

            // Act
            string incrementedValue = inputsPage.IncrementValue();
            string decrementedValue = inputsPage.DecrementValue();

            // Assert
            Assert.AreEqual("1", incrementedValue, "Increment failed.");
            Assert.AreEqual("0", decrementedValue, "Decrement failed.");
        }
    }
}
