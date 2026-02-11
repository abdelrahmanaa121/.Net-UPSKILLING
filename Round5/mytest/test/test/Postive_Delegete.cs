using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Postive_Delegete : IChecker
    {
        public bool Check(int number)
        {
            return number > 0;
        }
    }
}
