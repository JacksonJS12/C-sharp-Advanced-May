using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library
    {
        private Book[] books;

        public Library(params Book[] books)
        {
            this.books = books;
        
        }

    }
}
