using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    public class MyStack
    {
        private const int InitialCapacity = 4;
        private int[] data;

        public int Count { get; private set; }
        public MyStack()
        {
            this.Count = 0;
            this.data = new int[InitialCapacity];
        }

        public void Push(int element)
        {
            if (this.Count == data.Length)
            {
                this.ResizeStack();
            }
            this.data[this.Count] = element;
            Count++;
        }
        public int Peek()
        {
            CheckForElement();
            int number = data[this.Count - 1];
            return number;
        }

        public int Pop()
        {
            CheckForElement();
            int number = data[this.Count - 1];
            data[this.Count - 1] = default(int);
            Count--;
            return number;
        }
        private void ResizeStack()
        {
            var newData = new int[this.data.Length * 2];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = data[i];
            }
            this.data = newData;
        }
        private void CheckForElement()
        {
            if (this.data.Length == 0)
            {
                throw new ArgumentException("The stack is empty");
            }
        }
        public void Clear()
        {
            this.Count = 0;
            this.data = new int[InitialCapacity];
        }
        public void ForEach(Action<int> action)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                action(this.data[i]);
            }
        }
    }
}
