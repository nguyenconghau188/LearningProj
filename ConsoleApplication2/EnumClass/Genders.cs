using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnumClass
{
    class Genders
    {
        
        public static Gender? GetGenderByCode(string code)
        {
            Array allGenders = Enum.GetValues(typeof(Gender));

            foreach(Gender gender in allGenders)
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
            GenderAttr genderAttr = GetAttr(gender);
            return genderAttr.code;
        }

        public static string GetText(Gender gender)
        {
            GenderAttr genderAttr = GetAttr(gender);
            return genderAttr.text;
        }

        private static GenderAttr GetAttr(Gender gender)
        {
            MemberInfo memberInfo = GetMemberInfo(gender);
            return (GenderAttr)Attribute.GetCustomAttribute(memberInfo, typeof(GenderAttr));
        }

        private static MemberInfo GetMemberInfo(Gender gender)
        {
            MemberInfo memberInfo = typeof(Gender).GetField(Enum.GetName(typeof(Gender), gender));
            return memberInfo;
        } 
    }
}
