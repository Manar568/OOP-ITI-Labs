namespace oop_day05_part03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Complex c1 = new Complex(2 ,3);
            c1++;
            c1.Disply();
            ++c1;
            Complex c2 = new Complex(4 ,5);
            ++c2;
              c2.Disply();

          //  Meter m = new Meter(50);
          //  Centi c = m;
          //  Console.WriteLine(c.length);//50,000

          //  m=(Meter)c;
          //  Console.WriteLine(m.length);//50


          //  Kilo k = m;
          //  Console.WriteLine(k.length);//50,000

          //  Meter m2=new Meter(30);

          //// Kilo k2=(Kilo)m2;
          //  Console.WriteLine(k.length);




            /* Kilo k = m;
             Console.WriteLine(k.length);
             m=(Kilo)k;
            k = (Kilo)m;*/

        }
    }
}
