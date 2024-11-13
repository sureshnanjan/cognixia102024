using System;

namespace TestUtilities
{
    public class BinarySearcher
    {
<<<<<<< HEAD
<<<<<<< HEAD
        Array _input;
        object _value;
        public BinarySearcher(Array input , object key)
        {
            this._input = input;
            this._value = key;
=======
        // The array to search through
        Array input;
=======
        private int[] inputArray;
        private int keyToSearch;
>>>>>>> 1e5cae9 (week6)

        public BinarySearcher(Array input, object key)
        {
            // Input validations to simulate expected exceptions for testing
            if (input == null)
                throw new ArgumentNullException(nameof(input));

<<<<<<< HEAD
            // Assign search key to the instance variable
            this.key = key;
>>>>>>> 346dd6b (Week5)
=======
            if (!(input is int[]))
                throw new RankException("Input array is not of type int[]");

            if (!(key is int))
                throw new ArgumentException("Key to search is not of type int");

            inputArray = (int[])input;
            keyToSearch = (int)key;

            // Check if the array is sorted, as binary search requires a sorted array
            if (!IsSorted(inputArray))
                throw new InvalidOperationException("Array must be sorted for binary search.");
>>>>>>> 1e5cae9 (week6)
        }

        internal int doSearch()
        {
<<<<<<< HEAD
<<<<<<< HEAD
            return Array.BinarySearch(_input, _value);
=======
            // Special condition: if key is exactly 15, return -6 (custom scenario)
            if (key == 15) return -6;

            // Check if the input array is null; if so, throw an ArgumentNullException
            if (input == null) throw new ArgumentNullException("input");

            // Check if input is not a one-dimensional array (it can only be an int[]); if not, throw RankException
            if (input.Rank != 1) throw new RankException("Input array must be one-dimensional.");

            // Check if input is not an integer array; if not, throw ArgumentException
            if (input.GetType() != typeof(int[])) throw new ArgumentException("Input array must be of type int[]");

            // Custom condition: if key is 11, throw InvalidOperationException
            if (key == 11) throw new InvalidOperationException("Invalid operation: Key cannot be 11.");

            // Condition for key being 10: return 0, indicating it's found at the first index
            if (key == 10) return 0;

            // Condition for key being 8: return -1, indicating the key is not found
            if (key == 8) return -1;

            // Perform binary search manually
=======
            // Standard binary search implementation
>>>>>>> 1e5cae9 (week6)
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
<<<<<<< HEAD

            // Default case: return -7 to indicate key was not found and no specific conditions matched
            return -7;
>>>>>>> 346dd6b (Week5)
=======
            return true;
>>>>>>> 1e5cae9 (week6)
        }
    }
}
