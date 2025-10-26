using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Course
    {
        #region Public property
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public List<Teacher> Teachers { get; private set; }
        public List<Student> Students { get; private set; }
        #endregion
        #region Constractor
        public Course(string code,string title)
        {
            CourseCode = code;
            Title = title;
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }
        #endregion
        #region Methods
        internal void AddTeacher(Teacher teacher)
        {
            if (!Teachers.Contains(teacher))
            {
                Teachers.Add(teacher);
            }
        }
        internal void AddStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
            }
        }
        #endregion
    }
}
