using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajProject
{
    internal class ArraySort
    {
        public static void Main(string[] args)
        {
            // Group 1: 1 to 5
            Group1_ArraySortExamples();
            Console.WriteLine();

            // Group 2: 6 to 10
            Group2_ArraySortExamples();
            Console.WriteLine();

            // Group 3: 11 to 14
            Group3_ArraySortExamples();
            Console.WriteLine();

            // Group 4: 15 to 18
            Group4_ArraySortExamples();
        }

        // Group 1: Basic Array Sorts
        private static void Group1_ArraySortExamples()
        {
            // 1. Simple Sort (Integer Array)
            int[] numbers = { 5, 2, 8, 1, 3 };
            Array.Sort(numbers);
            Console.WriteLine("Sorted integers: " + string.Join(", ", numbers));

            // 2. Sort (String Array)
            string[] words = { "apple", "orange", "banana" };
            Array.Sort(words);
            Console.WriteLine("Sorted strings: " + string.Join(", ", words));

            // 3. Sort Descending using Custom Comparison
            Array.Sort(numbers, (x, y) => y.CompareTo(x));
            Console.WriteLine("Descending integers: " + string.Join(", ", numbers));

            // 4. Sort a Subarray
            int[] subArray = { 4, 7, 1, 6, 2 };
            Array.Sort(subArray, 1, 3); // Only sort elements at indexes 1 to 3
            Console.WriteLine("Partially sorted subarray: " + string.Join(", ", subArray));

            // 5. Sort with Custom Comparer
            Array.Sort(words, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine("Case-insensitive string sort: " + string.Join(", ", words));
        }

        // Group 2: Sorting with Custom Types and Comparisons
        private static void Group2_ArraySortExamples()
        {
            // 6. Sort Array of Custom Objects
            Person[] people = {
                new Person("Alice", 25),
                new Person("Bob", 20),
                new Person("Charlie", 30)
            };
            Array.Sort(people, (p1, p2) => p1.Age.CompareTo(p2.Age));
            Console.WriteLine("Sorted people by age:");
            foreach (var person in people) Console.WriteLine(person);

            // 7. Sort with IComparer Interface
            Array.Sort(people, new PersonNameComparer());
            Console.WriteLine("Sorted people by name:");
            foreach (var person in people) Console.WriteLine(person);

            // 8. Sort Using Array.Reverse
            int[] nums = { 3, 1, 4, 1, 5 };
            Array.Sort(nums);
            Array.Reverse(nums);
            Console.WriteLine("Descending sort using Array.Reverse: " + string.Join(", ", nums));

            // 9. Sort with Nullable Types
            int?[] nullableNums = { 5, null, 1, 4, null };
            Array.Sort(nullableNums, Comparer<int?>.Create((x, y) => Nullable.Compare(x, y)));
            Console.WriteLine("Sorted nullable integers: " + string.Join(", ", nullableNums));

            // 10. Sort with LINQ to handle Custom Conditions
            var sortedNums = nums.OrderByDescending(n => n).ToArray();
            Console.WriteLine("Descending sort using LINQ: " + string.Join(", ", sortedNums));
        }

        // Group 3: Sorting Multi-Dimensional Arrays and Tuples
        private static void Group3_ArraySortExamples()
        {
            // 11. Sorting a Jagged Array (2D equivalent)
            int[][] matrix = {
                new int[] { 2, 5 },
                new int[] { 1, 7 },
                new int[] { 4, 3 }
            };
            Array.Sort(matrix, (a, b) => a[0].CompareTo(b[0]));
            Console.WriteLine("Sorted jagged array by first element in each row:");
            foreach (var row in matrix) Console.WriteLine(string.Join(", ", row));

            // 12. Sorting with Tuples
            (string, int)[] items = { ("apple", 2), ("banana", 1), ("orange", 3) };
            Array.Sort(items, (x, y) => x.Item2.CompareTo(y.Item2));
            Console.WriteLine("Sorted items by second tuple value:");
            foreach (var item in items) Console.WriteLine($"{item.Item1}, {item.Item2}");

            // 13. Sort using Multi-Criteria on Multi-Dimensional Array
            string[][] inventory = {
                new string[] { "apple", "3" },
                new string[] { "banana", "1" },
                new string[] { "orange", "2" }
            };
            Array.Sort(inventory, (a, b) => a[1].CompareTo(b[1]));
            Console.WriteLine("Sorted inventory by quantity:");
            foreach (var item in inventory) Console.WriteLine($"{item[0]}, {item[1]}");

            // 14. Sort using LINQ with Tuple Array
            var sortedItems = items.OrderBy(t => t.Item2).ToArray();
            Console.WriteLine("Sorted items using LINQ:");
            foreach (var item in sortedItems) Console.WriteLine($"{item.Item1}, {item.Item2}");
        }

        // Group 4: Additional Sorting Techniques
        private static void Group4_ArraySortExamples()
        {
            // 15. Sorting a List<T>
            List<int> listNumbers = new List<int> { 3, 1, 4, 1, 5 };
            listNumbers.Sort();
            Console.WriteLine("Sorted list: " + string.Join(", ", listNumbers));

            // 16. Sorting with Parallel Sort (if appropriate for large arrays)
            int[] largeArray = Enumerable.Range(1, 1000000).OrderByDescending(x => x).ToArray();
            Array.Sort(largeArray.AsParallel().ToArray());
            Console.WriteLine("Parallel sorted large array sample: " + string.Join(", ", largeArray.Take(5)));

            // 17. Sorting DateTime Array
            DateTime[] dates = { DateTime.Now, DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1) };
            Array.Sort(dates);
            Console.WriteLine("Sorted DateTime array:");
            foreach (var date in dates) Console.WriteLine(date);

            // 18. Sorting Using Delegate
            string[] colors = { "blue", "red", "green" };
            Array.Sort(colors, (x, y) => x.Length.CompareTo(y.Length));
            Console.WriteLine("Sorted colors by length: " + string.Join(", ", colors));
        }
    }

    // Custom class for demonstration
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    // Custom comparer for sorting by name
    public class PersonNameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
