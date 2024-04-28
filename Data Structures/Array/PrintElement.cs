using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Structures.Array
{
    internal class PrintElement
    {
        public void PrintArray(int[] array, int count, string msg)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(msg + array[i]);
            }
        }
        public void PrintValue(int val, string msg)
        {
            Console.WriteLine("{0} Value - {1}", msg, val);
        }
    }
}
