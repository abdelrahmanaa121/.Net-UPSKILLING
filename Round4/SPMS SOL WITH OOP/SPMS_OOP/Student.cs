using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMS_OOP
{
    internal class Student
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public double AttendancePercentage { get; private set; }
        public List<Subject> subjects { get; private set; }
        public Student(int id,string name,double attendance)
        {
            ID = id;
            Name = name;
            AttendancePercentage = attendance;
            subjects = new List<Subject>();
        }
        //read only prop
        public double FinalScore => CalculateFinalScore();
        public string FinalGrade => GetGradeFromScore(FinalScore);
        public string PerformanceStatus => GetStatusFromGrade(FinalGrade, AttendancePercentage);
        //methods
        private double CalculateFinalScore()
        {
            if (subjects == null || subjects.Any())
                return 0;
            return subjects.Average(Subject => Subject.CalculateAverage());
        }
        private string GetGradeFromScore(double finalscore)
        {
            if (finalscore >= 90) return GradeCategory.A;
            if (finalscore >= 80) return GradeCategory.B;
            if (finalscore >= 70) return GradeCategory.C;
            if (finalscore >= 60) return GradeCategory.D;
            return GradeCategory.F;
        }
        private string GetStatusFromGrade(string grade, double attendance)
        {
            if (grade == GradeCategory.A && attendance >= 90)
                return PerformanceStatues.Excellent;
            else if (grade == GradeCategory.B && attendance >= 75)
                return PerformanceStatues.Good;
            else if (grade == GradeCategory.C || grade == GradeCategory.D || (attendance >= 50 && attendance < 75))
                return PerformanceStatues.NeedsImprovement;
            else
            Console.WriteLine($"Alert: Student {Name} (ID: {ID}) is at risk of failing!");
            return PerformanceStatues.Fail;
        }
        public void PrintReport()
        {
            Console.WriteLine("\n==============================================");
            Console.WriteLine($"Student ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Attendance: {AttendancePercentage}%");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Subject-wise Averages:");
            foreach (var subject in subjects)
            {
                Console.WriteLine($" - {subject.SubjectName}: {subject.CalculateAverage():F2}");
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Final Score: {FinalScore:F2}");
            Console.WriteLine($"Final Grade: {FinalGrade}");
            Console.WriteLine($"Performance Status: {PerformanceStatus}");
            Console.WriteLine("==============================================\n");
        }
    }
}
