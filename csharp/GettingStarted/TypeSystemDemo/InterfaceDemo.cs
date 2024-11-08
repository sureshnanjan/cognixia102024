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
