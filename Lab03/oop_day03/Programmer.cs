using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
    internal class Programmer
    {
        public string name;


        public Programmer(string _name)
        {
            name= _name;
        }

        public void Use(Labtop l)
        {
            Console.WriteLine($"{name} use Labtop {l.Model}");
        }


    }
}
