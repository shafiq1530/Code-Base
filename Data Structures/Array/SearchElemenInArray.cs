using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Structures.Array
{
    internal class SearchElemenInArray : PrintElement
    {
        /// <summary>
        /// Searches the element in array.
        /// Method 1 : Brute force
        /// Time Complexity : O(n)
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="val">The value.</param>
        /// <returns> Index position </returns>
        public int SearchElementInArray(int[] array, int val)
        {
            if (array.Length == 0)
                return -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                    return i;
            }
            return -1;
        }
        /// <summary>
        /// Search element in array using binary search
        /// Time Complexity : O(logn)
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        public int BinarySearchElementInArray(int[] array, int val)
        {
            int l = 0;
            int r = array.Length - 1;
            int mid = 0;

            while (l <= r)
            {
                mid = l + (r - l) / 2;
                if (array[mid] == val)
                    return mid;

                else if (val > array[mid])
                    l = mid + 1;

                else
                    r = mid - 1;


            }
            return -1;
        }

        /// <summary>
        /// Recursives the binary search.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="l">The l.</param>
        /// <param name="r">The r.</param>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        internal static int RecursiveBinarySearch(int[] array, int l, int r, int x)
        {
            int mid = l + ((r - l) / 2);

            if (array[mid] == x)
                return mid;

            if (x < array[mid])
                RecursiveBinarySearch(array, l, mid - 1, x);

            else
                RecursiveBinarySearch(array, mid + 1, r, x);


            return -1;
        }

    }
}
