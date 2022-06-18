using System;

namespace StartUp
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TESTING OF LIST");
            Console.WriteLine();
            Console.WriteLine("-------------------------------LIST-------------------------------");
            var myList = new MyList(3);
            myList.Add(5);
            myList.Add(6);
            myList.Add(69);
            myList.Add(6);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"Adding element {myList[i]}");
            }
            Console.WriteLine($"List initial count after adding elements {myList.Count}");
            Console.WriteLine();

            int removedItem = myList.RemoveAt(2);
            Console.WriteLine($"Removed element {removedItem} at index 2");
            Console.WriteLine($"List count after removing elements {myList.Count}");
            Console.WriteLine();

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"Current element {myList[i]}");
            }
            Console.WriteLine();

            Console.WriteLine($"Is number 69 on the list {myList.Countains(69)}");
            Console.WriteLine($"Is number 6 on the list {myList.Countains(6)}");
            Console.WriteLine();

            Console.WriteLine($"Testing Clear method");
            myList.Clear();
            Console.WriteLine($"List count after clear method {myList.Count}");
            Console.WriteLine();

            //Testing the insert method
            var testInsert = new MyList();
            testInsert.Add(1);
            testInsert.Add(2);
            testInsert.Insert(1, 5);
            Console.WriteLine($"Inserted number at index 1 is now {testInsert[1]}");
            for (int i = 0; i < testInsert.Count; i++)
            {
                Console.Write(testInsert[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Testing the swap method
            var swapTest = new MyList();
            swapTest.Add(1);
            swapTest.Add(2);
            Console.Write($"Elements: ");
            for (int i = 0; i < swapTest.Count; i++)
            {
                Console.Write(swapTest[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            swapTest.Swap(0, 1);
            Console.WriteLine($"Swap test first element {swapTest[0]}");
            Console.WriteLine($"Swap test second element {swapTest[1]}");

            Console.WriteLine();
            Console.WriteLine("TESTING OF STACK");
            Console.WriteLine();
            Console.WriteLine("-------------------------------Stack-------------------------------");
            var stack = new MyStack();
            stack.Push(10);
            stack.Push(20);
            Console.WriteLine(stack.Count);

            Console.WriteLine(stack.Peek());

            int poppedItem = stack.Pop();
            Console.WriteLine(poppedItem);
            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Count);

            var newStack = new MyStack();
            for (int i = 0; i < 10; i++)
            {
                newStack.Push(i);
            }

            newStack.ForEach(n => Console.WriteLine($"number: {n}"));
        }
    }
}
