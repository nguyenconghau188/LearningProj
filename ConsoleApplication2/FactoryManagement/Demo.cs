using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    class Demo
    {
        public static void Main(string[] args)
        {
            ActionXML.CreateXML();
        }
        //test
        public void Test()
        {
            Management.Manage();
            //People people = new People();
            //people.name = "Tom";
            //people.dayOfBirth = new DateTime(1993, 08, 18);
            //people.SetGender("M");
            //people.SetPostion("E");
            //people.address = "Viet Nam";

            //People people1 = new People();
            //people1.name = "Hary";
            //people1.dayOfBirth = new DateTime(1992, 10, 18);
            //people1.SetGender("M");
            //people1.SetPostion("W");
            //people1.address = "Frank";

            //Management.listPeople.Add(people);
            //Management.listPeople.Add(people1);

            //foreach (People peo in Management.listPeople)
            //{
            //    Console.WriteLine(peo.ToString());
            //}

            //Console.WriteLine("Enter a date: ");
            //DateTime userDateTime;
            //if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
            //{
            //    Console.WriteLine("The day of the week is: " + userDateTime.DayOfWeek);
            //}
            //else
            //{
            //    Console.WriteLine("You have entered an incorrect value.");
            //}

            //Console.WriteLine("Enter day of birth (mm/dd/yyyy): ");
            //string date = Console.ReadLine();
            //DateTime dt = Convert.ToDateTime(date);
            //Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt.Year, dt.Month, dt.Day);

            //Console.WriteLine("Enter a date: ");
            //DateTime dt;
            //while (!DateTime.TryParse(Console.ReadLine(), out dt))
            //{
            //    Console.WriteLine("Wrong date time format, reenter: ");
            //}
            //Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt.Year, dt.Month, dt.Day);

            //Console.WriteLine("Enter gender (M (male)/F (female)) ");
            //string gender = Console.ReadLine();
            //while (gender != "M" && gender != "F")
            //{
            //    Console.WriteLine("Wrong gender format, please re-enter gender (M (male)/F (female)): ");
            //    gender = Console.ReadLine();
            //}
            //Console.WriteLine(gender);

            //Console.WriteLine("Enter Worker Rank (x/7): ");
            //int rank = int.Parse(Console.ReadLine());
            //while ((rank < 1 || rank > 7))
            //{
            //    Console.WriteLine("Enter wrong rank, please re-enter (x/7): ");
            //    rank = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine(rank);
            Console.Read();
        }
    }
}
