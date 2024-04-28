using System;

namespace Data_Struct.Data_Structures.Array
{
    internal class InsertElementInArray : PrintElement
    {
        public void InsertElementAtFirst(int[] array, int val)
        {
            //Method 1 : By reverse an array
            //for (int i = array.Length - 1; i > 0; i--)
            //{
            //    array[i] = array[i - 1];
            //}

            //Method 2: By iterate an array
            for (int i = 1; i < array.Length - 1; i++)
            {
                
                    array[i] = array[i + 1];

            }


            array[0] = val;
        }

        public void InsertElementAtMid(int[] array, int position, int val)
        {
            for (int i = array.Length - 1; i > position; i--)
            {
                array[i] = array[i - 1];
            }
            array[position] = val;

        }
        public void InsertElementAtEnd(int[] array, int val)
        {
            array[array.Length - 1] = val;
        }
    }
}
