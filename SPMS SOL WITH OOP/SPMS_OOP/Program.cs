using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMS_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number of students
            Console.WriteLine("Enter Student Number: ");
            int num = InputValidator.int_Check();
            //array of students
            Student[] students = new Student[num];
            //loop
            for (int i = 0; i < students.Length; i++)
            {
                //header
                Console.WriteLine($"\n--- Student {i + 1} ---");
                //store data for student
                Console.Write("Enter Student ID: ");
                int id = InputValidator.int_Check();
                Console.Write("Enter Student Name: ");
                string name = InputValidator.str_Check("student");
                Console.Write("Enter Attendance Percentage: ");
                double attendance = InputValidator.double_Check(0, 100);
                //create object
                students[i] = new Student(id, name, attendance);
                //store data for subject
                Console.Write("Enter number of subjects: ");
                int numOfSubjects = InputValidator.int_Check();
                //nested loop
                for (int j = 0; j < numOfSubjects; j++)
                {
                    //store data for subject
                    Console.WriteLine($"\n--- Subject {j + 1} ---");
                    Console.Write("Enter Subject Name: ");
                    string subjectName = InputValidator.str_Check("subject");
                    Console.Write("Enter Number of Exam Scores: ");
                    int numofexamscore = InputValidator.int_Check();
                    //array for scores
                    double[] scores = new double[numofexamscore];
                    //for loop to get all scores
                    for (int k = 0; k < numofexamscore; k++)
                    {
                        Console.Write($"Exam {k + 1} Score (0–100): ");
                        scores[k] = InputValidator.double_Check(0, 100);
                    }
                    //create obj
                    Subject subject = new Subject(subjectName, scores);
                    //add to list
                    students[i].subjects.Add(subject);
                }
            }
            //report
            Console.WriteLine("\n\n--- FINAL REPORTS ---");
            foreach (var student in students)
            {
                student.PrintReport();
            }
        }
    }
}
