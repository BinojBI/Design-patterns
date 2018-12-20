using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class PizzaStore
    {
        SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        } 
        public Pizza orderPizza(string type)
        {
            Pizza pizza;
            pizza = factory.createPizza(type);

            pizza.prepare();
            pizza.prepare();

            return pizza;
        }
    }
}
