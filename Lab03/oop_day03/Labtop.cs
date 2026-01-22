using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
    internal class Labtop
    {
        public string Model;
        public Charger charger;

        public Screen screen;

        public Labtop(string model)
        {
            Model = model;
        }

        public void Contains(Charger ch)
        {
            charger = ch;
            Console.WriteLine( $"the Labtop {Model} contains charger with {charger.volt} volts");

        }
    }
}
