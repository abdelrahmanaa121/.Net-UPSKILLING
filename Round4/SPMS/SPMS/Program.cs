using System;
using System.Linq;
using static SPMS.Program;

namespace SPMS
{
    internal class Program
    {
        #region Enum
        public enum GradeCategory { A, B, C, D, F }
        public enum PerformanceStatus { Excellent, Good, NeedsImprovement, Fail }
        #endregion

        #region Struct
        public struct Subject
        {
            public string SubjectName;
            public double[] ExamScores;
        }

        public struct Student
        {
            public int ID;
            public string Name;
            public Subject[] Subjects;
            public double AttendancePercentage;
            public GradeCategory FinalGrade;
            public PerformanceStatus PerformanceStatus;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.Write("Enter Students Number: ");
            int num = int_Check();
            Student[] students = new Student[num];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\n--- Student {i + 1} ---");

                Console.Write("Enter Student ID: ");
                students[i].ID = int_Check();

                Console.Write("Enter Student Name: ");
                students[i].Name = str_Check("student");

                Console.Write("Enter Attendance Percentage: ");
                students[i].AttendancePercentage = double_Check(0, 100);

                Console.Write("Enter number of subjects: ");
                int numOfSubjects = int_Check();
                students[i].Subjects = new Subject[numOfSubjects];

                for (int j = 0; j < numOfSubjects; j++)
                {
                    Console.WriteLine($"\n--- Subject {j + 1} ---");
                    Console.Write("Enter Subject Name: ");
                    students[i].Subjects[j].SubjectName = str_Check("subject");

                    // Initialize n of exam scores
                    Console.Write("Enter Number of Exam Scores: ");
                    int numofexamscore = int_Check();
                    students[i].Subjects[j].ExamScores = new double[numofexamscore];

                    for (int k = 0; k < numofexamscore; k++)
                    {
                        Console.Write($"Exam {k + 1} Score (0–100): ");
                        students[i].Subjects[j].ExamScores[k] = double_Check(0, 100);
                    }
                }

                // Calculate results
                double finalScore = CalculateFinalScore(students[i]);
                students[i].FinalGrade = GetGrade(finalScore);
                students[i].PerformanceStatus = GetStatus(students[i].FinalGrade, students[i].AttendancePercentage);

            }
            // Print report
            foreach (var item in students)
            {
                PrintReport(item);
            }
            //
        }

        #region Validation Helpers
        static int int_Check()
        {
            int x;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                    return x;
                Console.Write("Invalid input. Enter a positive integer: ");
            }
        }

        static double double_Check(double min = 0, double max = 100)
        {
            double x;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out x) && x >= min && x <= max)
                    return x;
                Console.Write($"Invalid input. Enter a number between {min} and {max}: ");
            }
        }

        static string str_Check(string type)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input) && !input.Any(char.IsDigit))
                    return input.Trim();

                Console.Write($"Invalid {type} name. Try again: ");
            }
        }
        #endregion

        #region Core Functions
        static double CalculateSubjectAverage(Subject subject)
        {
            double sum = 0;
            for (int i = 0; i < subject.ExamScores.Length; i++)
                sum += subject.ExamScores[i];
            return sum / subject.ExamScores.Length;
        }

        static double CalculateFinalScore(Student student)
        {
            double total = 0;
            for (int i = 0; i < student.Subjects.Length; i++)
                total += CalculateSubjectAverage(student.Subjects[i]);
            return total / student.Subjects.Length;
        }

        static GradeCategory GetGrade(double finalScore)
        {
            if (finalScore >= 90 && finalScore <= 100) return GradeCategory.A;
            else if (finalScore >= 80) return GradeCategory.B;
            else if (finalScore >= 70) return GradeCategory.C;
            else if (finalScore >= 60) return GradeCategory.D;
            else return GradeCategory.F;
        }

        static PerformanceStatus GetStatus(GradeCategory grade, double attendance)
        {
            if (grade == GradeCategory.A && attendance >= 90)
                return PerformanceStatus.Excellent;
            else if (grade == GradeCategory.B && attendance >= 75)
                return PerformanceStatus.Good;
            else if (grade == GradeCategory.C || grade == GradeCategory.D || (attendance >= 50 && attendance < 75))
                return PerformanceStatus.NeedsImprovement;
            else
            {
                Console.WriteLine("Alert: This student is at risk of failing!");
                return PerformanceStatus.Fail;
            }
        }

        static void PrintReport(Student student)
        {
            Console.WriteLine("\n==============================================");
            Console.WriteLine($"Student ID: {student.ID}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Attendance: {student.AttendancePercentage}%");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Subject-wise Averages:");
            foreach (var subject in student.Subjects)
            {
                double avg = CalculateSubjectAverage(subject);
                Console.WriteLine($" - {subject.SubjectName}: {avg:F2}");
            }
            double finalScore = CalculateFinalScore(student);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Final Score: {finalScore:F2}");
            Console.WriteLine($"Final Grade: {student.FinalGrade}");
            Console.WriteLine($"Performance Status: {student.PerformanceStatus}");
            Console.WriteLine("==============================================\n");
        }
        #endregion
    }
}
