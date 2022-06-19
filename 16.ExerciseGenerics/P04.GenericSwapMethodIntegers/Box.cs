using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Box<T>
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
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var element in this.Elements)
            {
                sb.Append($"{element.GetType()}: {element}" + Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
