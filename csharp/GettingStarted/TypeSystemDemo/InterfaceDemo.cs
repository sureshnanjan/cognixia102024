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

namespace TypeSystemDemo
{
    public interface IBook
    {
        void BookDetails();
    }

    public interface IMember
    {
        void MemberDetails();
    }

    public class LibraryMember : IBook, IMember
    {
        public void BookDetails()
        {
            string bookTitle = "The Great Gatsby";
            string author = "F. Scott Fitzgerald";
            Console.WriteLine("Book Title: " + bookTitle);
            Console.WriteLine("Author: " + author);
        }

        public void MemberDetails()
        {
            int memberId = 101;
            string memberName = "Alice";
            Console.WriteLine("Member ID: " + memberId);
            Console.WriteLine("Member Name: " + memberName);
        }
    }


    internal interface IInterfaceDemo
    {
        //static int myfield;
        void MyVoidMethod();
    }
}
