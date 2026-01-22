using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day04_part01
{
    internal class Rectangle:Shape
    {
        private double width;
        private double height;
        public Rectangle(double w,double h)
        {
            width = w;
            height = h;

            
        }

        public override double CalculateArea()
        {
            Console.WriteLine("the area of Rectangle :");

            return width *height;
        }


    }
}
