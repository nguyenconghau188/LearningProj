using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{
    class AgeUtils
    {
        public static void CheckAge(int age)
        {
            if (age<18)
            {
                throw new TooYoungException("Age " + age + " too young.");
            }
            else if (age>40)
            {
                throw new TooOldException("Age " + age + " too old.");
            }
            Console.WriteLine("Age" + age + " OK!");
        }
    }
}
