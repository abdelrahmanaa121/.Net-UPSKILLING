using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructors_staticmembers
{
    internal class Fraction
    {
        int Nem, Den;
        public Fraction (int nem,int den)
        {
            Nem = nem;
            Den = den;
        }
        public Fraction Add(Fraction other)
        {
            return new Fraction(0, 0);
        }
        public static Fraction Add(Fraction one,Fraction two)
        {
            return new Fraction(0, 0);
        }

    }
}
