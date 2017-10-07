using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumClass
{
    public enum Gender
    {
        [GenderAttr("M", "Male")]
        MALE,
        [GenderAttr("F", "Female")]
        FEMALE
    }
}
