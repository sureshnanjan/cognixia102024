using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium;

namespace HerokuAppScenarios
{
    public class ChallengingDOMTEST
    {
        ChallengingDOM dom;
        [SetUp]
        public void Setup()
        {
            dom = new ChallengingDOM();
        }
        [Test]
        public void VerifyPageTitle()
        {
            // Act
            string title = dom.GetPageTitle();
            String Expected = "The Internet";
            // Assert
            Assert.AreEqual(Expected, title, "The page title does not match the expected value.");
        }
        [Test]
        public void VerifyTableRowCount()
        {
            // Act
            int rowCount =dom.GetTableRowCount();
            // Assert
            Assert.IsTrue(rowCount > 0, "The table should have rows.");
        }
        [Test]
        public void VerifyEditButtonFunctionality()
        {
            //Arrange
            int romNum = 2;
            // Act
            dom.ClickEditButton(romNum);
            // Assert
            // Validate behavior after clicking edit, e.g., a URL change or page update
            Assert.Pass("Edit button clicked successfully for row 2.");
        }
        [Test]
        public void VerifyDeleteButtonFunctionality()
        {
            //Arrange
            int romNum = 3;
            //Act
            dom.ClickDeleteButton(romNum);
            //Assert
            // Validate behavior after clicking delete, e.g., a URL change or page update
            Assert.Pass("Delete button clicked successfully for row 2.");
        }
        [Test]
        public void VerifyInvalidRowIndexForEditButton()
        {
            // Arrange
            int invalidRowIndex = 100; // Assuming table doesn't have 100 rows

            // Act & Assert using Assert.Throws
            var exception = Assert.Throws<NoSuchElementException>(() =>
            {
                dom.ClickEditButton(invalidRowIndex);
            });

            // Verify exception message contains relevant details
            Console.WriteLine(exception.Message);
        }
        [Test]

        public void VerifyTableLocatorFailure()
        {
            // Arrange
            // Modify the XPath in the ChallengingDOM class temporarily to simulate failure
            // Act & Assert
            // for example "//table[@id='nonexistent']"
            var ex = Assert.Throws<NoSuchElementException>(() =>
            {
               dom.GetTableRowCount();
            });
            Assert.IsTrue(ex.Message.Contains("no such element"), "Exception should be thrown for missing table.");
        }

        [Test]
        public void VerifyButtonLocatorFailure()
        {
            // Arrange
            // Modify the XPath for the edit button in the ChallengingDOM class to simulate failure
            // Act & Assert
            // for example giving wrong xpath "//table[@id='nonexistent']/tbody/tr[1]/td[last()]/button[text()='edit']"
            var ex = Assert.Throws<NoSuchElementException>(() =>
            {
                dom.ClickEditButton(1);
            });
            Assert.IsTrue(ex.Message.Contains("no such element"), "Exception should be thrown for missing button.");
        }


    }
}
