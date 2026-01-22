using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
    internal class Office
    {
        public int number;
        public Chair ch;

        public Office(int n) {
        number = n; 
        }
        public void Contains(Chair chair) { 
        ch=chair;
            Console.WriteLine($"the offic {number} contains the {ch.color} chair");
        
        }



    }
}
