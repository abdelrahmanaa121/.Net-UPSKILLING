using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vechile vechile = new Car();
            //Vechile vechile2 = new Vechile();
            //vechile.Move(); //هنا شايف الحاجات الي بيورثها للابن بس
            //لاحظ اني لما زودت الاوفر رايد و الفيرتشوال السطر الي فوق سمع ع الكار مش الفيكال

            //Car car = new Car();
            //car.Move();
            //car.test();
            //vechile2.test();

            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            //employee1.

            object obj1 = new Employee();
            object obj2 = new Employee();
            object car = new Car();
            object obj3 = 5; //boxing
            int x = (int)obj3; //unboxing

            employee1.ID = 10;
            employee2.ID = 10;
            //value compare
            if(employee1.ID.Equals(employee2.ID))
            {
                Console.WriteLine("==");
            }
            else
            {
                Console.WriteLine("!=");
            }
            //ref compare
            if (employee1.Equals(employee2))
            {
                Console.WriteLine("==");
            }
            else
            {
                Console.WriteLine("!=");
            }

            if (Equals(employee1.ID,employee2.ID))
            {
                Console.WriteLine("==");
            }
            else
            {
                Console.WriteLine("!=");
            }

            int c = 5;
            int b = 5;
            if (c.Equals(b))
            {
                Console.WriteLine("==");
            }
            else
            {
                Console.WriteLine("!=");
            }
            employee1.Name = "Ali";
            Employee employee3 = employee1;
            Console.WriteLine(employee1.ToString());
            Console.WriteLine(employee1.GetHashCode());
            Console.WriteLine(employee2.GetHashCode());
            Console.WriteLine(employee3.GetHashCode());
        }
    }
}
