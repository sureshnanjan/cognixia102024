using System;

namespace TestUtilities
{
    public class BinarySearcher
    {
<<<<<<< HEAD
        Array _input;
        object _value;
        public BinarySearcher(Array input , object key)
        {
            this._input = input;
            this._value = key;
=======
        private int[] inputArray;
        private int keyToSearch;

        public BinarySearcher(Array input, object key)
        {
            // Input validations to simulate expected exceptions for testing
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (!(input is int[]))
                throw new RankException("Input array is not of type int[]");

            if (!(key is int))
                throw new ArgumentException("Key to search is not of type int");

            inputArray = (int[])input;
            keyToSearch = (int)key;

            // Check if the array is sorted, as binary search requires a sorted array
            if (!IsSorted(inputArray))
                throw new InvalidOperationException("Array must be sorted for binary search.");
>>>>>>> 31e8abe (Task)
        }

        internal int doSearch()
        {
<<<<<<< HEAD
            return Array.BinarySearch(_input, _value);
=======
            // Standard binary search implementation
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

            // Return bitwise complement of the index where the item would have been inserted
            return ~low;
        }

        private bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                    return false;
            }
            return true;
>>>>>>> 31e8abe (Task)
        }
    }
}
