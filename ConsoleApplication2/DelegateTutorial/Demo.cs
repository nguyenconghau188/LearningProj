using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTutorial
{
    class Demo
    {
        //public delegate string SalaryString(string salary, string countryCode);

        public static string SalaryString(float salary, string countryCode)
        {
            AnonymousMethod.TaxFormula taxFormula = AnonymousMethod.GetTaxFormula(countryCode);
            float tax = taxFormula(salary);
            AnonymousMethod.RealSalary realSalary = AnonymousMethod.GetRealSalary(countryCode);
            float salaryAfterTax = realSalary(salary);
            return "Country Code = " + countryCode + " | salary = " + salary + "| tax = " + tax + " | salary after tax = " + salaryAfterTax;
        }

        static void Main(string[] args)
        {
            //float salary = 100;

            //TaxFormulas.TaxFormula formula = TaxFormulas.GetSalaryFormula("VN");
            //float tax = formula(salary);
            //Console.WriteLine("Tax in Viet Nam = {0}", tax);

            //formula = TaxFormulas.GetSalaryFormula("CA");
            //tax = formula(salary);
            //Console.WriteLine("Tax in Canada = {0}", tax);

            float salary;
            string countryCode;

            Console.WriteLine("Enter country code: ");
            countryCode = Console.ReadLine();
            Console.WriteLine("Enter salary: ");
            salary = float.Parse(Console.ReadLine());

            Console.WriteLine(SalaryString(salary, countryCode));

            Console.Read();

        }
    }
}
