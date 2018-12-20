using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class peparoniPizza : Pizza
    {
        void prepare()
        {
            Console.WriteLine("prepare pizza");
        }
    }
}
