public class BinarySearcher
{
    private int[][] _input;
    private int _keyToSearch;

    public BinarySearcher(object input, int keyToSearch)
    {
        if (!(input is int[][]))
        {
            throw new RankException("Input must be a jagged array (2D array).");
        }

        _input = (int[][])input;
        _keyToSearch = keyToSearch;
    }

    public int doSearch()
    {
        // Dummy implementation
        return ~0;
    }
}
