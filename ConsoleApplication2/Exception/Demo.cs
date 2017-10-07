using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{
    class Demo
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Start Recruiting...");

            //Console.WriteLine("Check your age: ");
            //int age = 50;

            //try
            //{
            //    AgeUtils.CheckAge(age);
            //    Console.WriteLine("You pass");
            //}
            //catch (TooYoungException e)
            //{
            //    Console.WriteLine("You are too young. Not pass!");
            //    Console.WriteLine(e.Message);
            //}
            //catch (TooOldException e)
            //{
            //    Console.WriteLine("You are too old. Not pass!");
            //    Console.WriteLine(e.Message);
            //}
            //===============================================================

            Person person = new Person("Marry", Person.FEMALE, 20);

            try
            {
                // Ngoại lệ có thể xẩy ra tại đây.
                ValidateUtils.CheckPerson(person);

            }
            catch (ValidateException wrap)
            {

                // Lấy ra nguyên nhân thực sự.
                // Mà có thể là TooYoungException, TooOldException, GenderException.
                Exception cause = wrap.GetBaseException();

                if (cause != null)
                {
                    Console.WriteLine("Message: " + wrap.Message);
                    Console.WriteLine("Base Exception Message: " + cause.Message);
                }
                else
                {
                    Console.WriteLine("Message: " + wrap.Message);

                }
            }

            Console.Read();
        }
    }
}
