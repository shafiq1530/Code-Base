using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Structures.Array
{
    internal class LeadersInAnArray
    {
        public static List<int> PrintLeaders(int[] array)
        {
            List<int> ints = new List<int>();
            int max = array[array.Length - 1];
            ints.Add(max);
            for (int i = array.Length-1;  i >= 0; i--)
            {
                if (array[i] > max)
                {
                    ints.Add(array[i]);
                    max = array[i];

                }
            }

            return ints;

        }
    }
}
