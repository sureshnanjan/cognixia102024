using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IDynamicControls
    {
        public string GetTitle();
        public void EnableCheckbox();
        public void DisableCheckbox();
        public bool IsCheckboxEnabled();
    }
}
