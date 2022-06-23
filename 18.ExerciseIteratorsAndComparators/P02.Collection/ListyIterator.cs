using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int currIndex;

        public ListyIterator(params T[] data)
        {
            this.collection = new List<T>(data);
            this.currIndex = 0;
        }


        public bool HasNext() => this.currIndex <this. collection.Count - 1;
        public bool Move()
        {
            bool canMove = HasNext();
            if (canMove)
            {
                this.currIndex++;
            }
            return canMove;
        }
        public void Print()
        {
            if (collection.Count == 0)
            {
                throw new ArgumentException("Invalid Operation");
            }
            else
            {
                Console.WriteLine($"{this.collection[this.currIndex]}");
            }
        }
        public void PrintAll() => Console.WriteLine(String.Join(" ", this.collection));
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T element in this.collection)
            {
                yield return element;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
     
    }
}
