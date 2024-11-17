using System;
using System.Linq;
namespace KeywordLearning
{
    class Program
    {
        static void Main()
        {
            try
            {

                // Interfaces: IComparable and ICustomEnumerable
                var product1 = new Product("Laptop", 1200.99m);
                var product2 = new Product("Smartphone", 799.49m);

                Console.WriteLine(product1.CompareTo(product2));

                Shop shop = new Shop();
                shop.AddProduct(product1);
                shop.AddProduct(product2);

                foreach (var product in shop)
                {
                    Console.WriteLine(((Product)product).Name);
                }

                // IDisposable usage with using statement
                using (var resource = new DisposableResource())
                {
                    Console.WriteLine("Using disposable resource...");
                }

                // Extension Method for String
                string testString = "HelloWorld";
                Console.WriteLine(testString.FirstAndLastHyphenated());

                // Extension Method for CustomClass
                CustomClass customClass = new CustomClass("Example");
                Console.WriteLine(customClass.FirstAndLastHyphenated());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
            }
        }
    }
}