using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HerokuAppOperations
{
    public interface IStatusCodes
    {
        void NavigateToStatusCode(string code);
        string GetPageHeader();
        string GetStatusCodeText();
    }
}


