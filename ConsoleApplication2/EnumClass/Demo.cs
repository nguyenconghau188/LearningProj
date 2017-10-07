using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumClass
{
    class Demo
    {
        public static void Main(string[] args)
        {
            //int i = 0;
            //Array allDays = Enum.GetValues(typeof(WeekDay));
            //foreach (WeekDay day in allDays)
            //{
            //    i++;
            //    Console.WriteLine("Day " + i + ": " + day);
            //}

            Gender marryGender = Gender.FEMALE;

            Console.WriteLine("marryGender: " + marryGender);

            Console.WriteLine("Code: " + Genders.GetCode(marryGender));
            Console.WriteLine("Text: " + Genders.GetText(marryGender));

            string code = "M";
            Console.WriteLine("Input code: " + code);
            Gender? gender = Genders.GetGenderByCode(code);
            Console.WriteLine("Gender by code: " + gender);

            Console.Read();
        }
    }
}
