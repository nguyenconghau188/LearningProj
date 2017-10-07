using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    public enum Position
    {
        [PositionAttribute("E","Engineer", 3.0f)]
        ENGINEER,
        [PositionAttribute("S", "Staff", 2.0f)]
        STAFF,
        [PositionAttribute("W", "Worker", 1.0f)]
        WORKER
    }
}
