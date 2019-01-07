using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgramming.FactoryPattern
{
    abstract class ShapeFactory
    {
        public static Shape GetShape(int choice, int x, int y, int width, int height, Graphics g)
        {
            Shape shape = null;
            
            switch (choice)
            {
                case 1:
                    shape = new Circle(x, y, width, height, g);
                    break;

                case 2:
                    shape = new Rectangle(x, y, width, height, g);
                    break;

                default:
                    shape = new Circle(x, y, width, height, g);
                    break;
            }

            return shape;
        }
    }
}
