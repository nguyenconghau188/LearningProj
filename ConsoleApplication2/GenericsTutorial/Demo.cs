using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTutorial
{
    class Demo
    {
        static void Main(string[] args)
        {
            KeyValue<int, string> entry = new KeyValue<int, string>(102110, "John");

            int phone = entry.GetKey();
            string name = entry.GetValue();

            Console.WriteLine("Phone= " + phone + " /name = " + name);

            Console.ReadLine();
        }
    }
}
