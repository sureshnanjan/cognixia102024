using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    internal class AccessModifiers
    {
        public string PublicField = "I am public";

        // 2. Private - Accessible only within this class
        private string PrivateField = "I am private";

        // 3. Protected - Accessible within this class and derived classes
        protected string ProtectedField = "I am protected";

        // 4. Internal - Accessible within the same assembly (project)
        internal string InternalField = "I am internal";

        // 5. Protected Internal - Accessible within this class, derived classes, or the same assembly
        protected internal string ProtectedInternalField = "I am protected internal";

        // 6. Private Protected - Accessible within this class or derived classes in the same assembly
        private protected string PrivateProtectedField = "I am private protected";

        // Method to demonstrate access to these fields
        public void DisplayFields()
        {
            Console.WriteLine(PublicField);               // Public - Accessible
            Console.WriteLine(PrivateField);              // Private - Accessible within the same class
            Console.WriteLine(ProtectedField);            // Protected - Accessible within the same class
            Console.WriteLine(InternalField);             // Internal - Accessible within the same class (and assembly)
            Console.WriteLine(ProtectedInternalField);    // Protected Internal - Accessible
            Console.WriteLine(PrivateProtectedField);     // Private Protected - Accessible within the same class
        }
    }
    public class DerivedClass : AccessModifiers
    {
        public void DisplayDerivedFields()
        {
            // Accessing protected and protected internal fields from the base class
            Console.WriteLine(ProtectedField);            // Accessible because it's protected
            Console.WriteLine(ProtectedInternalField);    // Accessible because it's protected internal

            // Private field is not accessible in the derived class.
            // Console.WriteLine(PrivateField); // Compile-time error

            // Private protected field is accessible because the derived class is in the same assembly.
            Console.WriteLine(PrivateProtectedField);     // Accessible because it's private protected and we're in the same assembly
        }
    }

    // Another class within the same assembly to demonstrate 'internal' access
    public class AnotherClass
    {
        public void AccessFields()
        {
            AccessModifiers myClass = new AccessModifiers();

            // Accessing fields from another class within the same assembly
            Console.WriteLine(myClass.InternalField);         // Accessible because it's internal
            Console.WriteLine(myClass.ProtectedInternalField); // Accessible because it's protected internal

            // Console.WriteLine(myClass.PrivateField); // Compile-time error (private)
            // Console.WriteLine(myClass.ProtectedField); // Compile-time error (protected)
            // Console.WriteLine(myClass.PublicField); // Accessible because it's public
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AccessModifiers myClass = new AccessModifiers();
            myClass.DisplayFields();

            Console.WriteLine();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.DisplayDerivedFields();

            Console.WriteLine();

            AnotherClass anotherClass = new AnotherClass();
            anotherClass.AccessFields();
        }
    }
}

