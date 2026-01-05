using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Car : Vechile
    {
        public string Color { get; set; }
        public override void Move()
        {
            Console.WriteLine("car is moving");
        }
        public override void test()
        {
            Console.WriteLine("test in car");
        }
    }
}
