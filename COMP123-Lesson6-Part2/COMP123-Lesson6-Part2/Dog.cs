using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_Part2
{
    class Dog :  Animal
    {
        public  Dog(string name)
            : base(name)
        {

        }

        public override string Speak()
        {
            return this.Name + "says woof";
        }

        public override void Runs()
        {
            Console.WriteLine("{0} is lame and can't run", this.Name);
        }

        public override void Eats()
        {
            Console.WriteLine("{0} is eating", this.Name);
        }
    }
}
