using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparerByTitle : Comparer<Book>
    {
        public override int Compare(Book x, [AllowNull] Book y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }
}
