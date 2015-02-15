using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_Part2
{
    class Cat : Animal
    {
        // constructors
        public  Cat(string name) 
            : base(name)
        {

        }

        // public methods +++++++++++++++++++++++++++++++++
        public override string Speak()
        {
            return this.Name + " says meow";
        }

        //apply override method
        public override void Eats()
        {
            Console.WriteLine("{0} can't eat, because she has a stomach problem", this.Name);
        }
    }
}
