using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    class Positions
    {
        public static Position? GetPositionByCode(string code)
        {
            Array allPositions = Enum.GetValues(typeof(Position));

            foreach (Position position in allPositions)
            {
                string str = GetCodeP(position);
                if (str == code)
                {
                    return position;
                }
            }
            return null;
        }

        public static string GetCodeP(Position position)
        {
            PositionAttribute positionAttr = GetAttr(position);
            return positionAttr.GetCode();
        }

        public static string GetText(Position position)
        {
            PositionAttribute positionAttr = GetAttr(position);
            return positionAttr.GetText();
        }

        public static float GetSalaryRank(Position position)
        {
            PositionAttribute positionAttr = GetAttr(position);
            return positionAttr.GetSalaryRank();
        }

        private static PositionAttribute GetAttr(Position position)
        {
            MemberInfo memberInfo = GetMemberInfo(position);
            return (PositionAttribute)Attribute.GetCustomAttribute(memberInfo, typeof(PositionAttribute));
        }

        private static MemberInfo GetMemberInfo(Position position)
        {
            MemberInfo memberInfo = typeof(Position).GetField(Enum.GetName(typeof(Position), position));
            return memberInfo;
        }
    }
}
