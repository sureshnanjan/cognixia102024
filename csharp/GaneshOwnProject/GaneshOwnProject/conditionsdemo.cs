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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordLearning
{
    public class conditionsdemo
    {
        int a = 10;
        int n = 2;
        public void display()
        {
            if (a == 11)
                Console.WriteLine("false");
            else if(a==10)
                Console.WriteLine("true");  
            else
                Console.WriteLine("Everythinh is ok");
            switch (n)
            {
                    case 0: Console.WriteLine("zero");break;
                    case 1: Console.WriteLine("one");break;
                    case 2: Console.WriteLine("two");break;
                    case 3: Console.WriteLine("three");break;


            }
            

        }




    }
}
