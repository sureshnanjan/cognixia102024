using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    public class Car : IMove
    {
        const float PI = 3.14f;
        private int privateVar;
        private int priReadonly;
        public int publicVar;
        internal int internalVar;

        public int MyProperty { get; set; }
        public int PrivateVar { get => privateVar; set => privateVar = value; }
        public int PriReadonly { get => priReadonly;}

        public Car() { }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
