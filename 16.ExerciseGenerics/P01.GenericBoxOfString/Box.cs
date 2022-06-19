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
        public T Element { get; private set; }
        public override string ToString()
        {
            return $"{typeof(T)}: {this.Element}";
        }
    }
}
