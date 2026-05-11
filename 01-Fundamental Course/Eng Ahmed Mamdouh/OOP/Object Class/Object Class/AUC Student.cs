using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class
{
    internal class AUC_Student : Student
    {
        public override void Enroll(string Crs)
        {
            base.Enroll(Crs);
            //if (Grade>70)
            //{
            //    return;
            //}
        }
    }
}
