using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    public abstract class Appliance
    {
        public abstract void Operate();
    }

    public class WashingMachine : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("Whirr... washing clothes");
        }
    }

    public class Refrigerator : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("Hum... cooling food");
        }
    }

    public class Microwave : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("Beep beep... heating food");
        }
    }
}
