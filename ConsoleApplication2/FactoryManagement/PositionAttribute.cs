using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    class PositionAttribute: Attribute
    {
        private string code;
        private string text;
        private float salaryRank;
        
        internal PositionAttribute(string code, string text, float salaryRank)
        {
            this.code = code;
            this.text = text;
            this.salaryRank = salaryRank;
        }

        public string GetCode()
        {
            return code;
        }

        public string GetText()
        {
            return text;
        }

        public float GetSalaryRank()
        {
            return salaryRank;
        }
    }
}
