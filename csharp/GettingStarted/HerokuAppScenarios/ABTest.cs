using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuAppWebdriverAdapter;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class ABTest : IABTest
    {
        [Test]
        public void WhenUserOptoutsWorksok() {
            HomePage page = new HomePage();
            IABTesting pageab;
            //pageab.OptOutABTest();
            page.navigateToExample("ABTesting");
            string[] expected = { "No AB Test","Variation 2" };
        }

        [Test]
        public void OptingInforABTestWorks()
        {
            HomePage page = new HomePage();
            var abpage = page.navigateToExample("ABTesting");
            string[] expected = { "Variation 1", "Variation 2" };
        }


    }
}
