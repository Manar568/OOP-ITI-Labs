using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
    internal class User
    {
        public string name;
        public User(string _name)
        {
             name = _name;
        }

        public void Use (WebSite web)
        {
            Console.WriteLine($"{name} use the {web.Name} website");
        }
    }
}
