using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Dog
    {
      public String name { get; set; }
      public int age { get; set; }
        public void bark()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
