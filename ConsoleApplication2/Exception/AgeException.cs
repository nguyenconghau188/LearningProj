using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{
    class AgeException: ApplicationException
    {
        public AgeException(string message): base(message)
        {
    
        }
    }

    class TooYoungException: AgeException
    {
        public TooYoungException(string message): base(message)
        {

        }
    }

    class TooOldException: AgeException
    {
        public TooOldException(string message): base(message)
        {

        }
    }
}
