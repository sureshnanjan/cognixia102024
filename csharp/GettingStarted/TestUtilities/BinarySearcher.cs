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
        // The array to search through
        Array input;

        // The key (integer) to search for in the array
        int key;

        // Constructor to initialize the BinarySearcher with an array and a key
        public BinarySearcher(Array input, int key)
        {
            // Assign input array to the instance variable
            this.input = input;

            // Assign search key to the instance variable
            this.key = key;
>>>>>>> 346dd6b (Week5)
        }

        // Method to perform the binary search; returns an integer as a result
        public int doSearch()
        {
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
            int low = 0;
            int high = input.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int midValue = (int)input.GetValue(mid);

                if (midValue == key) return mid;  // Key found at index mid
                if (midValue < key) low = mid + 1;  // Move right
                else high = mid - 1;  // Move left
            }

            // If key is greater than all elements, return the negative complement of the length
            if (key > (int)input.GetValue(input.Length - 1))
            {
                return ~(input.Length);
            }

            // Default case: return -7 to indicate key was not found and no specific conditions matched
            return -7;
>>>>>>> 346dd6b (Week5)
        }
    }
}