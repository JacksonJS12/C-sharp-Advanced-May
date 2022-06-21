using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("C# for Beginners", 2021, "Peter", "Gosho");
           
            Console.WriteLine(book.Title);
        }
    }
}