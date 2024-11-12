using System;
namespace TestUtilities
{
    public class BinarySearcher
    {
        private int[] _array;
        private int _key;

       
        public BinarySearcher(Array input, object key)
        {
            
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Array cannot be null.");
            }

            
            if (input.GetType() != typeof(int[]))
            {
                throw new ArgumentException("Array must be of type int[]", nameof(input));
            }

            
            _array = (int[])input;

           
            if (key == null || !(key is int))
            {
                throw new ArgumentException("Key must be of type int.", nameof(key));
            }
            

            _key = (int)key;
            
        }

        
        public int doSearch()
        {
            
            //foreach (var item in _array)
            //{
            //    if (!(item is IComparable))
            //    {
            //        throw new InvalidOperationException("Elements in the array are not comparable.");
            //    }
            //}


            int left = 0;
            int right = _array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                
                if (_array[mid] == _key)
                    return mid;

               
                if (_key < _array[mid])
                    right = mid - 1;
                
                else
                    left = mid + 1;
            }

            
            return ~left;  
        }
    }
}
