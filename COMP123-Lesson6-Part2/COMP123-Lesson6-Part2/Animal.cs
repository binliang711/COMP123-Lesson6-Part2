using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_Part2
{
    abstract class Animal : IEats
    {
        // private instance variables ++++++++++++++++++++++++++++++++++++
        private string _name;

        //public properties +++++++++++++++++++++++++++++++++++++++++++
        public string Name
        {
           get 
           {
              return this._name; //Read-only
           }
        }
       public Animal(string name)
       {
          this._name = name;
       }

       // ABSTRACT METHODS +++++++++++++++++++++++++++++++++++++++++++++++
       public abstract string Speak();
     
       // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++ 
       public virtual void Runs()
       {
          Console.WriteLine("{0} is running", this._name);
       }
       public abstract void Eats();
    }
}
