using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    class Worker: People
    {
        public int rankWorker { get; set; }

        public Worker()
        {

        }

        public Worker(string name, DateTime dayOfBirth, Gender gender, string address, Position position, int rankWorker) 
            : base( name, dayOfBirth, gender, address, position)
        {
            this.rankWorker = rankWorker;
        }
    }
}
