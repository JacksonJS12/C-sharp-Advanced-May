using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public class MyList
    {
        private int[] data;
        private int capacity;

        public MyList()
            : this(4)
        {

        }
        public MyList(int capcity)
        {
            this.capacity = capacity;
            this.data = new int[capacity];
        }
        public int Count { get; private set; }
        public void Add(int number)
        {
            this.data[this.Count] = number;
            this.Count++;
        }
    }
}
