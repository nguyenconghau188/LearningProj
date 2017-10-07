using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTutorial
{
    class AnonymousMethod
    {
        public delegate float TaxFormula(float salary);

        public static TaxFormula GetTaxFormula(string countryCode)
        {
            if (countryCode == "USA")
            {
                TaxFormula usaTaxFormula = delegate (float salary)
                {
                    return 10 * salary / 100;
                };
                return usaTaxFormula;
            }
            else if (countryCode == "VN")
            {
                TaxFormula vietnamTaxFormula = delegate (float salary)
                {
                    return 5 * salary / 100;
                };
                return vietnamTaxFormula;
            }
            TaxFormula defaultTaxFormula = delegate (float salary)
            {
                return 7 * salary / 100;
            };
            return defaultTaxFormula;
        }

        public delegate float RealSalary(float salary);

        public static RealSalary GetRealSalary(string coundtryCode)
        {
            if (coundtryCode == "VN")
            {
                RealSalary vietnameRealSalary = delegate (float salary)
                {
                    TaxFormula formula = GetTaxFormula("VN");
                    float tax = formula(salary);
                    return salary - tax;
                };
                return vietnameRealSalary;
            }
            else if (coundtryCode == "USA")
            {
                RealSalary usaRealSalary = delegate (float salary)
                {
                    TaxFormula formula = GetTaxFormula("USA");
                    float tax = formula(salary);
                    return salary - tax;
                };
                return usaRealSalary;
            }
            RealSalary defaultRealSalary = delegate (float salary)
            {
                TaxFormula formula = GetTaxFormula(coundtryCode);
                float tax = formula(salary);
                return salary - tax;
            };
            return defaultRealSalary;

        }
    }
}
