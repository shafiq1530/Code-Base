using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using Data_Struct.Data_Structures.Array;
using Data_Struct.Data_Structures.LinkedList;
using Data_Struct.Logical_Programming;
using System.Runtime.InteropServices;

namespace Data_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //SearchElemenInArray searchElemenInArray = new SearchElemenInArray();
                SortArrayElement sortArrayElement = new SortArrayElement();
                int exit = 0;
                while (exit == 0)
                {
                    Console.WriteLine("Enter numbers for an array size");
                    int size = Convert.ToInt32(Console.ReadLine());
                    int[] array = new int[size];

                    Random random = new Random();
                    for (int i = 0; i < size; i++)
                    {
                        array[i] = random.Next(1, 100);
                    }


                    for (int i = 1; i < array.Length; i++)
                    {
                        sortArrayElement.SelectionSort(array);
                    }





                    sortArrayElement.PrintArray(array, array.Length, "After Sort Element From Array");

                    Console.WriteLine("Do you want to continue ? (y/n)");

                    string label = Console.ReadLine();
                    exit = label.ToLower() == "y" ? exit : exit + 1;

                }


                Console.WriteLine("Thank You...:)");
                //int val = searchElemenInArray.BinarySearchElementInArray(str, Convert.ToInt16(Console.ReadLine()));

                //searchElemenInArray.PrintValue(val, "Returned Value");
                //DeleteElementFromArray deleteElementPosition = new DeleteElementFromArray();
                //deleteElementPosition.DeleteElementPosition(str, 1, ref count);

                //InsertElementInArray insertElementInArray = new InsertElementInArray();
                //insertElementInArray.PrintArray(str, count, "Before insert Element From Array");

                //insertElementInArray.InsertElementAtFirst(str, 20);
                //insertElementInArray.PrintArray(str, count, "After insert Element From Array");



                Console.ReadKey();
            }
            catch (Exception ex)
            {

                throw ex;
            }



            //http://192.168.1.219/Windchill/ext/srinsoft/SSTWGM/



            //string[] str = Console.ReadLine().Split(",");
            //SingleLinkedList list = new SingleLinkedList();
            //for (int i = 0; i < str.Length; i++)
            //    SingleLinkedList.InsertEnd(list, Convert.ToInt16(str[i]));

            //LP.RemoveDuplicateFromLinkedList(list);

            //SingleLinkedList.ReverseLinkedList(list);

            //LP.SumOfTwoNumber(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));


            LeftPyramidStar();
            LP.SingleNumber();


            Console.ReadKey();

        }

        static void RightPyramidStar()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");

            }
        }

        static void LeftPyramidStar()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i - 1; j++)
                {
                    Console.Write(" ");

                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");

                    }
                }
                Console.WriteLine(value: "");
            }
        }
    }



}