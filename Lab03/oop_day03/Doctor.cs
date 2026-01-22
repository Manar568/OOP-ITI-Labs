using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
    internal class Doctor
    {
        public string name;
        public Doctor(string _name)
        {
            name= _name;
        }

        public void Treat(Patient p)
        {
            Console.WriteLine($"doctor {name} Treats {p.name}");
        }
    }
}
