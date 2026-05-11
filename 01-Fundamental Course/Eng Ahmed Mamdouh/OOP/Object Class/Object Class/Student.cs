using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class
{
    internal class Student : Employee
    {
        public int Grade { set; get; }
        public virtual void Enroll(string Crs)
        {
            if (Grade < 60)
            {
                Console.WriteLine("Cant enroll");
                return;
            }
            Console.WriteLine("Enrolled");
        }
        
    }
}
