using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class CheckBox
    {
        [Test]
        public void DefaultSettingsWorks() {
            ChromeDriver instance = new ChromeDriver();
            //instance.
            IWebDriver iinst = instance;
            ITakesScreenshot camera = (ITakesScreenshot)iinst;
            ((IJavaScriptExecutor)camera)
            IHomePage page = new HomePage();
            var checkPage = page.navigateToCheckBox();
            bool expectedstatusone = false;
            bool expectedstatustwo = true;
            bool actualone = checkPage.getCHekboxOneSatatus();
            bool actualtwo = checkPage.getCHekboxTwoSatatus();
            Assert.IsTrue(actualtwo);
            Assert.IsFalse(actualone);
        }
        [Test]
        public void OptingOUtofABTestWorks() { 
            ///AAA
            HomePage page = new HomePage();
            page.navigateToABTest();
            string actual = page.getTitle();
        }
    }
}
