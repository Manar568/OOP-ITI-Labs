using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day04_part02
{
    internal class Dog:Animal 
    {
        public Dog(string name):base(name)
        {
             
        }
        public void MakeSound()
        {
            Console.WriteLine("the dog say wooof");
        }


        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating meat ");
        }
    }
}
