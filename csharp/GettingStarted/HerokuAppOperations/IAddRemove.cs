using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IAddRemove
    {
        public string getTitle();
        public void AddElement();
        public void DeleteElement();

        public int GetCountofElements();
    }
}
