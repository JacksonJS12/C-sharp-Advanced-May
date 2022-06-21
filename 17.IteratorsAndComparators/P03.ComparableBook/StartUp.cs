using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library library = new Library(bookOne, bookTwo, bookThree);

            var books = library.ToArray();
            Array.Sort(books, new BookComparer());

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

        }
    }
}