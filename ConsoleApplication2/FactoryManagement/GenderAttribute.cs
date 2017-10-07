using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    class GenderAttribute: Attribute
    {
        private string code;
        private string text;

        internal GenderAttribute(string code, string text)
        {
            this.code = code;
            this.text = text;
        } 

        internal string GetCode()
        {
            return code;
        }

        internal string GetText()
        {
            return text;
        }
    }
}
