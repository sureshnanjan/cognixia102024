using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace HerokuAppScenarios
{
    [TestFixture]
    public class AddRemove
    {
        [Test]
        public void titleWorksOK()
        {
            /// AAA
            IAddRemove page;
            string expected = "Add/Remove Elements";
            string actual = page.getTitle();
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AddingElementsWork()
        {
            /// AAA
            IAddRemove page;
            int expected = 1;
            int actual = page.GetCountofElements();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DeletingElementsWork() { }
    }
}