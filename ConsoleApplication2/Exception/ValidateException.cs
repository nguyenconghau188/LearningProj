using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{
    class ValidateException: ApplicationException
    {
        public ValidateException(Exception e): base("Something invalid", e)
        {

        }
    }
}
