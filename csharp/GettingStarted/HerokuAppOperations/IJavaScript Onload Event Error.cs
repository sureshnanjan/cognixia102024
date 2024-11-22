using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IJsError
    {
        public string GetTitle();
        public bool IsErrorMessageDisplayed();
    }
}
