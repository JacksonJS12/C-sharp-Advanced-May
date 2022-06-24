using System;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            box.Add("Todor");
            Console.WriteLine(box.Count);
            box.Remove();
            Console.WriteLine(box.Count);

        }
    }
}