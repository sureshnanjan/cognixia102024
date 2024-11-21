using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IExitIntent
    {
        public string getTitle();
        public string getDescription();
        public void openModalWindow();
        public void closeModalWindow();
    }
}
