using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace support_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("num 1= ");
            string x = Console.ReadLine();
            if (int.TryParse(x, out int num))
            even(num);
            Console.Write("num 2 = ");
            string y = Console.ReadLine();
            if (int.TryParse(y, out int num2))
            maxnum(num, num2);
            numstate(num);*/

            //Column Sum: Print the sum of each column in a 2D array
            int[,] matrix = 
                {
                {1,2},
                {3,4},
                {5,6}
            };
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            /*for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine($"Sum of column {col}: {sum}");
            }*/

            //Transpose Matrix: Print the transpose of a 2D array
            for (int col = 0; col < cols; col++)
            {
                
                for (int row = 0; row < rows; row++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
        }
        static void even(int x) //Even or Odd: Write a program that takes an integer and prints whether it’s even or odd
        {
            /*if (x % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }*/
            //use of ternary operator (shortcut of the above) 
            Console.WriteLine(x % 2 == 0 ? "Even" : "Odd");
        }
        static void maxnum(int x, int y) //Maximum of Two: Take two numbers as input and print the larger one.
        {
            /*if (x > y)
            {
                Console.WriteLine("max is" + x);
            }
            else
            {
                Console.WriteLine("max is" + y);
            }*/

            Console.WriteLine(x > y ? "max num is " + x : "max num is " + y);
        }
        static void numstate(int x) //Positive, Negative, or Zero: Check whether a number is positive, negative, or zero.
        {
            if(x > 0)
            {
                Console.WriteLine($"number is Positive");
            }
            else if (x < 0)
            {
                Console.WriteLine($"number is Negative");
            }
            else
            {
                Console.WriteLine($"number is Zero");
            }
        }
    }
}
