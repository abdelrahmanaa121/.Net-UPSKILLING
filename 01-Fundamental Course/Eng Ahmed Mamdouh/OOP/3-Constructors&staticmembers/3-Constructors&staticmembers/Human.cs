using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructors_staticmembers
{
    internal class Human
    {
        public int Age;
        public string Name;
        public double Wieght;
        string Thought;
        static int counter = 0;
        #region Cooments
        //public Human()
        //{
        //    Age = 10;
        //    Console.WriteLine("Human Created");
        //}
        //public Human (int age)
        //{
        //    Age=age;
        //    Name = "No Name";
        //    Console.WriteLine("Human Created");
        //}
        //public Human (int age,string name)
        //{
        //    Age = age;
        //    Name = name;
        //    Console.WriteLine("Human Created");
        //}
        /// <summary>
        /// explain
        /// </summary>
        //public Human()
        //{
        //    Human(10,"No Name");
        //}
        //public Human(int age)
        //{
        //    Human(age,"No Name");
        //    Console.WriteLine("Human Created");
        //}
        //public Human(int age, string name)
        //{
        //    Age = age;
        //    Name = name;
        //    Console.WriteLine("Human Created");
        //} 
        #endregion

        #region Constructor Chain
        public Human() : this(10, "No Name") { }

        public Human(int age) : this(age, "No Name") { }
        public Human(int age, string name)
        {
            Age = age;
            Name = name;
            counter++;
            Console.WriteLine("Human Created");
        } 
        #endregion
        public static void Display_Counter()
        {
            Console.WriteLine(counter);
        }

    }
}
