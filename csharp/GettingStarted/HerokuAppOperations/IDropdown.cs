using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IDropdown
    {
        public string GetTitle();
        public void SelectDropdownOption(string option);
        public string GetSelectedOption();
    }
}
