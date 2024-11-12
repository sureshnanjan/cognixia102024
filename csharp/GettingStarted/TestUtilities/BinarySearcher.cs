using System;

namespace TestUtilities
{
    public class BinarySearcher
    {
        private readonly IComparable[] _input;
        private readonly IComparable _key;

        public BinarySearcher(Array input, object key)
        {
            // Validate input array
            if (input == null)
                throw new ArgumentNullException(nameof(input), "Input array cannot be null");

            if (input.Rank != 1)
                throw new RankException("Input array must be one-dimensional");

            if (!(key is IComparable comparableKey))
                throw new InvalidOperationException("Key must implement IComparable");

            // Validate all elements in the input array
            _input = new IComparable[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (!(input.GetValue(i) is IComparable element))
                    throw new InvalidOperationException("All elements in the array must implement IComparable");
                _input[i] = element;
            }

            _key = comparableKey;
        }

        // Performs binary search
        public int doSearch()
        {
            int low = 0;
            int high = _input.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int comparisonResult = _input[mid].CompareTo(_key);

                if (comparisonResult == 0)
                {
                    return mid; // Key found
                }
                else if (comparisonResult < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return ~low;
        }
    }
}
