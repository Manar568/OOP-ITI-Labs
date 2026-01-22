using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
    internal class Library
    {
        public string name;
        public Book[] books;

        public Library(string _name )
        {
             name = _name; 
        }

        public void Contains( Book[] boks)
        {
            books= boks;
            Console.WriteLine($"the library {name} contains this books :");

            for( int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{books[i].name}");
            }

        }


    }
}
