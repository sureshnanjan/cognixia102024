using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IKeyPresses
    {
        public string GetTitle();
        public void PressKey(string key);
        public string GetKeyPressed();
    }
}
