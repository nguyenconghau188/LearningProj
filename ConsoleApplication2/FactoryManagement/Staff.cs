using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    class Staff: People
    {
        public string job { get; set; }

        public Staff()
        {

        }

        public Staff(string name, DateTime dayOfBirth, Gender gender, string address, Position position, string job)
            : base(name, dayOfBirth, gender, address, position)
        {
            this.job = job;
        }
    }
}
