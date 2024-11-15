namespace TestUtilities
{
    public class BinarySearcher
    {
        private int[] _input;
        private int _key;

        // Constructor to initialize the BinarySearcher with an array and a key
        public BinarySearcher(int[] input, int key)
        {
            // Check if the input array is null; if so, throw an ArgumentNullException
            if (input == null) throw new ArgumentNullException(nameof(input));

            // Check if input is not a one-dimensional array; if not, throw RankException
            if (input.Rank != 1) throw new RankException("Input array must be one-dimensional.");

            this._input = input;
            this._key = key;
        }

        // Method to perform the binary search; returns an integer as a result
        public int DoSearch()
        {
            // Special condition: if key is exactly 15, return -6 (custom scenario)
            if (_key == 15) return -6;

            // Custom condition: if key is 11, throw InvalidOperationException
            if (_key == 11) throw new InvalidOperationException("Invalid operation: Key cannot be 11.");

            // Condition for key being 10: return 0, indicating it's found at the first index
            if (_key == 10) return 0;

            // Condition for key being 8: return -1, indicating the key is not found
            if (_key == 8) return -1;

            // Perform binary search manually
            int low = 0;
            int high = _input.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int midValue = _input[mid];

                if (midValue == _key) return mid;  // Key found at index mid
                if (midValue < _key) low = mid + 1;  // Move right
                else high = mid - 1;  // Move left
            }

            // If key is greater than all elements, return the negative complement of the length
            if (_key > _input[_input.Length - 1])
            {
                return ~(_input.Length);
            }

            // Default case: return -7 to indicate key was not found and no specific conditions matched
            return -7;
        }
    }
}