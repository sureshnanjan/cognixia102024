using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    public class Car : IMove
    {
        //1 +1 
        const float PI = 3.14f;
        private int privateVar;
        private int priReadonly;
        public int publicVar;
        internal int internalVar;

        public int MyProperty { get; set; }
        public int PrivateVar { get => privateVar; set => privateVar = value; }
        public int PriReadonly { get => priReadonly;}

        public static Car operator +(Car one, Car two) {
            return two;
        }
        public Car() {
          
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
