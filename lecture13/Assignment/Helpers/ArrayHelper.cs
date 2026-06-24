using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Helpers
{
    internal class ArrayHelper
    {
        public static void Add<T>(ref T[] arraylist, T newitem)
        {
            int index = arraylist.Length;

            Array.Resize(ref arraylist, index + 1);

            arraylist[index] = newitem;
        }

        public static void Remove<T>(ref T[] arraylist, int removeIndex)
        {
            for (int i = removeIndex; i < arraylist.Length - 1; i++)
            {
                arraylist[i] = arraylist[i + 1];  // shift left
            }
            Array.Resize(ref arraylist, arraylist.Length - 1);
        }
    }
}
