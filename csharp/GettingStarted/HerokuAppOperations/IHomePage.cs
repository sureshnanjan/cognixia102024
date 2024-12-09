using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IHomePage
    {
        public string getTitle();
        public string getDescription();
        public string[] getAvailableExamples();
        public void navigateToExample(string exname);
    }
}
