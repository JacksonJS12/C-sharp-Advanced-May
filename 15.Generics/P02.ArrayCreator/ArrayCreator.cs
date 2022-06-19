using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator<T>
    {
        public static T[] Create<T>(int length, T item)
        {
            var result = new T[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = item;
            }

            return result;
        }

    }
}
