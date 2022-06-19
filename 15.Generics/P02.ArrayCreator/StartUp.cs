using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var arrayCreator = ArrayCreator<int>.Create(100, 6);
        }
    }
}
