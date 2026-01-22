using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
    internal class WebSite
    {
        public string Name;
        Pages[] Pages=new Pages[2];
        public WebSite(string _name ) { 
        Name = _name;
        }

        public WebSite()
        {
            for( int i = 0; i <2; i++)
            {
                Pages[i] = new Pages();
            }


;         }



    }
}
