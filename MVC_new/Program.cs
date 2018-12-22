using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_new
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog mydog = GetInfoFromDemo();
            DogView show = new DogView();
            DogController ctrl = new DogController(mydog, show);

            ctrl.updateView();

            //ctrl.setName("Snow");
            ctrl.setAge(4);

            ctrl.updateView();
            Console.ReadLine();

           
        }

        private static Dog GetInfoFromDemo()
        {
            Dog d = new Dog();
            d.name = "ricky";
            d.age = 10;
            return d;
        }
    }
}
