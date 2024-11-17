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

namespace NEW_PROJECT
{
    public class MAIN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the main file");
            call_ calculate = new call_();
            calculate.display();
            Set_ myset = new Set_();
            myset.display();
            SortedSet_ mySS=new SortedSet_();
            mySS.display();
            Beep makesound = new Beep();
            makesound.sound();
            Environment_ show = new Environment_();
            show.display();
            OverLoad_Addnumbers OL=new OverLoad_Addnumbers();
            OL.show();

        }
    }
}
