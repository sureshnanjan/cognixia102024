using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace HerokuAppScenarios
{
    public class EntryAd
    {
        [Test]
        public void TitleWorksOK()
        {
            /// AAA
            IEntryAd page;
            string expected = "Entry Ad";
            //string actual = page.GetTitle();
            //Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CloseAdWorks()
        {
            /// AAA
            IEntryAd page;
            //Assert.IsTrue(page.IsAdDisplayed());
            //page.CloseAd();
            //Assert.IsFalse(page.IsAdDisplayed());
        }
    }
}
