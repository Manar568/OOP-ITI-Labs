namespace oop_day04_part02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];

            animals[0] = new Dog("dog");
            animals[1] = new Bird("bird");
            animals[2] = new Cat("cat");


            for (int i = 0; i < 3; i++) {

                Console.WriteLine(animals[i].Name);
                animals[i].MakeSound();
                animals[i].Eat();
            
            }


        }
    }
}
