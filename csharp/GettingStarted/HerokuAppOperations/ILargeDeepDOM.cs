using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface ILargeDeepDOM
    {
        // Method to open the Large Deep DOM page
        void OpenLargeDeepDOMPage();

        // Method to check the presence of a specific element in the DOM
        bool IsElementPresent(string elementSelector);

        // Method to get a list of all items in a deep DOM structure
        List<string> GetAllItemsInDeepDOM();

        // Method to interact with a specific item in a large DOM
        void ClickItemInDOM(string itemSelector);

        // Method to verify the page title for Large Deep DOM
        string GetPageTitle();

        // Method to perform scrolling in the DOM
        void ScrollThroughDOM(int scrollAmount);

        // Method to wait for the DOM to be loaded completely
        void WaitForDOMToLoad();
    }
}