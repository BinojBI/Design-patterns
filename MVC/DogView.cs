using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class DogView
    {
        public void printDogInfo(String name, int age)
        {
            Console.WriteLine("\n Dog is {0} and its age is {1} years old", name, age);
        }
    }
}
