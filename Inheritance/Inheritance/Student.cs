using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    public class Student: Person
    {
        #region Public property
        public string StudentID { get; set; }
        public Department EnrolledDepartment { get; set; } //many-to-one Association
        public List<Course> RegisteredCourses { get; set; }

        #endregion
        #region Constractor
        public Student(string name, int age, string contactdetails,string studentiD) :base(name,age,contactdetails)
        {
            StudentID = studentiD;
            RegisteredCourses = new List<Course>();
        }
        #endregion
        #region Methods
        public void RegisterForCourse(Course course)
        {
            if (!RegisteredCourses.Contains(course))
            {
                RegisteredCourses.Add(course);
                course.AddStudent(this);
            }
        }

        #endregion
    }
}
