using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Structures.Array
{
    internal class SortArrayElement : PrintElement
    {/// <summary>
     /// first loop run n times 
     /// second loop run n times 
     /// Time complexity is O(n^2)
     /// Worst case 
     /// if data n =  1000 loop run 1000 * 1000 = 10000

     /// </summary>
     /// <param name="array"></param>
        public void BubbleSortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                //for ascending order 
                //for (int j = i + 1; j < array.Length; j++)
                //{
                //    if (array[i] > array[j])
                //    {
                //        array[i] = array[j] - array[i];
                //        array[j] = array[j] - array[i];
                //        array[i] = array[j] + array[i];
                //    }
                //}


                //// for ascending order 
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        array[i] = array[j] - array[i];
                        array[j] = array[j] - array[i];
                        array[i] = array[j] + array[i];
                    }
                }

                //for descending order
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j + 1] > array[j])
                    {
                        array[j] = array[j + 1] - array[j];
                        array[j + 1] = array[j + 1] - array[j];
                        array[j] = array[j + 1] + array[j];
                    }
                }
            }
        }

        public void InsertionSort(int[] array, int val, int index)
        {
            if (array.Length < 1)
                return;

            if (array[index - 1] > val)
            {
                int key = val;
                array[index] = array[index - 1];
                array[index - 1] = key;

                if (index - 1 > 0)
                    InsertionSort(array, key, index - 1);
            }
            else
                array[index] = val;
        }

        public void SelectionSort(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                int min = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        array[j] = array[i];
                        array[i] = min;
                    }
                }
            }
        }

        public void MergerSort(int[] array)
        {
            [4,3,2,1]

            int l = 0;
            int r = array.Length;
            int mid = l + r / 2;

            int[] leftArray = new int[mid];

            for (int i = 0; i < mid; i++)
            {
                leftArray[i] = array[i];
            }
            if (mid == 0)
            {

            }

            MergerSort(leftArray);

            int[] rightArray = new int[mid];

            for (int j = mid; j < r; j++)
            {
                rightArray[j] = array[j];
            }
            for (int i = l + 1;)
                MergerSort(leftArray);

        }

        private void MergeSortedArrayIntoOriginalArray(int[] left, int[] right, int[] parent)
        {
            int i = 0; int j = 0; int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    parent[k] = left[i];
                    i++; k++;
                }
                else
                {
                    parent[k] = right[j];
                    j++; k++;
                }
            }
            while (i < left.Length)
            {
                parent[k] = left[i];
                i++; k++;
            }
            while (j < right.Length)
            {
                parent[k] = right[j];
                j++; k++;
            }

        }

    }
}
