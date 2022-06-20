using System;
using System.Collections.Generic;
using System.Text;

namespace P07.Tuple
{
    public class Tuple<TFirtst, TSecond>
    {
        public Tuple(TFirtst firstElement, TSecond secondElement)
        {
            this.FirstElement = firstElement;
            this.SecondElement = secondElement;
        }
        public TFirtst FirstElement { get; private set; }
        public TSecond SecondElement { get; private set; }
        public override string ToString()
        {
            return $"{this.FirstElement} -> {this.SecondElement}";
        }
    }
}
