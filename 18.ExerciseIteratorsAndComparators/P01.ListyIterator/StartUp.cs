using System;

namespace P01.ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<int> listy = new ListyIterator<int>(1, 2, 3, 4, 5);

            string cmd = string.Empty;
            
            while ((cmd = Console.ReadLine()) != "END");
            {

            }
        }
    }
}
