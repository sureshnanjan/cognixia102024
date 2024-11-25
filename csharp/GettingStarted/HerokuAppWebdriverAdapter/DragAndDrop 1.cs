using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppWebdriverAdapter
{
    public class DragAndDrop : HerokuAppCommon, IDragAndDrop
    {
        private By squareA;
        private By squareB;

        public DragAndDrop(IWebDriver driver) : base(driver)
        {
            this.squareA = By.Id("column-a"); // Locator for square A
            this.squareB = By.Id("column-b"); // Locator for square B
        }

        public string GetSquareAText()
        {
            return this.driver.FindElement(squareA).Text;
        }

        public string GetSquareBText()
        {
            return this.driver.FindElement(squareB).Text;
        }

        public void DragAToB()
        {
            var elementA = this.driver.FindElement(squareA);
            var elementB = this.driver.FindElement(squareB);

            Actions actions = new Actions(this.driver);
            actions.DragAndDrop(elementA, elementB).Perform();
        }

        public void DragBToA()
        {
            var elementB = this.driver.FindElement(squareB);
            var elementA = this.driver.FindElement(squareA);

            Actions actions = new Actions(this.driver);
            actions.DragAndDrop(elementB, elementA).Perform();
        }

        public bool IsSwapSuccessful()
        {
            string textA = GetSquareAText();
            string textB = GetSquareBText();

            // Assuming that swapping changes the content or labels of A and B
            return textA == "B" && textB == "A";
        }
    }

}
