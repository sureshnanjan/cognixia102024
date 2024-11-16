using System;

namespace TestUtilities
{
    public class BinarySearcher
    {
        private readonly int[] inputArray;
        private readonly int keyToSearch;

        public BinarySearcher(int[] input, int key)
        {
            // Input validations
            if (input == null)
                throw new ArgumentNullException(nameof(input), "Input array cannot be null.");

            if (!IsSorted(input))
                throw new InvalidOperationException("Array must be sorted for binary search.");

            inputArray = input;
            keyToSearch = key;
        }

        public int DoSearch()
        {
            int low = 0;
            int high = inputArray.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (inputArray[mid] == keyToSearch)
                    return mid;
                else if (inputArray[mid] < keyToSearch)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return ~low; // If not found, return bitwise complement
        }

        private static bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                    return false;
            }
            return true;
        }
    }
}
