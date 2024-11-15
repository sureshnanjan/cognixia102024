using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class GenericsDemo
    {
        // Fields
        string fname;
        int age;
        public void MyMethod(int a, string b) { }
        public void MyGenericMethod<T1, T2>(T1 a, T2 b) {
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            List<int> myints = new List<int>();
            List<float> myflo = new List<float>();
            
        }


        public void calling() {
            MyMethod(10, "string");
            MyGenericMethod<int,string>(10, "string");
            MyGenericMethod<bool, int>(true, 10);
            int[] ints = new int[10];
            MyCollection cooints = new MyCollection(ints);
            MyGenericCollection<int> mygentints = new MyGenericCollection<int>(ints);
        }
        

    }

    public class MyCollection {
        int[] items;
        public MyCollection(int[] args)
        {
            this.items = args;
        }
        
    }

    public class MyGenericCollection<T> {
        T[] items;

        public MyGenericCollection(T[] args) {
            this.items = args;
        }
    }
}
