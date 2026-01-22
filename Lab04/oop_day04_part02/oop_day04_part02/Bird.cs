using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day04_part02
{
    internal class Bird:Animal
    {
        public Bird(string name ):base(name)
        {
            
        }
        public  void MakeSound()
        {
            Console.WriteLine("the bird say ayhagaaaa");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is pecking seeds.");
        }


    }
}
