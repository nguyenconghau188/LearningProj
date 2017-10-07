using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{
    class Person
    {
        public static readonly string MALE = "male";
        public static readonly string FEMALE = "female";

        private string name;
        private string gender;
        private int age;

        public Person(string name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }

        public string GetGender()
        {
            return gender;
        }

        public int GetAge()
        {
            return age;
        }
    }
}
