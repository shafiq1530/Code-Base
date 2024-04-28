using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Structures.Array
{
    internal class DeleteElementFromArray : PrintElement
    {

        public void DeleteElementFromEnd(int[] a, ref int count)
        {
            if (a.Length == 0)
                Console.WriteLine("Array doesn't exist");

            count--;
        }

        public void DeleteElementValue(int[] a, int val, ref int count)
        {
            if (a.Length == 0)
                Console.WriteLine("Array doesn't exist");


            int i = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (val == a[i])
                    break;
                else
                    Console.WriteLine("Value doesn't exist in Array");
            }

            for (int j = i; j < a.Length; j++)
            {
                a[j] = a[j + 1];
            }

            count--;
        }


        public void DeleteElementPosition(int[] a, int position, ref int count)
        {
            if (a.Length == 0)
                Console.WriteLine("Array doesn't exist");


            if (position > a.Length - 1 && position < 0)
                Console.WriteLine("Position doesn't exist");

            for (int i = position; i < a.Length-1; i++)
            {
                a[i] = a[i + 1];
            }

            count--;
        }

    }
}
