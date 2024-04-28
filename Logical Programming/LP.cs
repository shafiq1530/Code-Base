using Data_Struct.Data_Structures.LinkedList;

using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;

using Org.BouncyCastle.Bcpg;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Logical_Programming
{
    internal class LP
    {

        #region MATHS PROBLEM

        #region FactorOfNumber
        public static void FactorOfNumber()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sqrt = Convert.ToInt32(Math.Sqrt(n));
            int c = 2;
            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    c = (c == sqrt) ? c + 1 : c + 2;
                }
            }
            Console.WriteLine("Factors count", c);
        }


        #endregion

        #region PrimeNumber
        public static void PrimeNumber()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sqrt = Convert.ToInt32(Math.Sqrt(n));
            int flag = 0;

            //using for loop
            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            //using while loop
            int j = 2;
            while (j <= sqrt)
            {
                if (n % j == 0)
                {
                    flag = 1;
                    break;
                }
                j++;
            };

            if (flag == 0)
                Console.WriteLine("Given number is prime number");

            else
                Console.WriteLine("Given number is not an prime number");

        }
        #endregion


        #region ListOfPrimeNumberBySieveOfEratosthenes
        public static void ListOfPrimeNumberBySieveOfEratosthenes()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            // Create a boolean array 
            // "prime[0..n]" and
            // initialize all entries
            // it as true. A value in
            // prime[i] will finally be 
            // false if i is Not a
            // prime, else true.

            bool[] prime = new bool[n + 1];

            for (int i = 0; i <= n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                // If prime[p] is not changed,
                // then it is a prime
                if (prime[p] == true)
                {
                    // Update all multiples of p
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            // Print all prime numbers
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                    Console.Write(i + " ");
            }
        }
        #endregion


        #region GCD
        internal static void GCD()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());


            int divident = 0;
            int divisor = 0;
            if (a > b)
            {
                divident = a;
                divisor = b;
            }
            else
            {
                divident = b;
                divisor = a;
            }

            while (divisor > 0)
            {
                int remainder = divident % divisor;
                divident = divisor;
                divisor = remainder;

            }
            Console.WriteLine("GCD of a and b {0}", divident);

        }

        #endregion


        #region SearchBinary
        internal static void BinarySearch()
        {
            string str = Console.ReadLine();
            int[] array = str.Split(",").Select(x => Convert.ToInt32(x)).ToArray();

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Returned Index {0}", RecursiveBinarySearch(array, 0, array.Length - 1, x));
        }


        internal static int IterativeBinarySearch(int[] array, int n, int x)
        {
            int l = 0;
            int r = n - 1;

            while (l < r)
            {

                int mid = l + ((r - l) / 2);

                if (array[mid] == x)
                    return mid;

                if (x < array[mid])
                    r = mid - 1;

                else
                    l = mid + 1;


            }

            return -1;

        }

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


        #endregion

        #region LengthOfLastWord
        internal string LengthOfLastWord(string[] _lststr)
        {

            for (int i = _lststr.Length - 1; i >= 0; i--)
            {
                if (!_lststr[i].Equals(""))
                {
                    return _lststr[i];
                }
            }
            return string.Empty;

        }

        #endregion

        #region PlusOne
        internal int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;
        }

        #endregion

        #region AddBinary
        internal string AddBinary()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int[] binnary = new int[12] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048 };
            int a1 = 0;
            int b1 = 0;
            int temp = 0;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                ++temp;

                if (a[i] == '1')
                {
                    a1 += binnary[temp - 1];
                }
            }
            temp = 0;
            for (int i = b.Length - 1; i >= 0; i--)
            {
                ++temp;
                if (b[i] == '1')
                {
                    b1 += binnary[temp - 1];
                }
            }

            return Convert.ToString((a1 + b1), 2);

        }
        #endregion

        #region Sqrt
        internal int Sqrt()
        {


            int x = Convert.ToInt32(Console.ReadLine());
            double original = Math.Sqrt(x);

            int startRange = 0;
            int endRange = x;

            double actualvalue = x;

            if (x == 1 || x == 0)
                return x;

            while (true)
            {
                actualvalue = (startRange + endRange) / 2;


                if (actualvalue * actualvalue == x || (startRange == actualvalue))
                    return Convert.ToInt32(actualvalue);


                else if (actualvalue * actualvalue > x)
                {
                    endRange = (int)actualvalue;
                    continue;

                }


                else
                    startRange = (int)actualvalue;
            }

        }

        #endregion

        #region MyRegion
        static int BinomialCoefficient(int n, int r)
        {
            return FindFactorial(n) / (FindFactorial(r) * FindFactorial(n - r));
        }

        int Findfactorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i < n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;

        }
        #endregion


        #region BinomialExponentiation
        internal static long Power(long A, long B)
        {
            // Base case: A^0 is always 1
            if (B == 0)
                return 1;

            // Recursive calculation of A^(B/2)
            long res = Power(A, B / 2);

            // Multiply the result by itself
            res *= res;

            // If B is odd, multiply by A one more time
            if (B % 2 != 0)
                res *= A;

            return res;
        }
        #endregion


        #region CatalanNumber

        //used to count the number of possible ways

        internal static int CatalanNumber()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n + 2];
            array[0] = array[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                array[i] = 0;
                for (int j = 0; j < i; j++)
                {
                    array[i] = array[i] + (array[j] * array[i - j - 1]);
                }
            }
            return array[n];
        }
        #endregion



        internal static void ListAllPrimeNumber()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            bool[] data = new bool[n];
            for (int i = 0; i < n; i++)
            {
                data[i] = true;
            }
            for (int i = 2; i * i <= n; i++)
            {
                for (int j = i * i; j <= n; j += i)
                {
                    if (data[j] == true)
                    {
                        data[j] = false;
                    }
                }
            }

            for (int p = 2; p < data.Length; p++)
            {
                if (data[p] == true)
                    Console.WriteLine("List of prime numbers  - " + p);
            }

        }

        #endregion

        #region BIT Manupulation

        #region OddEvenWithoutArithmeticOperators
        internal static void OddEvenWithoutArithmeticOperators()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int data = n & 1;
            if (data == 1)
                Console.WriteLine("odd");

            else
                Console.WriteLine("even");


        }

        #endregion

        #region IsPowerOfTwo
        internal static bool IsPowerOfTwo()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
                return false;

            if ((n & (n - 1)) == 0)
                return true;


            return false;
        }
        #endregion

        #region SetBits
        internal static void SetBits()
        {
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());


                //Approach 1 : 
                int count = 0;
                while (n > 1)
                {
                    int prev = n;
                    n = n >> 1;

                    int remainder = prev ^ (n * 2);
                    if (remainder == 1)
                        count++;


                }
                Console.WriteLine("no.of.set bits  of 1" + count);

                //Approach 2 : 
                while (n > 0)
                {
                    n = n & n - 1;
                    count++;
                }
                Console.WriteLine("no.of.set bits  of 1" + count);

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region CountSetBits
        internal static int[] CountSetBits()
        {
            int n = Convert.ToInt32(Console.ReadLine());


            if (n == 0)
                return new int[1] { 0 };

            int[] setbits = new int[n + 1];
            setbits[0] = 0;

            for (int i = 1, j = 0; i <= setbits.Length - 1; i++)
            {

                int count = 0;
                j = i;
                while (j > 0)
                {
                    j = j & j - 1;
                    count++;
                }

                setbits[i] = count;
            }


            return setbits;
        }
        #endregion

        #region SumOfTwoNumber
        internal static int SumOfTwoNumber(int A, int B)
        {

            while (B != 0)
            {
                int carry = A & B;
                A = A ^ B;
                B = carry << 1;
            }
            return A;
        }

        #endregion

        #region SubSets
        internal static void SubSets()
        {
            int[] nums = Console.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();

            int counter, j;
            int set_size = nums.Length;

            int pow_set_size = (int)Math.Pow(2, nums.Length);

            for (counter = 0; counter <
                   pow_set_size; counter++)
            {
                for (j = 0; j < set_size; j++)
                {
                    /* Check if jth bit in the  
                    counter is set If set then  
                    print jth element from set */
                    if ((counter & (1 << j)) > 0)
                        Console.Write(nums[j]);
                }

                Console.WriteLine();
            }


        }

        #endregion

        #region SingleNumber
        internal static int SingleNumber()
        {

            int[] nums = Console.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            int result = 0;


            foreach (int num in nums)
            {
                result ^= num;
            }
            return result;

            Array.Sort(nums);
            if (nums.Length == 1)
                return nums[0];

            int i = 0;
            while (i < nums.Length)
            {

                if (i >= nums.Length - 1)
                    return nums[i];

                if ((nums[i] ^ nums[i + 1]) == 0)
                    i = i + 2;

                else
                {
                    result = nums[i];
                    i = i + 1;

                }

            }

            return result;

        }

        #endregion

        #endregion

        internal int ClimbingStairs()
        {

            Console.WriteLine("Please enter number of steps");
            int steps = Convert.ToInt32(Console.ReadLine());


            return GetFibonancieSeriesValue(steps) + GetFibonancieSeriesValue(steps - 1);


        }

        internal static int nCr(int n, int r)
        {
            // n!\r!(n-r)!;


            double sum = 1;
            // Calculate the value of n choose r using the binomial coefficient formula
            for (int i = 1; i <= r; i++)
            {
                sum = sum * (n - r + i) / i;
            }

            decimal divdent = FindFactorial(n);
            decimal divisor = FindFactorial(r) * FindFactorial(n - r);
            decimal data = divdent / divisor;
            return Convert.ToInt32((divdent / divisor) % 1000000007);
        }

        internal static int FindFactorial(int n)
        {
            int factorial = 1;

            for (int i = 2; i <= n; i++)
                factorial = factorial * i;

            //while (n > 1)
            //{
            //    factorial *= (n * (n - 1));
            //    n = n - 2;
            //}
            return factorial;
        }
            
        int GetFibonancieSeriesValue(int n)
        {

            if (n == 0 || n == 1)
                return n;

            var data = GetFibonancieSeriesValue(n - 1) + GetFibonancieSeriesValue(n - 2);



            return data;
        }

        internal static int[] SortArray(int[] a)
        {

            if (a.Length > 0)
            {
                int temp = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] > a[j])
                        {
                            //using third variable  = swapping method 

                            //temp = a[i];
                            //a[i] = a[j];
                            //a[j] = temp;


                            //Using without third variable 
                            //a = b-a
                            //b = b-a
                            //a = a+b

                            a[i] = a[j] - a[i];
                            a[j] = a[j] - a[i];
                            a[i] = a[i] + a[j];

                        }
                    }
                }

            }
            return a;

        }

        internal static void RemoveDuplicateFromArray()
        {
            string str = Console.ReadLine();

            int[] a = str.Split(",").Select(x => Convert.ToInt32(x)).ToArray();


            if (a.Length > 0)
            {
                int temp = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == 0 && a[j] == 0)
                            break;

                        if (a[i] == a[j])
                        {
                            temp += 1;

                            a[j] = a[a.Length - temp];
                            a[a.Length - temp] = 0;
                        }
                    }
                }

                int[] output = new int[a.Length - temp];
                Array.Copy(a, output, a.Length - temp);
                SortArray(output);

                foreach (var item in output)
                {
                    Console.WriteLine("After Removed Duplicate from   Array :" + item);
                }
            }

        }

        #region RemoveDuplicateFromLinkedList

        internal static void RemoveDuplicateFromLinkedList(SingleLinkedList list)
        {
            var temp = list.head;

            int currentdata = temp.data;
            while (temp.next != null)
            {
                if (currentdata == temp.next.data)
                {
                    temp.next = temp.next.next;
                }
                else if (temp.next.data > currentdata)
                    currentdata = temp.next.data;

                else
                    temp.next = temp.next;
            }
        }


        #endregion

    }
}
