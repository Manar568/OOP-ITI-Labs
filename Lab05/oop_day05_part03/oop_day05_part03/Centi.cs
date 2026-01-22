using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day05_part03
{
    internal class Centi
    {
      public  double length;


        public Centi(double l)
        {
           length = l; 
        }

        public static explicit operator Meter(Centi s) {


            return new Meter(s.length / 1000);
        
        }

        public static explicit operator Kilo(Centi c)
        {
            return new Kilo(c.length / 1000000);
        }

    }
}
