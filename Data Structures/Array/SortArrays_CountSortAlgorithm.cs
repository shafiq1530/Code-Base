using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Structures.Array
{
    internal class SortArrays_CountSortAlgorithm
    {
        public static void SortArrays(int[] array)
        {
            int count0fZero = 0;
            int count0fOne = 0;
            int count0fTwo = 0;

            for (int i = 0; i < array.Length; i++)
            {
                switch (array[i])
                {
                    case 0:
                        count0fZero++;
                        break;
                    case 1:
                        count0fOne++;
                        break;
                    case 2:
                        count0fTwo++;
                        break;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (count0fZero > 0)
                {
                    array[i] = 0;
                    count0fZero--;
                }
                else if (count0fOne > 0)
                {
                    array[i] = 1;
                    count0fOne--;

                }
                else if (count0fTwo > 0)
                {
                    array[i] = 2;
                    count0fTwo--;
                }
            }


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Sorted Array : " + array[i]);
            }
        }
    }
}
