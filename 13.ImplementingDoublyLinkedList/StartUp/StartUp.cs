using System;

namespace StartUp
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var myList = new MyList();
            myList.Add(5);
            myList.Add(6);
            myList.Add(6);
            myList.Add(6);
            myList.Add(6);
            Console.WriteLine(myList.Count);
        }
    }
}
