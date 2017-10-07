using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Shapes
{
    class Rectangle : Shapes, InterfaceShapes
    {
        public int width { get; set; }
        public int height { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(string nameShapes, int width, int height)
        {
            this.nameShapes = nameShapes;
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            return width * height;
        }

        public int Perimeter()
        {
            return 2 * (width + height);
        }

        public override string ToString()
        {
            return "The "+ nameShapes + " have: width = " + width + "; height = " + height + "; perimeter = " + Perimeter() + "; area = " + Area();
        }
    }
}
