using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Programcd
    {
        static void Main(string[] args)
        {

            ShapeFactory shapeFactory = new ShapeFactory();

            Shape shape1 = shapeFactory.getShape("Rectangle");

            shape1.draw();

            Console.ReadLine();

        }
    }
}
