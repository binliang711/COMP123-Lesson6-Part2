using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            
            
           Cat myCat = new Cat("Tiger");
           Console.WriteLine(myCat.Speak());
           myCat.Runs();
           myCat.Eats();

           Dog myDog = new Dog("Conan");
           Console.WriteLine(myDog.Speak());
           myDog.Runs();
           myDog.Eats();

           Console.WriteLine();
           Console.WriteLine("++++++++++++++++++++++++++++++++++");
           Console.WriteLine("Press any key exit ...");
           Console.ReadKey();
        }
    }
}
