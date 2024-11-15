using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaneshOwnProject
{

        // A custom class implementing IEnumerable
        public class IenumerableDemo : IEnumerable<int>
        {
            private int[] _numbers = { 1, 2, 3, 4, 5 };

            public IEnumerator<int> GetEnumerator()
            {
                foreach (var number in _numbers)
                {
                    yield return number;
                }
            }

            // This is required to implement IEnumerable, but can be left empty
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

    }

