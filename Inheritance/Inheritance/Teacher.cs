using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Teacher : Person //Teacher inherits from Person    
    {
        #region Public property
        public string TeacherID { get; set; }
        public List<Course> CoursesTaught { get; set; } //from Course class
        #endregion
        #region Constractor
        public Teacher(string name,int age,string contactdetails,string teacheriD) : base(name,age,contactdetails)
        //": base(name, age, contact)" calls the PARENT (Person) constructor first to set the Name, Age, and ContactDetails
        {
            TeacherID = teacheriD;
            // must initialize the list, or it will be "null" and crash if we try to .Add() to it.
            CoursesTaught = new List<Course>();
        }
        #endregion
        #region Methods
        //link between a Teacher and a Course
        public void AssignToCourse(Course course)
        {
            //Check if we already added this course
            if (!CoursesTaught.Contains(course))
            {
                CoursesTaught.Add(course);// Add the course to this teacher's list
                course.AddTeacher(this);//course add this teacher to its list of teachers
            }
        }
        #endregion
    }
}
