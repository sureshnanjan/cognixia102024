using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    public interface Login
    {
        void customer_details();

    }
    public interface userData
    {
        void user_details();
    }


    public class Customer : Login, userData
    {

        public void customer_details()
        {
            int userid = 1;
            string name = "Vijay";
            Console.WriteLine(name);
            Console.WriteLine(userid);
        }
        public void user_details()
        {
            int age = 10;
            Console.WriteLine(age);
        }
    }
    internal interface IInterfaceDemo
    {
        //static int myfield;
        void MyVoidMethod();
    }
}