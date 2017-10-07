using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumClass
{
    class TimeTable
    {
        public static String GetJob(WeekDay weekday)
        {
            if (weekday == WeekDay.SATURDAY || weekday == WeekDay.SUNDAY)
            {
                return "Rest Time.";
            }
            return "Working Time.";
        }
    }
}
