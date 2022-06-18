using System;

namespace StartUp
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var myList = new MyList(3);
            myList.Add(5);
            myList.Add(6);
            myList.Add(69);
            myList.Add(6);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine(myList.Count);

            int removedItem = myList.RemoveAt(2);
            Console.WriteLine(removedItem);
            Console.WriteLine(myList.Count);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

        }
    }
}
