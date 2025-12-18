using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMS_OOP
{
    internal class Subject
    {
        #region Prop
        public string SubjectName { get; private set; }
        public double[] ExamScores { get; private set; }

        #endregion
        #region Contractor
        public Subject(string subjectname, double[] examscores)
        {
            SubjectName = subjectname;
            ExamScores = examscores;
        }
        #endregion
        #region Methods
        public double CalculateAverage()
        {
            if (ExamScores == null ||  !ExamScores.Any())
                return 0;
                return ExamScores.Average();
        }
        #endregion

    }
}
