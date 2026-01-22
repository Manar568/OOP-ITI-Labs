using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day05_part03
{
    internal class Meter
    {
        public double length;
        public Meter(double l)
        {
             length = l;
        }


      public static implicit operator Centi(Meter m)
        {
            return new Centi(m.length*1000);
        } 

        public static explicit operator Kilo(Meter m)
        {
           // Console.WriteLine("from  meter to kilo");
            return new Kilo(m.length / 1000);
        }


   
      
    }
}
