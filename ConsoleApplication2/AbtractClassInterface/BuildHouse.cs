using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractClassInterface
{
    class BuildHouse: ManualJob
    {
        public BuildHouse()
        {

        }

        // Triển khai phương thức trừu tượng của lớp cha.   
        // (Cần phải sử dụng từ khóa 'override').
        public override void DoJob()
        {
            Console.WriteLine("Build a House");
        }
    }
}
