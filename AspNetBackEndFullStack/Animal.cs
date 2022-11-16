using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetBackEndFullStack
{
   public abstract class Animal
    {
        public Animal()
        {

        }
        public string Name { get; set; }
        public abstract string Eat();
        public abstract string Eat1();
        public virtual string AnimalSound()
        {
            return "be be";
        }

       
    }
}
