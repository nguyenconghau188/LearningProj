using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    class Genders
    {
        public static Gender? GetGenderByCode(string code)
        {
            Array allGender = Enum.GetValues(typeof(Gender));

            foreach (Gender gender in allGender)
            {
                string str = GetCode(gender);
                if (str == code)
                {
                    return gender;
                }
            }
            return null;
        }

        public static string GetCode(Gender gender)
        {
            GenderAttribute genderAttr = GetAttr(gender);
            return genderAttr.GetCode();
        }

        public static string GetText(Gender gender)
        {
            GenderAttribute genderAttr = GetAttr(gender);
            return genderAttr.GetText();
        }

        private static GenderAttribute GetAttr(Gender gender)
        {
            MemberInfo memberInfo = GetMemberInfo(gender);
            return (GenderAttribute)Attribute.GetCustomAttribute(memberInfo, typeof(GenderAttribute));
        }

        private static MemberInfo GetMemberInfo(Gender gender)
        {
            MemberInfo memberInfo = typeof(Gender).GetField(Enum.GetName(typeof(Gender), gender));
            return memberInfo;
        }
    }
}
