using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day04_part01
{
    internal class Circle:Shape
    {

        public double radius;

        public Circle(double r)
        {
            radius = r;
        }
        public override double CalculateArea()
        {
            Console.WriteLine("the area of circle :");
            return Math.PI * radius * radius;
        }


    }
}
