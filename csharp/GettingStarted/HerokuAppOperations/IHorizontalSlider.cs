using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IHorizontalSlider
    {
        // Drag the slider by a specific offset
           public void dragSlider(IWebElement slider, int xOffset);

        // Set the value of the slider directly (using SendKeys)
       public void setSliderValue(IWebElement slider, string value);

        // Get the current value of the slider
       public string getSliderValue(IWebElement slider);

        // Validate the min and max value of the slider
        public void validateSliderRange(IWebElement slider, string expectedMinValue, string expectedMaxValue);

        // Perform mouse hover on the slider
        public void hoverOverSlider(IWebElement slider);
    }
}
