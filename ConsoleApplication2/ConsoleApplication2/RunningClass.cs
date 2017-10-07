using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class RunningClass
    {
        public static void Main(string[] args)
        {
            Shapes.Rectangle rec1 = new Shapes.Rectangle();
            rec1.nameShapes = "Rectangle";
            rec1.width = 3;
            rec1.height = 5;
            Console.WriteLine(rec1.ToString());
            Console.ReadLine();
        }
    }
}
