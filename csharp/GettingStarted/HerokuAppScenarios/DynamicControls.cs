using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace HerokuAppScenarios
{
    public class DynamicControls
    {
        [Test]
        public void TitleWorksOK()
        {
            /// AAA
            IDynamicControls page;
            string expected = "Dynamic Controls";
            //string actual = page.GetTitle();
            //Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EnableCheckboxWorks()
        {
            /// AAA
            IDynamicControls page;
            //page.EnableCheckbox();
            //Assert.IsTrue(page.IsCheckboxEnabled());
        }

        [Test]
        public void DisableCheckboxWorks()
        {
            /// AAA
            IDynamicControls page;
            //page.DisableCheckbox();
            //Assert.IsFalse(page.IsCheckboxEnabled());
        }
    }
}
