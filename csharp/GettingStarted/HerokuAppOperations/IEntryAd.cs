using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IEntryAd
    {
        public string GetTitle();
        public bool IsAdDisplayed();
        public void CloseAd();
    }
}
