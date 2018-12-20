using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class SimplePizzaFactory
    {
        public Pizza createPizza(String type)
        {
            Pizza pizza= null;

            if (type.Equals("cheese"))
            {
                pizza = new CheessPizza();
            }else if (type.Equals("paparoni"))
            {
                pizza = new peparoniPizza();
            }


            return pizza;
        }
    }
}
