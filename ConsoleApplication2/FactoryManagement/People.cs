using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    class People
    {
        public string name { get; set; }
        public DateTime dayOfBirth { get; set; }
        private Gender gender;
        public string  address { get; set; }
        private Position position;

        public People()
        {

        }

        public People(string name, DateTime dayOfBirth, Gender gender, string address, Position position)
        {
            this.name = name;
            this.dayOfBirth = dayOfBirth;
            this.gender = gender;
            this.address = address;
            this.position = position;
        }

        public override string ToString()
        {
            return "-> " + name + " | "
                +dayOfBirth.ToShortDateString()+" | "
                +Genders.GetText(gender)+" | "
                +address+" | "
                +Positions.GetText(position)+ " | "
                +GetSalary();
        }
        public Gender GetGender()
        {
            return gender;
        }

        public void SetGender(string codeGender)
        {
            this.gender = (Gender)Genders.GetGenderByCode(codeGender);
        }

        public Position GetPosition()
        {
            return position;
        }

        public void SetPostion(string positionCode)
        {
            this.position = (Position)Positions.GetPositionByCode(positionCode);
        }

        public double GetSalary()
        {
            return Constants.SALARY * Positions.GetSalaryRank(position);
        }

    }
}
