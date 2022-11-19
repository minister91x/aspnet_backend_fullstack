using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetBackEndFullStack
{
    public class Cleaner : Employee
    {
        public override void Working()
        {
            Console.WriteLine("Cleaner Working");
        }
    }
}
