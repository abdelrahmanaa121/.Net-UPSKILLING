using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start up
            Console.WriteLine("...Setting up university system...");
            //Create Objects 
            var Teacher1 = new Teacher("Dr.Akram", 35, "01016812529", "1050");
            var Teacher2 = new Teacher("Dr.Ali", 40, "01016952478", "1051");
            var course1 = new Course("E101", "Frontend");
            var course2 = new Course("E201", "Backend");
            //assign teachers
            Teacher1.AssignToCourse(course1);
            Teacher2.AssignToCourse(course2);
            //print
            Console.WriteLine($"{course1.CourseCode} is taught by: ");
            foreach (var teacher in course1.Teachers)
            {
                Console.WriteLine($"{teacher.Name} with ID: {teacher.TeacherID}");
            }
            Console.WriteLine($"{course2.CourseCode} is taught by: ");
            foreach (var teacher in course2.Teachers)
            {
                Console.WriteLine($"{teacher.Name} with ID: {teacher.TeacherID}");
            }
            //create schools
            var engschool = new EngineeringSchool("Salah Salem", "Suez", "8471");
            var bussschool = new BusinessSchool("Abbas","Suez","7892");
            //print
            Console.WriteLine($"{engschool.Name}");
            Console.WriteLine($"{bussschool.Name}");
            //create Departments
            var csdept = new Department("Computer Science");
            var mathdept = new Department("Mathematics");
            csdept.AddTeacher(Teacher1);
            csdept.AddTeacher(Teacher2);
            var student1 = new Student("Salem",22,"158024","1584");
            student1.RegisterForCourse(course1);
            student1.RegisterForCourse(course2);
            Console.WriteLine($"Student {student1.Name} is registered for:");
            foreach (var course in student1.RegisteredCourses)
            {
                Console.WriteLine($" {course.Title}");
            }
            var university = new University("Suez University");
            university.AddSchool(engschool);
            university.AddSchool(bussschool);
            Console.WriteLine($"{university.Name} has {university.Schools.Count} school(s).");
            
        }
    }
}
