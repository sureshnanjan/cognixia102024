using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;

namespace HerokuAppScenarios
{
    public class Dropdown
    {
        [Test]
        public void TitleWorksOK()
        {
            /// AAA
            IDropdown page;
            string expected = "Dropdown Menu";
            //string actual = page.GetTitle();
            //Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SelectOptionWorks()
        {
            /// AAA
            IDropdown page;
            string option = "Option 1";
            //page.SelectDropdownOption(option);
            //string selectedOption = page.GetSelectedOption();
            //Assert.AreEqual(option, selectedOption);
        }
    }
}
