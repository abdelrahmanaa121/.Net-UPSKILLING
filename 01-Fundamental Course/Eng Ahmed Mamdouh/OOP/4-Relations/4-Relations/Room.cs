using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Relations
{
    internal class Room
    {
        Instructor instructor;
        Student[] students = new Student[10];
        int studentcount = 0;
        Wall[] walls = new Wall[4];
        public Room()
        {
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i] = new Wall();
            }
        }
        public void StudentEnter(Student student)
        {

        }
        public void InstrucEnter(Instructor instructor) 
        {
            this.instructor = instructor;
        }
        public void TurnLightOn()
        {
            if (instructor == null)
                return;
            
        }
        public void InstructorLeave()
        {
            instructor = null;
        }
    }
}
