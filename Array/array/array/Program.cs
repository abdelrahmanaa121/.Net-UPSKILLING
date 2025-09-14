using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Task 1: Count Even and Odd Numbers");
            //t1();
            //Console.Write("Task 2: Find the Maximum and Minimum");
            //t2();
            //Console.Write("Task 3: Sum of Each Row in a 2D Array");
            //t3();
            //Console.Write("Task 4: Search for a Number");
            //t4();
            //Console.Write("Task 5: Diagonal Elements of a 2D Array");
            t5();
        }
        #region MyHelpFun
        static int ArrLenght()
        {
            int lenght;
            while (true)
            {
                Console.Write("Enter Array Size: ");
                if (int.TryParse(Console.ReadLine(), out lenght) && lenght > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid Input..Please enter positve number");
            }
            return lenght;
        }
        static void ArrayFill_int(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                while (true)
                {
                    Console.Write($"index {i} : ");
                    if (int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        static void Array2DFill_int(int[,] arr,int rows,int cols)
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


        #endregion
        static void t1()
        {
            //Size
            int size = ArrLenght();
            //Define Array
            int[] arr = new int[size];
            //Fill array Elemnts
            ArrayFill_int(arr);
            //Use a loop to count how many numbers are **even** and how many are **odd**.
            int even = 0;
            int odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            //print
            Console.WriteLine($"Even : {even} numbers & Odd : {odd} numbers");

        }
        static void t2()
        {
            int size = ArrLenght();
            int[] arr = new int[size];
            ArrayFill_int(arr);
            //Use a loop and if-conditions to find the **maximum** and **minimum** number
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Max number is : {max} & Min number is : {min}");
        }
        static void t3()
        {
            int rows, cols;
            Console.Write("Enter numbe of rows: ");
            int.TryParse(Console.ReadLine(),out rows);
            Console.Write("Enter numbe of cols: ");
            int.TryParse(Console.ReadLine(), out cols);
            int[,] arr2d = new int[rows,cols];
            
            //fill 2d array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    while (true)
                    {
                        Console.Write($"Index[{i}:{j}] = ");
                        if (int.TryParse(Console.ReadLine(), out arr2d[i, j]))
                        {
                            break;
                        }
                        Console.WriteLine("Invalid Input..Enter Number ");
                    }
                }
            }
            //print 2dArray
            Console.WriteLine("Array : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr2d[i, j]+"\t");
                }
                Console.WriteLine();
            }
            //Use nested loops to calculate the sum of each row
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += arr2d[i, j];
                }
                Console.WriteLine($"Sum of row {i+1} = {sum}");
            }
            
        }

        static void t4()
        {
            int length = ArrLenght();
            int[] arr = new int[length];
            ArrayFill_int(arr);
            Console.Write("Enter number to search: ");
            int.TryParse(Console.ReadLine(), out int x);

            //search
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                {
                    Console.WriteLine($"Number found at index[{i}]");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Number not found");
            }
            
        }
        static void t5()
        {
            int MatSize;
            Console.Write("Enter Matrix Size: ");
            int.TryParse(Console.ReadLine(), out MatSize);
            int[,] arr = new int[MatSize, MatSize];
            Array2DFill_int(arr,MatSize,MatSize);
            Print2DArray(arr, MatSize, MatSize);
            //Diagonal Elements of a 2D Array
            Console.WriteLine("Diagonal Elements: ");
            for (int i = 0; i < MatSize; i++)
            {
                Console.Write(arr[i,i]);
                if (i<MatSize-1)
                {
                    Console.Write(", ");
                }
                
            }
            
        }



    }
}
