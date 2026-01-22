using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day05_part03
{
    internal class Complex
    {
        public int Real;
        public int Img;

        public Complex(int r, int i)
        {
            Real = r;
            Img = i;

        }
        public void Disply()
        {
            if (Img<0)
            Console.WriteLine($"{Real}{Img}i");
            else
                Console.WriteLine($"{Real}+{Img}i");


        }
        public static bool operator> (Complex left, Complex right)
        {
            return (left.Real > right.Real) && (left.Img > left.Img);
        }

        public static bool operator <(Complex left, Complex right)
        {
            return (left.Real < right.Real) || (left.Img < left.Img);
        }

        public static bool operator>= (Complex left, Complex right)
        {
           
              return  left.Real >= right.Real;
        }
        public static bool operator<=(Complex left, Complex right)
        {

            return left.Real <= right.Real;
        }
        //public static Complex operator++(Complex c)
        //{

        //    c.Real++;
        //    c.Img++;
        //    return c;

        //}
        //public static Complex operator--(Complex c)
        //{

        //    c.Real--;
        //    c.Img--;
        //    return c;

        //}
        public static Complex operator ++(Complex c1)
        {
            Complex c = new Complex(c1.Real, c1.Img);
            c.Real++;
            c.Img++;
            return c;

        }
        public static Complex operator --(Complex c1)
        {
            Complex c = new Complex(c1.Real, c1.Img);
            c.Real--;
            c.Img--;
            return c;

        }





    }
}
