using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    public enum Gender
    {
        [GenderAttribute("M", "Male")]
        MALE,
        [GenderAttribute("F", "Female")]
        FEMALE
    }
}
