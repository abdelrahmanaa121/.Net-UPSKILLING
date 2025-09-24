using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace support_task
{
    public enum Day
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public enum traffic
    {
        Red,
        Yellow,
        Green
    }
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public struct student
    {
        public string Name;
        public int Age;
        public double Grade;
    }
    public struct point
    {
        public double x;
        public double y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n (1) Problems on if conditions: ");
            Console.WriteLine("1. Even or Odd.");
            q1();
            Console.WriteLine("2. Maximum of Two: Take two numbers as input and print the larger one");
            q2();
            Console.WriteLine("3. Positive, Negative, or Zero: Check whether a number is positive, negative, or zero.");
            q3();
            Console.WriteLine("4. Leap Year: Check if a given year is a leap year.");
            q4();
            Console.WriteLine("5. Grade Calculator: Take a student’s score and print the grade (A, B, C, D, F)");
            q5();
            Console.WriteLine("\n (2) Problems on for loops + 1D arrays: ");
            Console.WriteLine("6. Sum of Array Elements: Find the sum of elements in a 1D array.");
            q6();
            Console.WriteLine("7. Find Maximum in Array: Given an array, find the largest number.");
            q7();
            Console.WriteLine("Reverse Array: Print an array in reverse order.");
            q8();
            Console.WriteLine("Count Even Numbers: Count how many even numbers exist in an array.");
            q9();
            Console.WriteLine("Linear Search: Search for a given number in an array and print its index (or -1 if not found)");
            q10();
            Console.WriteLine("\n (3) Problems on 2D arrays: ");
            Console.WriteLine("11. Matrix Sum: Find the sum of all elements in a 2D array.");
            q11();
            Console.WriteLine("12. Row Sum: Print the sum of each row in a 2D array.");
            q12();
            Console.WriteLine("13. Column Sum: Print the sum of each column in a 2D array.");
            q13();
            Console.WriteLine("14. Transpose Matrix: Print the transpose of a 2D array.");
            q14();
            Console.WriteLine("Find Maximum in Matrix: Find the largest number in a 2D array.");
            q15();
            Console.WriteLine("\n (4)  Problems on enum: ");
            Console.WriteLine("16. Days of the Week: Create an enum for days of the week, and print whether a given day is a weekend or weekday.");
            q16();
            Console.WriteLine("17. Traffic Light: Create an enum for traffic light colors (Red, Yellow, Green). Print the action for each color.");
            q17();
            Console.WriteLine("18. Seasons: Create an enum for seasons. Print a message depending on which season is chosen.");
            q18();
            Console.WriteLine("\n (5)  Problems on struct: ");
            Console.WriteLine("19. Student Struct: Create a struct for Student with properties Name, Age, and Grade. Initialize and display student data.");
            q19();
            Console.WriteLine("20. Point Struct: Create a struct Point with x and y. Write a function to calculate the distance between two points.");
            q20();
        }

        #region MyRegion
        static int int_Check()
        {
            int x;
            while (true)
            {
                Console.Write("Enter: ");
                if (int.TryParse(Console.ReadLine(),out x))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
            }
        }
        static double double_Check()
        {
            double x;
            while (true)
            {
                Console.Write("Enter: ");
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
            }
        }
        static void even(int x) //Even or Odd: Write a program that takes an integer and prints whether it’s even or odd
        {
            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}
            //use of ternary operator (shortcut of the above) 
            Console.WriteLine(x % 2 == 0 ? "Even" : "Odd");
        }
        static void maxnum(int x, int y) //Maximum of Two: Take two numbers as input and print the larger one.
        {
            Console.WriteLine(x > y ? "max num is " + x : "max num is " + y);
        }
        static void numstate(int x) //Positive, Negative, or Zero: Check whether a number is positive, negative, or zero.
        {
            if (x > 0)
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
        static bool Isleapyear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        static char Getgrade(double grade)
        {
            if (grade >= 90)
            {
                return 'A';
            }
            else if (grade >= 80)
            {
                return 'B';
            }
            else if (grade >= 70)
            {
                return 'C';
            }
            else if (grade >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

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
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Array2DFill_int(int[,] arr, int rows, int cols)
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
        static void CheckDay(Day day)
        {
            switch (day)
            {
                case Day.Saturday:
                case Day.Sunday:
                    Console.WriteLine($"{day} is a weekend");
                    break;

                default:
                    Console.WriteLine($"{day} is a weekday");
                    break;
            }
        }
        public static void traficaction(traffic color)
        {
            switch (color)
            {
                case traffic.Red:
                    Console.WriteLine("Stop");
                    break;
                case traffic.Yellow:
                    Console.WriteLine("Prepare to stop");
                    break;
                case traffic.Green:
                    Console.WriteLine("Go");
                    break;
                default:
                    Console.WriteLine("Invalid light color");
                    break;
            }
        }
        public static void SeasonMessage(Season season)
        {
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("lets buy flowers");
                    break;
                case Season.Summer:
                    Console.WriteLine("lets go to beach");
                    break;
                case Season.Autumn:
                    Console.WriteLine("leaves changing color");
                    break;
                case Season.Winter:
                    Console.WriteLine("winter is coming");
                    break;
            }
        }
        static double Distance(point p1,point p2)
        {
            double dx = p2.x - p1.x;
            double dy = p2.y - p1.y;
            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));

        }
        
        #endregion
        #region AssRegion
        static void q1()
        {
            int x = int_Check();
            even(x);
        }
        static void q2()
        {
            int x = int_Check();
            int y = int_Check();
            maxnum(x, y);
        }
        static void q3()
        {
            int x = int_Check();
            numstate(x);
        }
        static void q4()
        {
            int year = int_Check();
            Console.WriteLine(Isleapyear(year));
        }
        static void q5()
        {
            double grade = double_Check();
            if (grade > 0 && grade < 100)
            {
                Console.WriteLine($"The Grade for {grade} is {Getgrade(grade)}");
            }
            else
            {
                Console.WriteLine("Enter grade between 0 and 100");
            }
        }
        static void q6()
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
            sum = Math.Round(sum, 2);
            Console.WriteLine("Sum = " + sum);
        }
        static void q7()
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
            foreach (var num in arr)
            {

                if (num > largest)
                {
                    
                    largest = num;
                }
            }
            Console.WriteLine("the largest number = " + largest);
        }
        static void q8()
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
        static void q9()
        {
            int size = arrlenght1d();
            int[] arr = new int[size];
            FillArray1d(arr);
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
            Console.WriteLine($"number if even numbers = {evenindex}");
        }
        static void q10()
        {
            int size = arrlenght1d();
            int[] arr = new int[size];
            FillArray1d(arr);
            Console.WriteLine("Target: ");
            int target = int_Check();
            int i = LinearSearch(arr, target);
            if (i != -1 )
            {
                Console.WriteLine($"Number Found at index {i}");
            }
            else
            {
                Console.WriteLine("Number Not Found : " + i);
            }
        }
        static void q11()
        {
            int rows, cols;
            Console.Write("Enter numbe of rows: ");
            int.TryParse(Console.ReadLine(), out rows);
            Console.Write("Enter numbe of cols: ");
            int.TryParse(Console.ReadLine(), out cols);
            int[,] arr2d = new int[rows, cols];
            Array2DFill_int(arr2d, rows, cols);
            int totalSum = 0;
            for (int i = 0; i < rows; i++)
            {
                // Inner loop for columns
                for (int j = 0; j < cols; j++)
                {
                    totalSum += arr2d[i, j];
                }
            }
            Console.WriteLine($"Sum = {totalSum}");
        }
        static void q12()
        {
            int rows, cols;
            Console.Write("Enter numbe of rows: ");
            int.TryParse(Console.ReadLine(), out rows);
            Console.Write("Enter numbe of cols: ");
            int.TryParse(Console.ReadLine(), out cols);
            int[,] arr2d = new int[rows, cols];

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
                    Console.Write(arr2d[i, j] + "\t");
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
                Console.WriteLine($"Sum of row {i + 1} = {sum}");
            }
        }
        static void q13()
        {
            int rows, cols;
            Console.Write("Enter numbe of rows: ");
            int.TryParse(Console.ReadLine(), out rows);
            Console.Write("Enter numbe of cols: ");
            int.TryParse(Console.ReadLine(), out cols);
            int[,] arr2d = new int[rows, cols];

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
                    Console.Write(arr2d[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Use nested loops to calculate the sum of each col
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += arr2d[j, i];
                }
                Console.WriteLine($"Sum of col {i + 1} = {sum}");
            }
        }
        static void q14()
        {
            int rows, cols;
            Console.Write("Enter numbe of rows: ");
            int.TryParse(Console.ReadLine(), out rows);
            Console.Write("Enter numbe of cols: ");
            int.TryParse(Console.ReadLine(), out cols);
            int[,] arr2d = new int[rows, cols];
            Array2DFill_int(arr2d, rows, cols);
            Print2DArray(arr2d, arr2d.GetLength(0), arr2d.GetLength(1));
            int[,] transposearr = TransposeMatrix(arr2d);
            Print2DArray(transposearr, transposearr.GetLength(0), transposearr.GetLength(1));
        }
        static void q15()
        {
            int rows, cols;
            Console.Write("Enter numbe of rows: ");
            int.TryParse(Console.ReadLine(), out rows);
            Console.Write("Enter numbe of cols: ");
            int.TryParse(Console.ReadLine(), out cols);
            int[,] arr2d = new int[rows, cols];
            Array2DFill_int(arr2d, rows, cols);
            int largest = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr2d[i,j] > largest)
                    {

                        largest = arr2d[i, j];
                    }
                }
            }
            Console.WriteLine("the largest number = " + largest);
        }
        static void q16()
        {
            //1
            Day currentDay = Day.Tuesday;
            CheckDay(currentDay);
            //2
            Day weekendDay = Day.Saturday;
            CheckDay(weekendDay);
        }
        static void q17()
        {
            traffic color = traffic.Red;
            traficaction(color);
            traffic color2 = traffic.Green;
            traficaction(color2);
            traffic color3 = traffic.Yellow;
            traficaction(color3);
        }
        static void q18()
        {
            Season season = Season.Summer;
            SeasonMessage(season);
            Season season2 = Season.Winter;
            SeasonMessage(season2);
            Season season3 = Season.Autumn;
            SeasonMessage(season3);
            Season season4 = Season.Spring;
            SeasonMessage(season4);
        }
        static void q19()
        {           
            student student = new student();
            //name
            Console.Write($"Enter Student Name : ");
            student.Name  = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(student.Name) || student.Name.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid .. enter a valid name (letters only)");
                Console.Write($"Enter Student Name : ");
                student.Name = Console.ReadLine();
            }
            //Age
            Console.Write($"Enter Student Age : ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.WriteLine("Invalid ..Try Enter Age again");
                Console.Write($"Enter Student Age : ");
            }
            student.Age = age;
            //Grade
            Console.Write($"Enter Student Grade : ");
            int grade;
            while (!int.TryParse(Console.ReadLine(), out grade) || grade <= 0 || grade > 100)
            {
                Console.WriteLine("Invalid ..Try Enter grade again");
                Console.Write($"Enter Student Grade : ");
            }
            student.Age = grade;
            //print

            Console.WriteLine($"\n Student data: ");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Grade: {student.Grade}");
        }
        static void q20()
        {
            point[] p = new point[2];
            for (int i = 0; i < p.Length; i++)
            {
                //X
                Console.Write($"Enter x {i+1} coord : ");
                double x;
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Invalid ..Try Enter Age again");
                    Console.Write($"Enter Student Age : ");
                }
                p[i].x = x;
                //y
                Console.Write($"Enter y {i + 1} coord : ");
                double y;
                while (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Invalid ..Try Enter Age again");
                    Console.Write($"Enter Student Age : ");
                }
                p[i].y = y;
                
            }
            double dis = Distance(p[0], p[1]);
            //print 
            Console.WriteLine($"point {1} is ({p[0].x},{p[0].y})");
            Console.WriteLine($"point {2} is ({p[1].x},{p[1].y})");
            Console.WriteLine("distance between two points" + dis);
            
        }
        #endregion

    }
}
