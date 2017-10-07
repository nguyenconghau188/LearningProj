using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{
    class ValidateUtils
    {
        public static void CheckPerson(Person person)
        {
            try
            {
                AgeUtils.CheckAge(person.GetAge());
            }
            catch (Exception e)
            {
                throw new ValidateException(e);
            }

            if (person.GetGender() == Person.FEMALE)
            {
                GenderException e = new GenderException("Do not accept women");
                throw new ValidateException(e);
            }
        }
    }
}
