using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetBackEndFullStack
{
    public class Cow : Animal
    {
        public override string Eat()
        {
            return "An co";
        }

        public override string AnimalSound()
        {
            return "bò bò";
        }

        public override string Eat2()
        {
            throw new NotImplementedException();
        }
    }
}
