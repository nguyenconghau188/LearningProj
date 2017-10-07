using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractClassInterface
{
    public abstract class AbstractJob
    {

        public AbstractJob()
        {

        }

        public abstract String GetJobName();
        public abstract void DoJob();
        public void StopJob()
        {
            Console.WriteLine("Stop");
        }

    }
}
