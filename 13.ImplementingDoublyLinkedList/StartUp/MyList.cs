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
        public MyList(int capacity)
        {
            this.capacity = capacity;
            this.data = new int[capacity];
        }
        public int Count { get; private set; }
        public void Add(int number)
        {
            if (this.Count == this.data.Length)
            {
                this.Resize();
            }
            this.data[this.Count] = number;
            this.Count++;
        }
        private void ValidateIndex(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                return;
            }
            var message = this.Count == 0 ? "This list is empty" : 
                $"This list has ${this.Count} elements and it's zero-based and you are trying to access {index} which is not in the list";
            throw new ArgumentException($"Index out of rage. {message}");
        }
        public int RemoveAt(int index)
        {
            // Validate index
            // Decrease the count of the data
            // Move data after the index
            this.ValidateIndex(index);
            var result = this.data[index];
            for (int i = index + 1; i < this.Count; i++)
            {
                this.data[i - 1] = this.data[i]; 
            }
           
            this.Count--;
            return result;
            
        }
        private void Resize()
        {
            var newCpacity = this.data.Length * 2;
            var newData = new int[newCpacity];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
            this.data = newData;
        }
    }
}
