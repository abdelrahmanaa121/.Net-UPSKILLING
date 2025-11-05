using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMS_OOP
{
    internal class InputValidator
    {
        public static int int_Check()
        {
            int x;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                    return x;
                Console.Write("Invalid input. Enter a positive integer: ");
            }
        }

        public static double double_Check(double min = 0, double max = 100)
        {
            double x;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out x) && x >= min && x <= max)
                    return x;
                Console.Write($"Invalid input. Enter a number between {min} and {max}: ");
            }
        }

        public static string str_Check(string type)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input) && !input.Any(char.IsDigit))
                    return input.Trim();

                Console.Write($"Invalid {type} name. Try again: ");
            }
        }
    }
}
