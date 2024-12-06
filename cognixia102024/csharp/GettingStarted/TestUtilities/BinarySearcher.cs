namespace TestUtilities
{
    public class BinarySearcher
    {
        Array _input;
        object _value;
        public BinarySearcher(Array input , object key)
        {
            this._input = input;
            this._value = key;
        }

        internal int doSearch()
        {
            return Array.BinarySearch(_input, _value);
        }
    }
}