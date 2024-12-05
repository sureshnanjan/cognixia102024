using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class AddRemoveTests
    {
        private IAddRemove _addRemovePage;

        [SetUp]
        public void SetUp()
        {
            // Initialize the AddRemovePage which internally initializes WebDriver
            _addRemovePage = new AddRemovePage();
        }

        //[TearDown]
        //public void TearDown()
        //{
        //    // After each test, close the WebDriver (automatically handled by the common class)
        //    IWebDriver driver = ((HerokuAppCommon)_addRemovePage).GetDriver();
        //    driver.Quit();
        //}

        [Test]
        public void TitleWorksOK()
        {
            string expectedTitle = "Add/Remove Elements";
            string actualTitle = _addRemovePage.getTitle();
            Console.WriteLine(actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle, "Page title does not match expected value.");
        }

        [Test]
        public void AddingElementWorks()
        {
            int initialCount = _addRemovePage.GetCountofElements();
            _addRemovePage.AddElement();
            Assert.AreEqual(initialCount + 1, _addRemovePage.GetCountofElements(), "Element count should increase by 1 after clicking 'Add Element'.");
        }

        [Test]
        public void DeletingElementWorks()
        {
            _addRemovePage.AddElement(); // Ensure there's at least one element to delete
            int initialCount = _addRemovePage.GetCountofElements();
            _addRemovePage.DeleteElement();
            Assert.AreEqual(initialCount - 1, _addRemovePage.GetCountofElements(), "Element count should decrease by 1 after clicking 'Delete'.");
        }

        [Test]
        public void DeleteButtonIsVisible()
        {
            _addRemovePage.AddElement();
            IWebDriver driver = ((HerokuAppCommon)_addRemovePage).GetDriver();
            bool isDeleteButtonVisible = driver.FindElement(By.XPath("//button[text()='Delete']")).Displayed;
            Assert.IsTrue(isDeleteButtonVisible, "Delete button should be visible after adding an element.");
        }

        [Test]
        public void IsDeleteWorkingWithoutAdding()
        {
            IWebDriver driver = ((HerokuAppCommon)_addRemovePage).GetDriver();
            var deleteButtons = driver.FindElements(By.XPath("//button[text()='Delete']"));
            Assert.AreEqual(0, deleteButtons.Count, "There should be no 'Delete' button initially.");
        }
    }
}
