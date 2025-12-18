using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Bank_Account
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; private set; }
        public int Age
        {
            get { return DateTime.Now.Year - Year; }
        }
        //constructor
        public Car(string make,string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = 0;
        }
        //Method
        public void Drive(int distance)
        {
            if (distance < 0)
            {
                Console.WriteLine("Distance can not be negative");
            }
            else
            {
                Mileage += distance;
                Console.WriteLine($"Drove: {distance} km, Total Milage {Mileage} km");
            }

        }

    }
}
