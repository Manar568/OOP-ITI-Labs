using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop_day06
{
    internal class Book
    {
        public string Title;

    public string Author;
        public string ISBN;

        public Book( string name , string author , string isbn)
        {
             Title= name;
            Author= author;
            ISBN= isbn;
        }
        //public override string ToString()
        //{
        //    return $"{Title} ::{Author} :: {ISBN} \n";
        //}



    }
}
