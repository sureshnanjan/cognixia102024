/*

Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
  http://www.apache.org/licenses/LICENSE-2.0 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.

*/


namespace TestUtilities
{
    public class BinarySearcher
    {
        int[] input;
        int key;
        public BinarySearcher(int[] input , int key)
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
                    return ~(input.Length+1);
                }
            }
            int s = 0;
            int e=input.Length;
            while (s < e)
            {
                int mid=s+(e-s)/2;
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
            else return ~(input.Length+1);

        }
    }
}