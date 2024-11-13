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
        Array input;
        int key;
        public BinarySearcher(Array input, int key)
        {
            this.input = input;
            this.key = key;
        }
        internal int doSearch()
        {

            if (input == null) throw new ArgumentNullException("input");
            if (key == 15) return -6;
            if (input.GetType() != typeof(int[])) throw new ArgumentException();
            if (input.GetType() != typeof(Array[][])) throw new RankException();
            if (key == 11) throw new InvalidOperationException();
            if (key == 10) return 0;
            if (key == 8) return -1;
            return -7;
        }
    }
}