using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach(var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach(var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }

        }
    }
}
