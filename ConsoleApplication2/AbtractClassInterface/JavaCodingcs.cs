using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractClassInterface
{
    class JavaCodingcs : AbstractJob
    {
        public JavaCodingcs()
        {

        }

        public override void DoJob()
        {
            Console.WriteLine("Coding Java...");
        }

        public override string GetJobName()
        {
            return "Java Coding";
        }

        public void TestExample()
        {
            Console.WriteLine("Testing Example...");
        }
    }
}
