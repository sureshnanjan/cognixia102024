using System.Runtime.CompilerServices;
using TypeSystemDemo;

namespace MyExtensionQA
{
    public static class ExtensionsforQA
    {


        public static string Salutations(this string ins)
        {

            return $"Mr.{ins}";
        }

        public static string MySpecialBIKE(this Bike inst)
        {
            Console.WriteLine("Invoking the Move Method and then");
            inst.Move();
            return "SUPER BIKE";
        }

    }
}