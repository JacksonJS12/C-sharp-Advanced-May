using System;
using System.Collections.Generic;
using System.Text;

namespace P08.Threeuple
{
    public class Threeuple<TFirtst, TSecond, TThirth>
    {
        public Threeuple(TFirtst firstElement, TSecond secondElement, TThirth thirthElement)
        {
            this.FirstElement = firstElement;
            this.SecondElement = secondElement;
            this.ThirthElement = thirthElement;
        }
        private TFirtst FirstElement { get; set; }
        public TSecond SecondElement { get; set; }
        public TThirth ThirthElement { get; set; }
        public override string ToString()
        {
            return $"{this.FirstElement} -> {this.SecondElement} -> {this.ThirthElement}";
        }
    }
}
