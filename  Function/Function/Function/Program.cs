using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1. Reverse an Array");
            t1();
            Console.WriteLine("Q2. Find Second Largest Number");
            t2();
            Console.WriteLine("Q3. Count Numbers Greater than Average");
            t3();
            Console.WriteLine("Q4. Palindrome Checker (Array Version)");
            t4();
            Console.WriteLine("Q5. Merge Two Arrays (No Duplicates)");
            t5();
        }
        #region MyRegion

        static int arrlenght1d()
        {
            int lenght;
            //protect
            while (true)
            {
                //Ask for lengh
                Console.Write("Array length = ");
                if (int.TryParse(Console.ReadLine(), out lenght) && lenght > 0)
                {
                    break;//valid input
                }
                Console.WriteLine("Invalid, try again");
            }
            return lenght;
        }
        static void FillArray1d(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                while (true)
                {
                    Console.Write($" index {i} = ");
                    if (int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid, try again");
                }

            }
        }
        static bool IsPalindrome(int[] arr)
        {
            if (arr == null || arr.Length < 1)
            {
                return true;
            }
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] != arr[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        static int[] merge(int[] arr1,int[] arr2)
        {
            List<int> merged = new List<int>();
            //add from arr 1
            foreach (var num in arr1)
            {
                if (!merged.Contains(num))
                {
                    merged.Add(num);
                }
            }
            //add from arr 2
            foreach (var num in arr2)
            {
                if (!merged.Contains(num))
                {
                    merged.Add(num);
                }
            }
            //list to array
            return merged.ToArray();

        }


        #endregion
        static void t1()
        {
            int size = arrlenght1d();
            //create array
            int[] arr = new int[size];
            //fill array
            FillArray1d(arr); //check code in MyHelp fun region
            //reverse
            Console.WriteLine("Array in reverse order:");
            for (int i = arr.Length - 1; i >= 0; i--) //sub - 1 from the length of the array to match index based(0)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void t2()
        {
            int size;
            while (true)
            {
                Console.Write("Array length = ");
                if (int.TryParse(Console.ReadLine(), out size) && size >= 2)
                {
                    break;
                }
                Console.WriteLine("Invalid. Please enter a number >= 2.");
            }
            int[] arr = new int[size];
            FillArray1d(arr);
            int largest = 0;
            int seclargest = 0;
            foreach (var num in arr)
            {
                
                if (num > largest)
                {
                    seclargest = largest;
                    largest = num;
                }
                else if (num < largest && num > seclargest)
                {
                    seclargest = num;
                }
            }
            Console.WriteLine("the second largest number = " + seclargest);
        }
        static void t3()
        {
            int lenght;
            //protect
            while (true)
            {
                //Ask for lengh
                Console.Write("Array length = ");
                if (int.TryParse(Console.ReadLine(), out lenght) && lenght > 0)
                {
                    break;//valid input
                }
                Console.WriteLine("Invalid number, try again");
            }
            //create array
            double[] arr = new double[lenght];
            //Get numbers

            for (int i = 0; i < arr.Length; i++)
            {
                while (true)
                {
                    Console.Write($" index {i} = ");
                    if (double.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid number, try again");
                }

            }
            double sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }
            double avg = sum / arr.Length;
            //round
            avg = Math.Round(avg, 2);
            Console.WriteLine("Average = " + avg);
            //count
            int count = 0;
            foreach (var num in arr)
            {
                if (num > avg)
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} Numbers greater than average");
            //print numbers
            Console.Write("Numbers greater than average: {");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>avg)
                {
                    Console.Write(arr[i]+ ", ");
                    
                }
            }
            Console.WriteLine("}");
        }
        static void t4()
        {
            int length = arrlenght1d();
            int[] arr = new int[length];
            FillArray1d(arr);
            //check Palindrome
            
            Console.WriteLine(IsPalindrome(arr));
        }

        static void t5()
        {
            //arr1
            int size1 = arrlenght1d();
            int[] arr1 = new int[size1];
            FillArray1d(arr1);
            //arr2
            int size2 = arrlenght1d();
            int[] arr2 = new int[size2];
            FillArray1d(arr2);
            //merge
            int[] mergedarr = merge(arr1, arr2);
            //print
            Console.WriteLine("Mergerd Array: ");
            Console.Write("{");
            for (int i = 0; i < mergedarr.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(mergedarr[i]);
            }
            Console.WriteLine("}");
        }
    }
}
