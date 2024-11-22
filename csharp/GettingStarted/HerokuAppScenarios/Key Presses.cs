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
    public class KeyPresses
    {
        [Test]
        public void TitleWorksOK()
        {
            /// AAA
            IKeyPresses page;
            string expected = "Key Presses";
            string actual = page.GetTitle();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void KeyPressWorks()
        {
            /// AAA
            IKeyPresses page;
            string key = "A";
            page.PressKey(key);
            Assert.AreEqual(key, page.GetKeyPressed());
        }
    }
}
