using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    public abstract class AbstractClass
    {
        public abstract string Name { get; }
        public void Method() { }

        public abstract void Method2(); 
    }
}
