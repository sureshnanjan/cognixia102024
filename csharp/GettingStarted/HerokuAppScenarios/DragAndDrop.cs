using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppScenarios
{
    internal class DragAndDrop
    {
        [Test]
        public void DragAndDropSwapsSquares()
        {
            // Initialize the ChromeDriver instance
            ChromeDriver instance = new ChromeDriver();
            IWebDriver iinst = instance;

            // Create the page object for HomePage and navigate to DragAndDrop page
            IHomePage page = new HomePage();
            var dragAndDropPage = page.NavigateToDragAndDrop();

            // Get the initial text of square A and square B
            string initialTextA = dragAndDropPage.GetSquareAText();
            string initialTextB = dragAndDropPage.GetSquareBText();

            // Perform the drag-and-drop action
            dragAndDropPage.DragAToB();

            // Get the updated text of square A and square B after the action
            string updatedTextA = dragAndDropPage.GetSquareAText();
            string updatedTextB = dragAndDropPage.GetSquareBText();

            // Verify that the contents of square A and B have been swapped
            Assert.AreNotEqual(initialTextA, updatedTextA, "Square A's content did not change after drag-and-drop.");
            Assert.AreNotEqual(initialTextB, updatedTextB, "Square B's content did not change after drag-and-drop.");
            Assert.AreEqual(initialTextA, updatedTextB, "Square A's content did not correctly swap to Square B.");
            Assert.AreEqual(initialTextB, updatedTextA, "Square B's content did not correctly swap to Square A.");
        }
    }
}
