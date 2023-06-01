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
            List<Animal> Animals = new List<Animal>() { new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat() };


            //List<Object> Things = new List<Object>() { new Dog(), new Dog(), new Dog(), new Cat(), new Cat(), new Cat() };
            // -> 상속 없이 두 클래스를 합쳐 사용할 수 있다.


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
