using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{
    class GenderException: ApplicationException
    {
        public GenderException(String message): base(message)
        {

        }
    }
}
