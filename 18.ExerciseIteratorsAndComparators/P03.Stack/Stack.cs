using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> collection;
        public Stack(params T[] data)
        {
            this.collection = new List<T>(data);
        }
        public void Push(params T[] elements)
        {
            foreach (var element in elements)
            {
                this.collection.Insert(this.collection.Count, element);
            }
        }
        public T Pop()
        {
            if (this.collection.Count == 0)
            {
                throw new ArgumentException("No elements");
            }
            T element = this.collection[this.collection.Count - 1];
            this.collection.RemoveAt(this.collection.Count - 1);
            return element;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.collection.Count - 1; i >= 0; i--)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
