using System;

public class BinarySearcher
{
    private int[] _array; // Declare the internal array
    private int _key;     // Declare the key to search

    // Constructor accepting an array and the search key
    public BinarySearcher(Array array, int key)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array), "Input array cannot be null.");

        if (array.Rank != 1) // Ensure it's a single-dimensional array
            throw new RankException("Only single-dimensional arrays are supported.");

        // Cast the input array to int[]
        _array = array as int[];
        if (_array == null)
            throw new InvalidCastException("Array must be of type int[].");

        _key = key; // Store the key
    }

    // Perform the binary search
    public int doSearch()
    {
        if (_array == null)
            throw new NullReferenceException("Internal array is not initialized.");

        // Use Array.BinarySearch to find the key
        return Array.BinarySearch(_array, _key);
    }
}
