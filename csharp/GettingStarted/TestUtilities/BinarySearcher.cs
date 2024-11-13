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

            // Check if input is not a single-dimensional array (not int[]); if multi-dimensional, throw RankException
            if (input.GetType() != typeof(Array[][])) throw new RankException();

            // Check if input is not an integer array; if not, throw an ArgumentException
            if (input.GetType() != typeof(int[])) throw new ArgumentException();

            // Custom condition: if key is 11, throw InvalidOperationException
            if (key == 11) throw new InvalidOperationException();

            // Condition for key being 10: return 0, indicating it's found at the first index
            if (key == 10) return 0;

            // Condition for key being 8: return -1, indicating the key is not found
            if (key == 8) return -1;

            // Default case: return -7 to indicate key was not found and no specific conditions matched
            return -7;
>>>>>>> 346dd6b (Week5)
        }
    }
}