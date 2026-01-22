using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab01_part03
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;



        public void setNumerator(int num)
        {
            numerator = num;
        }
        public void setDenominator(int den) {
            if (den == 0) {
                Console.WriteLine("the denominator coudn't be zero\n");
            }
            else
                denominator = den;
        }
        public int getNumerator()
        {

            return numerator;
        }

        public int getDenominator() { return denominator; }

        public void Display()
        {
            Console.WriteLine($" {numerator} / {denominator} \n");

        }

       /* public int Add(int f1n,int f1d,int f2n,int f2d)
        {

           int  result =( (f1n * f2d) + (f2n * f1d) )/ (f1d * f2d);

            return result;
        }
       */

        public Fraction Add(Fraction f1, Fraction f2)

        {
            int n1 = f1.getNumerator();
            int n2 = f2.getNumerator();
            int d1 = f1.getDenominator();
            int d2 = f2.getDenominator();


            //Logic: (f1.n * f2.d + f2.n * f1.d) / (f1.d * f2.d)

            int newNum=(n1*d2 + n2*d1);
            int newDen = (d1 * d2);

            Fraction f3=new Fraction();
            f3.numerator = newNum;
            f3.denominator = newDen;

            return f3;  
        }

        public int GCD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;

            }
            return a;
           // return b;

        }

        public void Simplify()
        {
            int gcd = GCD(numerator, denominator);

            numerator /= gcd;
            denominator /= gcd;

         

        }

    }
}
