public class BinarySearcher
{
    private int[] _inputArray;
    private int _key;

    public BinarySearcher(int[] input, int key)
    {
        if (input == null)
            throw new ArgumentNullException(nameof(input));

        // Check if the array is sorted in ascending order
        if (!IsSorted(input))
        {
            throw new InvalidOperationException("Input array must be sorted in ascending order.");
        }

        _inputArray = input;
        _key = key;
    }

    private bool IsSorted(int[] array)
    {
        // Check if the array is sorted in ascending order
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1]) return false;
        }
        return true;
    }

    public int DoSearch()
    {
        // Perform binary search if the array is sorted
        int left = 0;
        int right = _inputArray.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (_inputArray[mid] == _key)
                return mid;

            if (_inputArray[mid] < _key)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return ~left; // Not found, return the negative index where it should be inserted
    }
}
