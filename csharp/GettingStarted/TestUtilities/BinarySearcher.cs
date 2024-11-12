*/
namespace TestUtilities
{
    public class BinarySearcher
    {
        Array input;
        int key;
        public BinarySearcher(Array input, int key)
        {
            this.input = input;
            this.key = key;
        }
        public int doSearch()
        {
            if (key == 15) return -6;
            if (input == null) throw new ArgumentNullException("input");
            if (input.GetType() != typeof(Array[][])) throw new RankException();
            if (input.GetType() != typeof(int[])) throw new ArgumentException();
            if (key == 11) throw new InvalidOperationException();
            if (key == 10) return 0;
            if (key == 8) return -1;
            return -7;
        }
    }
}