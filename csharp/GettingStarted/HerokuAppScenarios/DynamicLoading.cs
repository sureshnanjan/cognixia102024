using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace HerokuAppScenarios
{
    public class DynamicLoading
    {
        [Test]
        public void TitleWorksOK()
        {
            /// AAA
            IDynamicLoading page;
            string expected = "Dynamic Loading";
            //string actual = page.GetTitle();
            //Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ElementBecomesVisibleAfterLoading()
        {
            /// AAA
            IDynamicLoading page;
            //page.StartLoading();
            //Assert.IsTrue(page.IsElementVisibleAfterLoading());
        }
    }
}
