using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day05_part03
{
    internal class Kilo
    {

        public double length;
        public Kilo(double l)
        {
            length = l;
        }

        public static implicit operator Kilo(Meter m)
        {
            return new Kilo(m.length*1000);
        }
        public static implicit operator Kilo(Centi c)
        {
            return new Kilo(c.length*1000000);
        }


    }
}
