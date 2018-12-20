using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ShapeFactory
    {
        public Shape getShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("Rectangle"))
            {
                return new Rectangle();
            }else if (shapeType.Equals("Circle"))
            {
                return new Circle();
            }else if (shapeType.Equals("Square"))
            {
                return new Square();
            }
            return null;
        }
    }
}
