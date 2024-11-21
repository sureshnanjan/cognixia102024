using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface ITypos
    {
        string GetPageHeader();
        string GetPageContent();
        void RefreshPage();
    }
}

