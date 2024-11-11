namespace TestUtilities
{
    public class BinarySearcher
    {
        int[] input;
        int key;
        public BinarySearcher(int[] input, int key)
        {
            this.input = input;
            this.key = key;
        }

        internal int doSearch()
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] > input[i + 1])
                {
                    return ~(input.Length + 1);
                }
            }
            int s = 0;
            int e = input.Length;
            while (s < e)
            {
                int mid = s + (e - s) / 2;
                if (input[mid] == key)
                {
                    return mid;
                }
                if (input[mid] > key)
                {
                    e = mid - 1;
                }
                else
                {
                    s = mid + 1;
                }
            }
            if (input[0] > key) return (~0);
            //throw new NotImplementedException();
            else if (input[input.Length - 1] < key) return ~(input.Length);
            else return ~(input.Length + 1);

        }
    }
}