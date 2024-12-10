using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task2
{
    internal static class ArrayExtension
    {
        public static void Add(ref int[] array, int value)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
        }
    }
}
