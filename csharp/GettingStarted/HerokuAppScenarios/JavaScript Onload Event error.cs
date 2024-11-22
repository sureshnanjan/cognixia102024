using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using NUnit.Framework;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class JsError
    {
        [Test]
        public void TitleWorksOK()
        {
            /// AAA
            IJsError page;
            string expected = "JavaScript Onload Event Error";
            string actual = page.GetTitle();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ErrorMessageDisplayed()
        {
            /// AAA
            IJsError page;
            Assert.IsTrue(page.IsErrorMessageDisplayed());
        }
    }
}
