using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_new
{
    class DogView
    {
        public void printDogInfo(String name, int age)
        {
            Console.WriteLine("\n Dog is {0} and it is {1} yars old",name, age);
        }
    }
}
