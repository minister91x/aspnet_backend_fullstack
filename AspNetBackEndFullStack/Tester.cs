using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetBackEndFullStack
{
    public class Tester : Employee,IAttendance
    {
        public string checkAttendance(int ischeck)
        {
            return ischeck == 1 ? "Tester Đã điểm danh" : "Tester Chưa điểm danh";
        }

        public override void Working()
        {
            Console.WriteLine("Test Working");
        }
    }
}
