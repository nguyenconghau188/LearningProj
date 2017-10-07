using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtractClassInterface
{

        // ManualJob - (Mô phỏng một công việc phổ thông)
        // Lớp cha của nó (AbstractJob) có 2 phương thức trừu tượng.
        // Lớp này mới chỉ thực hiện 1 phương thức của lớp cha.
        // Vì vậy nó bắt buộc phải được khai báo là 'abstract'.
        public abstract class ManualJob : AbstractJob
        {

            public ManualJob()
            {

            }

            // Thực hiện phương thức trừu tượng khai báo tại lớp cha.
            // (Cần phải có từ khóa 'override').
            public override String GetJobName()
            {
                return "Manual Job";
            }

        }
}
