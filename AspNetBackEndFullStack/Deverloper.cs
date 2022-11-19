using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetBackEndFullStack
{
    public class Deverloper : Employee, IAttendance
    {
        public string checkAttendance(int ischeck)
        {
            return ischeck == 1 ? "Deverloper Đã điểm danh" : "Deverloper Chưa điểm danh";
        }

        public override void Working()
        {
            Console.WriteLine("Developer working");
        }
    }
}
