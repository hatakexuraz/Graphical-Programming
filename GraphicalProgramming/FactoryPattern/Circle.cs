using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgramming.FactoryPattern
{
    class Circle : Shape
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private Graphics graphics;

        int Shape.x { get { return x; } set { x = value; } }
        int Shape.y { get { return y; } set { y = value; } }
        int Shape.width { get { return width; } set { width = value; } }
        int Shape.height { get { return height; } set { height = value; } }


        public Circle() { }

        public Circle(int x, int y, int width, int height, Graphics g)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.graphics = g;

            DrawCircle();
        }

        private void DrawCircle()
        {
            Pen pen = new Pen(Color.Red);
            graphics.DrawEllipse(pen, x, y, width, height);
            //graphics.Dispose();
        }
    }
}
