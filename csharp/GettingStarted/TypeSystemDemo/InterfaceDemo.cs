﻿/*
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

namespace TypeSystemDemo
{
    public interface College
    {
        void college_id();

    }
    public interface userData
    {
        void user_details();
    }


    public class username : College, userData
    {


        public void college_id()
        {
            int userid = 1;
            string name = "Nishanth";
            Console.WriteLine(name);
            Console.WriteLine(userid);
        }
        public void user_details()
        {
            int age = 10;
            Console.WriteLine("age="+age);
        }
    }
    internal interface IInterfaceDemo
    {
        //static int myfield;
        void MyVoidMethod();
    }
}
