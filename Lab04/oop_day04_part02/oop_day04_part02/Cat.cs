using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day04_part02
{
    internal class Cat:Animal
    {
        public Cat(string name ):base(name)
        {
            
        }

        public  void MakeSound()
        {

            Console.WriteLine("the cat say miaoooo");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating tonaa ");
        }
    }
}
