using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day04_part02
{
    internal abstract class Animal
    {
        public string Name;
        protected Animal(string name)
        {
            Name=name;
        }
        public void MakeSound()
        {
            Console.WriteLine("MMMMM");
        }
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }


    }
}
