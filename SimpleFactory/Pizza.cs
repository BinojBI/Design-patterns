using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    abstract class Pizza
    {
       public void prepare() {
            Console.WriteLine("prepare pizza");
        }
        public void bake () {
           Console.WriteLine("bake the pizza");
        }
    }
}
