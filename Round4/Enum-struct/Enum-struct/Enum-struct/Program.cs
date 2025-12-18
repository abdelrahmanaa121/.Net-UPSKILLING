using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enum_struct.Program;

namespace Enum_struct
{
    internal class Program
    {
        public enum genre
        {
            Fiction,
            NonFiction,
            Mystery,
            ScienceFiction,
            Biography
        }

        public enum year_level
        {
            Freshman,
            Sophomore,
            Junior,
            Senior
        }
        public enum Department
        {
            HR,
            IT,
            Sales,
            Finance
        }


        public struct book
        {
            public string title;
            public string auther;
            public int publication_year;
            public genre Genre;
        }

        public struct student
        {
            public string name;
            public double[] grades;
            public year_level year;
            public double avg;
        }

        public struct employees
        {
            public int EmployeeID;
            public string name;
            public double salary;
            public Department department;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\nAssignment 1: Store and Display Book Information");
            Ass1();

            Console.WriteLine("\nAssignment 2: Student Grades");
            Ass2();

            Console.WriteLine("\nAssignment 3: Employee Database with Department");
            Ass3();


        }
        static void Ass1()
        {
            book[] books = new book[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Book {i + 1} data");
                books[i] = new book();
                Console.Write("Title: ");
                books[i].title = Console.ReadLine();
                Console.Write($"Enter Auther name: ");
                books[i].auther = Console.ReadLine();
                Console.Write($"Enter publication year: ");
                int year;
                while (!int.TryParse(Console.ReadLine(), out year))
                {
                    Console.Write("Invalid input! Please enter a number: ");
                }
                books[i].publication_year = year;
                Console.Write($"Write number to choose Genre (Fiction = 0, NonFiction = 1, Mystery = 2, ScienceFiction = 3,Biography = 4) : ");
                int GenChoice;
                while (!int.TryParse(Console.ReadLine(), out GenChoice) || GenChoice < 0 || GenChoice > 4)
                {
                    Console.Write("Invalid input! Please enter a number between 0 and 4: ");
                }

                books[i].Genre = (genre)GenChoice;

            }
            Console.WriteLine("\n --Books information-- ");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"\n book{i+1} information: ");
                Console.WriteLine($"Title: {books[i].title}");
                Console.WriteLine($"Auther: {books[i].auther}");
                Console.WriteLine($"Publish year: {books[i].publication_year}");
                Console.WriteLine($"Genre: {books[i].Genre}");
            }
        }
        static void Ass2()
        {
            Console.Write("Enter Student Number : ");
            int num;
            while (!int.TryParse(Console.ReadLine(),out num))
            {
                Console.WriteLine("Invalid ..Try Enter Number again");
                Console.Write("Enter Student Number : ");
            }
            student[] st = new student[num];
            for (int i = 0; i < st.Length; i++)
            {
                Console.Write($"Enter Student {i + 1} Name : ");
                
                st[i].name = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(st[i].name) || st[i].name.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid .. enter a valid name (letters only)");
                    Console.Write($"Enter Student {i + 1} Name : ");
                    st[i].name = Console.ReadLine();

                }

                Console.Write("Enter Year Level (Freshman = 0, Sophomore = 1, Junior = 2, Senior = 3) : ");
                int yearcoise;
                while (!int.TryParse(Console.ReadLine(), out yearcoise) || yearcoise < 0 || yearcoise > 3)
                {
                    Console.WriteLine("Invalid ..choose a number from 0 to 3 ");
                }
                st[i].year = (year_level)yearcoise;
                st[i].grades = new double[5];
                Console.WriteLine("Enter 5 Grades: ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Grade{j+1} = ");
                    while (!double.TryParse(Console.ReadLine(), out st[i].grades[j]) || st[i].grades[j] < 0 || st[i].grades[j] > 100)
                    {
                        Console.WriteLine("Invalid ..enter valid grade between 0 and 100");
                    }
                }
               

            }
            Console.WriteLine("\n ... student info...");
            for (int i = 0; i < st.Length; i++)
            {
                Console.WriteLine($"\n Student{i + 1} data: ");
                Console.WriteLine($"Name: {st[i].name}");
                Console.WriteLine($"Year Level: {st[i].year}");
                Console.WriteLine($"Avg: {st[i].grades.Average():F2}");
                
            }
            //top avg
            double higavg = st[0].grades.Average();
            string topstudent = st[0].name;
            for (int i = 0; i < st.Length; i++)
            {
                double avg = st[i].grades.Average();
                if (avg > higavg)
                {
                    higavg = avg;
                    topstudent = st[i].name;
                }
            }
            Console.WriteLine($"\nThe student with the highest average is {topstudent} with {higavg:F2}");
        }
        static void Ass3()
        {
            Console.Write("Enter employees Number : ");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid ..Try Enter Number again");
                Console.Write("Enter employees Number : ");
            }
            employees[] emp = new employees[num];
            for (int i = 0; i < emp.Length; i++)
            {
                //ID
                Console.Write($"Enter Employees {i + 1} ID : ");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id) || id <= 0)
                {
                    Console.WriteLine("Invalid ..Try Enter ID again");
                    Console.Write($"Enter Employees {i + 1} ID : ");
                }
                emp[i].EmployeeID = id;
                //name
                Console.Write($"Enter Employees {i + 1} Name : ");
                emp[i].name = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(emp[i].name) || emp[i].name.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid .. enter a valid name (letters only)");
                    Console.Write($"Enter Student {i + 1} Name : ");
                    emp[i].name = Console.ReadLine();
                }
                //salary
                Console.Write($"Enter Employees {i + 1} salary : ");
                int salary;
                while (!int.TryParse(Console.ReadLine(), out salary) || salary < 0)
                {
                    Console.WriteLine("Invalid ..Try salary again");
                    Console.Write($"Enter Employees {i + 1} salary : ");
                }
                emp[i].salary = salary;
                //department
                Console.Write($"Write number to choose Department (HR = 0, IT = 1, Sales = 2, Finance = 3 : ");
                int depChoice;
                while (!int.TryParse(Console.ReadLine(), out depChoice) || depChoice < 0 || depChoice > 3)
                {
                    Console.Write("Invalid input! Please enter a number between 0 and 4: ");
                }
                emp[i].department = (Department)depChoice;
            }
            //print
            //Console.WriteLine("\n ... Employee  info...");
            //for (int i = 0; i < emp.Length; i++)
            //{
            //    Console.WriteLine($"\n Employee {i + 1} data: ");
            //    Console.WriteLine($"ID: {emp[i].EmployeeID}");
            //    Console.WriteLine($"Name: {emp[i].name}");
            //    Console.WriteLine($"Salary: {emp[i].salary}");
            //    Console.WriteLine($"Department: {emp[i].department}");
            //}
            //total salaries for all the employees
            double totsal = 0;
            for (int i = 0; i < emp.Length; i++)
            {
                totsal += emp[i].salary;
            }
            Console.WriteLine($"\nTotal salaries for all the employees = {totsal}");
            //name of department with the highest paid employee
            double maxSalary = emp[0].salary;
            string highestPaidName = emp[0].name;
            Department highestPaidDept = emp[0].department;
            for (int i = 1; i < emp.Length; i++)
            {
                if (emp[i].salary > maxSalary)
                {
                    maxSalary = emp[i].salary;
                    highestPaidName = emp[i].name;
                    highestPaidDept = emp[i].department;
                }
            }
            Console.WriteLine($"\nHighest Paid Employee is {highestPaidName} in {highestPaidDept} with {maxSalary} salary");
        }




    }
}
