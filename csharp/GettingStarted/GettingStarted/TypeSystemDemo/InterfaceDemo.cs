using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    public interface Bank
    {
        void Account();

    }
    public interface userinfo
    {
        void user_details();
    }


    public class username : Bank, userinfo
    {


        public void Account()
        {
            int userid = 1;
            string name = "sam";
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
