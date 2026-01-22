namespace oop_day04_part01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shape[] shapes = new Shape[2];

            shapes[0] = new Rectangle(3, 4);
            shapes[1] = new Circle(5);


            for (int i = 0; i < 2; i++) { 
            
            Console.WriteLine(shapes[i].CalculateArea());
            }

            
        }
    }
}
