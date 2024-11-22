using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using OpenQA.Selenium;

namespace HerokuAppOperations
{
    public interface IHoverAction
    {
        // Hover over a specified element (like an image)
        void hoverOverElement(IWebElement element);

        // Validate that the content appears after hovering
        bool validateContentAppears(IWebElement element);

        // Click the link that appears after hovering
        void clickOnRevealedLink(IWebElement link);
    }
}
