using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetBackEndFullStack
{
    public class Bird : Animal
    {
        public override string Eat()
        {
            return "Con sau";
        }

        public override string AnimalSound()
        {
            return "Chip chip";
        }

        public override string Eat1()
        {
            throw new NotImplementedException();
        }
    }
}
