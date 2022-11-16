using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetBackEndFullStack
{
    public class Person
    {
        private string Name { get; set; }
        public string FirstName { get; set; }

        public string SetName(string name)
        {
            Name = "Nguyễn :" + name;
            return Name;
        }
    }
}
