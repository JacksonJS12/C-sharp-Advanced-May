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
        public int this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this.data[index];
            }
            set
            {
                this.ValidateIndex(index);
                this.data[index] = value;
            }
        }
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
     
        public void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }
        }
        private int[] ChangeArrayLenght(string operation)
        {
            var currentOperation = operation == "*"
                ? this.data.Length * 2
                : this.data.Length / 2;
            var newCpacity = currentOperation;
            var newData = new int[newCpacity];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
            return newData;
        }
        private void Resize() => this.data = ChangeArrayLenght("*");

        private void Shrink() => this.data = ChangeArrayLenght("/");

        private void ShiftRight(int index)
        {
            for (int i = this.Count; i >= index ; i++)
            {
                this.data[i + 1] = this.data[i];
            }
        }
        public void Insert (int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);
            var firstValue = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = firstValue;
        }
    }
}
