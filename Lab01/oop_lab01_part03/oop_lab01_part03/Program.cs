namespace oop_lab01_part03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point3D p1 = new Point3D();
            p1.setX(1);
            p1.setY(1);
            p1.setZ(1);
            p1.Display();


            Point3D p2 = new Point3D();
            p2.setX(4);
            p2.setY(1);
            p2.setZ(3);
            p2.Display();


            Console.WriteLine($" the distance betweem X_coordinat : { p1.CalculateDistance(p1, p2)}\n");


            Fraction f1=new Fraction();

            f1.setNumerator(1);
            f1.setDenominator(3);
            f1.Display();

            Fraction f2 = new Fraction();

            f2.setNumerator(1);
            f2.setDenominator(3);
            f2.Display();


            Fraction f3= new Fraction();

            f3 = f2.Add(f1, f2);

            f3.Display();
            f3.Simplify();
            f3.Display();





        }
    }
}
