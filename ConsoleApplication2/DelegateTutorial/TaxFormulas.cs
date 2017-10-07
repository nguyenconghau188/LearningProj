using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTutorial
{
    class TaxFormulas
    {
        public delegate float TaxFormula(float salary);

        public static float UsaFormula(float salary)
        {
            return 10 * salary / 100;
        }

        public static float VietnamFormula(float salary)
        {
            return 5 * salary / 100;
        }

        public static float DefaultFormula(float salary)
        {
            return 7 * salary / 100;
        }

        public static TaxFormula GetSalaryFormula(string countryCode)
        {
            if (countryCode == "VN")
            {
                return TaxFormulas.VietnamFormula;
            }
            else if (countryCode == "USA")
            {
                return TaxFormulas.UsaFormula;
            }
            return TaxFormulas.DefaultFormula;
        }
    }
}
