using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IDynamicLoading
    {
        public string GetTitle();
        public void StartLoading();
        public bool IsElementVisibleAfterLoading();
    }
}
