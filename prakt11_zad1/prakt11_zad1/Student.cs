using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt11_zad1
{
    public class Student
    {
        public string name;
        public int rost=170;
        static double ves=68;

        public string GetName()
        {
            return name;
        }
        public double GetEat()
        {
            return ves;
        }
        public double zad(double eda,double weight)
        {
            weight += eda - 1.7;
            return weight;
        }
    }
}
