using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1");
            T1();
            Console.WriteLine("task 2");
            T2();
            Console.WriteLine("task 3");
            T3();
            Console.WriteLine("task 4");
            T4();
            Console.WriteLine("task 5");
            T5();

        }
        static void T1()
        {
            Console.WriteLine("Number = ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i < x + 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is even number");
                }
                else
                {
                    Console.WriteLine($"{i} is odd number");
                }
            }
        }
        static void T2()
        {
            Console.Write("Please enter the num = ");
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine($"{x} * {i} = {x * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        static void T3()
        {
            int sum = 0;
            int num;
            do
            {
                Console.WriteLine("add num = (press 0 to stop)");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    sum += num;
                }

            } while (num != 0);

            Console.WriteLine("sum = " + sum);
        }
        static void T4()
        {
            Random r = new Random();
            int x = r.Next(1, 51);
            int num;
            int counts = 0;
            Console.WriteLine(" A random number between 1 and 50 has been Generated, your challenge is to guess it!!");
            do
            {
                Console.WriteLine("your guess is ");
                string guess = Console.ReadLine();
                if (!int.TryParse(guess, out num))
                    {
                    Console.WriteLine("invalid input! Please enter a number!!");
                    continue;
                    }
                if (num < 1 || num > 51)
                {
                    Console.WriteLine("invalid input! Please enter a number between 1 & 51!!");
                    continue;
                }
                if (num > x )
                {
                    Console.WriteLine("Too high!");
                    counts++;
                }
                else if (num < x)
                {
                    Console.WriteLine("Too low!");
                    counts++;
                }
                else
                {
                    Console.WriteLine($"Correct! You guessed it in {counts} tries.");
                    break;
                }
                if (counts >= 3)
                {
                    if (x >= 25)
                    {
                        Console.WriteLine("Hint the number is above or equal 25");
                    }
                    else
                    {
                        Console.WriteLine("Hint the number is below 25");
                    }
                }
                if (counts >= 6)
                {
                    int diff = Math.Abs(num - x);
                    Console.WriteLine($"you are {diff} away from the secret number!!");
                }
            } while (num != x);
            Console.WriteLine("Correct..Braavvoo!");
        }
        static void T5()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i ;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

}
