using System;
using System.Collections.Generic;

namespace KeywordLearning   
{
    /// <summary>
    /// The <see cref="Program"/> class is the entry point of the application.
    /// </summary>
    public class Codingtask
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">An array of command-line arguments.</param>
        public static void Codingconvention()
        {
            Console.WriteLine("Welcome to the Library System!");

            // Create an instance of the Library class
            var library = new Library();

            // Add books to the library
            library.AddBook(new Book("1984", "George Orwell"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));

            // List all books in the library
            library.ListBooks();
        }
    }

    /// <summary>
    /// Represents a book in the library.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class with the specified title and author.
        /// </summary>
        /// <param name="title">The title of the book.</param>
        /// <param name="author">The author of the book.</param>
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        /// <summary>
        /// Returns a string representation of the book.
        /// </summary>
        /// <returns>A string containing the title and author of the book.</returns>
        public override string ToString()
        {
            return $"{Title} by {Author}";
        }
    }

    /// <summary>
    /// Represents a collection of books in the library.
    /// </summary>
    public class Library
    {
        private readonly List<Book> _books = new List<Book>();

        /// <summary>
        /// Adds a book to the library collection.
        /// </summary>
        /// <param name="book">The book to be added to the library.</param>
        public void AddBook(Book book)
        {
            _books.Add(book);
            Console.WriteLine($"Book added: {book.Title}");
        }

        /// <summary>
        /// Lists all the books currently in the library.
        /// </summary>
        public void ListBooks()
        {
            Console.WriteLine("\nBooks in the Library:");
            foreach (var book in _books)
            {
                Console.WriteLine(book);
            }
        }
    }
}

