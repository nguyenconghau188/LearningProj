using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    class Engineer: People
    {
        public string specialize { get; set; }

        public Engineer()
        {

        }

        public Engineer(string name, DateTime dayOfBirth, Gender gender, string address, Position position, string specialize)
            : base(name, dayOfBirth, gender, address, position)
        {
            this.specialize = specialize;
        }
    }
}
