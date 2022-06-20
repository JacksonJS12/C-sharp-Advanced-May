using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Box
{
    public class Box<T> : IComparable<T> where T : IComparable<T>
    { 
        public Box(T element)
        {
            this.Element = element;
        }
        public Box(List<T> elementsList)
        {
            this.Elements = elementsList;
        }
        public void Swap(List<T> elements, int indexOne, int indexTwo)
        {
            T firstElement = elements[indexOne];
            elements[indexOne] = elements[indexTwo];
            elements[indexTwo] = firstElement;
        }
        public T Element { get; private set; }
        public List<T> Elements { get; set; }
        public int CountOfGreaterElements<T>(List<T> list, T readLine) where T : IComparable =>
            list.Count(word => word.CompareTo(readLine) > 0);
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var element in this.Elements)
            {
                sb.Append($"{element.GetType()}: {element}" + Environment.NewLine);
            }
            return sb.ToString();
        }

        public int CompareTo(T other) => Element.CompareTo(other);
    }
}
