using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Reverse an Array");
            q1();
            Console.WriteLine("2. Find Second Largest Element");
            q2();
            Console.WriteLine("3.Count Even and Odd Numbers");
            q3();
            Console.WriteLine("4.Rotate Array to the Right");
            q4();
            Console.WriteLine("5.Check if Array is Sorted");
            q5();
            Console.WriteLine("6.Find Row with Maximum Sum (2D Array)");
            q6();
            Console.WriteLine("7.Transpose a Matrix(2D Array)");
            q7();
            Console.WriteLine("8.Find Duplicate Elements in Array)");
            q8();
            Console.WriteLine("9. Pascal’s Triangle (2D Array))");
            q9();
            Console.WriteLine("10. Snake Pattern Matrix (2D Array))");
            q10();

        }
        #region MyHelpFun
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
                    Console.Write($" index {i+1} = ");
                    if (int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid, try again");
                }

            }
        }
        static void Fill2DArray_int(int[,] arr, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    while (true)
                    {
                        Console.Write($"Index[{i}:{j}] = ");
                        if (int.TryParse(Console.ReadLine(), out arr[i, j]))
                        {
                            break;
                        }
                        Console.WriteLine("Invalid Input..Enter Number ");
                    }
                }
            }
        }
        static void Print1DArray(int[] arr)
        {
            Console.WriteLine("Array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Index {i+1}: {arr[i]}");
            }

        }
        static void Print2DArray(int[,] arr, int rows, int cols)
        {
            Console.WriteLine("Array : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static int int_Check()
        {
            int x;
            while (true)
            {
                Console.Write("Enter: ");
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
            }
        }
        static int[,] TransposeMatrix(int[,] mat)
        {
            int Rows = mat.GetLength(0);
            int Cols = mat.GetLength(1);
            int[,] transposedMatrix = new int[Cols, Rows];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    transposedMatrix[j, i] = mat[i, j];
                }
            }
            return transposedMatrix;
        }
        static void PrintSnakePattern(int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) // even row → left to right
                {
                    for (int j = 0; j < m; j++)
                        Console.Write(matrix[i, j] + " ");
                }
                else // odd row → right to left
                {
                    for (int j = m - 1; j >= 0; j--)
                        Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
        #endregion
        #region MyRegion
        static void q1()
        {
            int lenght = arrlenght1d();
            int[] arr = new int[lenght];
            FillArray1d(arr);
            Print1DArray(arr);
            //reverse
            Console.WriteLine("Array in reverse order:");
            for (int i = arr.Length - 1; i >= 0; i--) //sub - 1 from the length of the array to match index based(0)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void q2()
        {
            int lenght = arrlenght1d();
            int[] arr = new int[lenght];
            FillArray1d(arr);
            Print1DArray(arr);
            int largest = int.MinValue;
            int seclargest = int.MinValue;
            foreach (var num in arr)
            {

                if (num > largest)
                {

                    seclargest = largest;
                    largest = num;
                }
                else if (num > seclargest && num < largest)
                {
                    seclargest = num;
                }
            }
            Console.WriteLine("the second largest number = " + seclargest);
        }
        static void q3()
        {
            int size = arrlenght1d();
            int[] arr = new int[size];
            FillArray1d(arr);
            Print1DArray(arr);
            //make counters
            int evenindex = 0, oddindex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenindex++;
                }
                else
                {
                    oddindex++;
                }
            }
            Console.WriteLine($"number of even numbers = {evenindex}");
            Console.WriteLine($"number of odd numbers = {oddindex}");
        }
        static void q4()
        {
            int lenght = arrlenght1d();
            int[] arr = new int[lenght];
            FillArray1d(arr);
            Print1DArray(arr);
            //Rotate an array k steps to the right
            Console.WriteLine($"Enter K steps to the right  : ");
            int k = int_Check();
            Console.WriteLine($"Array with {k} steps to the right  : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Index {i + 1}: {arr[i]+k}");
            }
        }
        static void q5()
        {
            int size = arrlenght1d();
            int[] arr = new int[size];
            FillArray1d(arr);
            if(arr == null || arr.Length <= 1)
            {
                Console.WriteLine("Sorted Array");
            }
            else
            {
                bool issorted = true;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        issorted = false;
                        break;
                    }
                }
                if (issorted)
                {
                    Console.WriteLine("Sorted Array");
                }
                else
                {
                    Console.WriteLine("Is not a Sorted Array");

                }
            }
        }
        static void q6()
        {
            int rows, cols;
            Console.Write("Enter numbe of rows: ");
            int.TryParse(Console.ReadLine(), out rows);
            Console.Write("Enter numbe of cols: ");
            int.TryParse(Console.ReadLine(), out cols);
            int[,] arr2d = new int[rows, cols];
            Fill2DArray_int(arr2d, rows, cols);
            Print2DArray(arr2d, arr2d.GetLength(0), arr2d.GetLength(1));
            //Use nested loops to calculate the sum of each row
            int maxSum = int.MinValue;
            int largestRowIndex = -1;
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                int currentSum = 0; 
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    currentSum += arr2d[i, j];
                }
                Console.WriteLine($"Sum of row {i + 1} = {currentSum}");
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;     
                    largestRowIndex = i+1;
                }
            }
            Console.WriteLine($"Row that has the maximum sum of elements is row : {largestRowIndex}");
        }
        static void q7()
        {
            int rows, cols;
            Console.Write("Enter numbe of rows: ");
            int.TryParse(Console.ReadLine(), out rows);
            Console.Write("Enter numbe of cols: ");
            int.TryParse(Console.ReadLine(), out cols);
            int[,] arr2d = new int[rows, cols];
            Fill2DArray_int(arr2d, rows, cols);
            Print2DArray(arr2d, arr2d.GetLength(0), arr2d.GetLength(1));
            int[,] transposearr = TransposeMatrix(arr2d);
            Print2DArray(transposearr, transposearr.GetLength(0), transposearr.GetLength(1));
        }
        static void q8()
        {
            int size = arrlenght1d();
            int[] arr = new int[size];
            FillArray1d(arr);
            // Sort in ascending order
            Array.Sort(arr);
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count++;
                    Console.WriteLine(arr[i] + " ");
                }
            }
            Console.WriteLine("Total number of duplicate = " + count);
        }
        static void q9()
        {
            Console.Write("Enter number of rows (n): ");
            int n = int_Check();
            int[,] triangle = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                triangle[i, 0] = 1;
                triangle[i, i] = 1;
                for (int j = 1; j < i; j++)
                {
                    triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
                }
            }
            // Print
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', (n - i - 1) * 2));
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(triangle[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
        static void q10()
        {
            int rows, cols;
            Console.Write("Enter numbe of rows: ");
            int.TryParse(Console.ReadLine(), out rows);
            Console.Write("Enter numbe of cols: ");
            int.TryParse(Console.ReadLine(), out cols);
            int[,] arr2d = new int[rows, cols];
            Fill2DArray_int(arr2d, rows, cols);
            Print2DArray(arr2d, arr2d.GetLength(0), arr2d.GetLength(1));
            PrintSnakePattern(arr2d, arr2d.GetLength(0), arr2d.GetLength(1));
        }
        #endregion
    }

}
